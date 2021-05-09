using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Interfaces.Services.Games;
using Imi.Project.Api.Core.Interfaces.Services.Users;
using Imi.Project.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "OnlyUserAccess")]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        private readonly IPlayedGameService _playedGameService;
        private readonly SignInManager<Player> _signInManager;
        private readonly IConfiguration _configuration;
        public PlayersController(IPlayerService playerService, IPlayedGameService playedGameService,
            SignInManager<Player> signInManager, IConfiguration configuration)
        {
            _playerService = playerService;
            _playedGameService = playedGameService;
            _signInManager = signInManager;
            _configuration = configuration;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                var players = await _playerService.SearchByNameAsycn(name);
                if (players.Any())
                    return Ok(players);
                else
                    return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerName, name));
            }
            else
            {
                var players = await _playerService.ListAllAsync();
                return Ok(players);
            }
        }
        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {
            var player = await _playerService.GetByIdAsync(guid);
            if (player == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerId, guid));
            return Ok(player);
        }
        [HttpGet("{guid}/playedgames")]
        public async Task<IActionResult> GetByPlayerId(Guid guid)
        {
            var player = await _playerService.GetByIdAsync(guid);
            if(player == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerId, guid));
            var playedGames = await _playedGameService.GetByPlayerIdAsync(guid);
            if (!playedGames.Any())
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerPlayedGames, guid));
            return Ok(playedGames);
        }
        [HttpPost]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> Post(PlayerRequestDto playerRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var playerResponseDto = await _playerService.AddAsync(playerRequestDto);
            return CreatedAtAction(nameof(Get), new { id = playerResponseDto.Id }, playerResponseDto);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateByPlayer(PlayerRequestDto playerRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var playerResponseDto = await _playerService.UpdateAsync(playerRequestDto);
            return CreatedAtAction(nameof(Get), new { id = playerResponseDto.Id }, playerResponseDto);
        }        
        [HttpDelete("{guid}")]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> Delete(Guid guid)
        {
            var playerEntity = await _playerService.GetByIdAsync(guid);
            if (playerEntity == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerId, guid));
            await _playerService.DeleteAsync(guid);
            return Ok();
        }
        [HttpPut("{guid}/IsActive")]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> Put(Guid guid, [FromQuery] bool isActive)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            await _playerService.UpdateAsync(guid, isActive);
            return Ok(string.Format(CustomExceptionMessages.UpdatePlayerInfo, guid));
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterPlayerRequestDto registration)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            IdentityResult result = await _playerService.AddRegisteredPlayerAsync(registration); 
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                    ModelState.AddModelError(error.Code, error.Description);
                return BadRequest(ModelState);
            }
            return Ok();
        }
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login([FromBody]LoginPlayerRequestDto login)
        {
            var result = await _signInManager.PasswordSignInAsync(login.Username, login.Password, isPersistent: false, lockoutOnFailure: false);
            if (!result.Succeeded)
                return Unauthorized();
            var player = await _signInManager.UserManager.FindByNameAsync(login.Username);
            string token = await GenerateJwtSecurityTokenAsync(player);
            return Ok(new LoginPlayerResponseDto { Token = token });
        }
        [HttpGet("{guid}/Roles")]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> GetRolesByPlayerId(Guid guid)
        {
            var result = await _playerService.GetByIdAsync(guid);
            if (result == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerId, guid));
            var roles = await _playerService.GetRolesByPlayerId(guid);
            if (!roles.Any())
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerRoles, guid));
            return Ok(roles);
        }
        private async Task<string> GenerateJwtSecurityTokenAsync(Player player)
        {
            var claims = new List<Claim>();
            var userClaims = await _signInManager.UserManager.GetClaimsAsync(player);
            claims.AddRange(userClaims);

            var roleClaims = await _signInManager.UserManager.GetRolesAsync(player);
            foreach (var roleClaim in roleClaims)
                claims.Add(new Claim(ClaimTypes.Role, roleClaim));
            var expirationDays = _configuration.GetValue<int>("JWTConfiguration:TokenExpirationDays");
            var signingKey = Encoding.UTF8.GetBytes(_configuration.GetValue<string>("JWTConfiguration:SigningKey"));
            var token = new JwtSecurityToken
            (
                issuer: _configuration.GetValue<string>("JWTConfiguration:Issuer"),
                audience: _configuration.GetValue<string>("JWTConfiguration:Audience"),
                claims: claims,
                expires: DateTime.UtcNow.Add(TimeSpan.FromDays(expirationDays)),
                notBefore: DateTime.UtcNow,
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(signingKey), SecurityAlgorithms.HmacSha256)                
            );
            var serializedToken = new JwtSecurityTokenHandler().WriteToken(token);
            return serializedToken;
        }
    }
}
