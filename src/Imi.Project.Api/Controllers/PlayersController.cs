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
                var playersDto = await _playerService.SearchByNameAsycn(name);
                if (playersDto.Any())
                    return Ok(playersDto);
                else
                    return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerName, name));
            }
            else
            {
                var playersDto = await _playerService.ListAllAsync();
                return Ok(playersDto);
            }
        }
        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {
            var playerDto = await _playerService.GetByIdAsync(guid);
            if (playerDto == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerId, guid));
            return Ok(playerDto);
        }
        [HttpGet("{guid}/playedgames")]
        public async Task<IActionResult> GetByPlayerId(Guid guid)
        {
            var playerDto = await _playerService.GetByIdAsync(guid);
            if(playerDto == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerId, guid));
            var playedGamesDto = await _playedGameService.GetByPlayerIdAsync(guid);
            if (!playedGamesDto.Any())
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerPlayedGames, guid));
            return Ok(playedGamesDto);
        }
        [HttpPost]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> Post(PlayerRequestDto playerRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var playerResponseDto = await _playerService.AddAsync(playerRequestDto);
                return CreatedAtAction(nameof(Get), new { id = playerResponseDto.Id }, playerResponseDto);
            }
            catch (Exception)
            { return Conflict(CustomExceptionMessages.ConflictAddPlayer); }
        }
        [HttpPut]
        public async Task<IActionResult> UpdateByPlayer(PlayerRequestDto playerRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var playerResponseDto = await _playerService.UpdateAsync(playerRequestDto);
                return CreatedAtAction(nameof(Get), new { id = playerResponseDto.Id }, playerResponseDto);
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictUpdatePlayer, playerRequestDto.Id)); }
        }        
        [HttpDelete("{guid}")]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> Delete(Guid guid)
        {
            try
            {
                var playerEntity = await _playerService.GetByIdAsync(guid);
                if (playerEntity == null)
                    return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerId, guid));
                await _playerService.DeleteAsync(guid);
                return Ok(string.Format(CustomExceptionMessages.DeletePlayerId, guid));
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictDeletePlayerId, guid)); }
        }
        [HttpPut("{guid}/IsActive")]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> Put(Guid guid, [FromQuery] bool isActive)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                await _playerService.UpdateAsync(guid, isActive);
                return Ok(string.Format(CustomExceptionMessages.UpdatePlayerInfo, guid));
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictUpdatePlayerIsActive, guid)); }
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register([FromBody] RegisterPlayerRequestDto registration)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var identityResultUser= await _playerService.AddRegisteredPlayerAsync(registration); 
            if (!identityResultUser.Succeeded)
            {
                foreach (var error in identityResultUser.Errors)
                    ModelState.AddModelError(error.Code, error.Description);
                return BadRequest(ModelState);
            }
            return Ok(CustomExceptionMessages.RegisterPlayer);
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
            var playerDto = await _playerService.GetByIdAsync(guid);
            if (playerDto == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerId, guid));
            var rolesDto = await _playerService.GetRolesByPlayerId(guid);
            if (!rolesDto.Any())
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerRoles, guid));
            return Ok(rolesDto);
        }
        [HttpDelete("{guid}/Roles")]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> DeletePlayerFromRole(Guid guid)
        {
            var identityResult = await _playerService.DeletePlayerFromRoles(guid);
            if (!identityResult.Succeeded)
                return Conflict(string.Format(CustomExceptionMessages.ConflictDeleteRolesFromPlayer, guid));
            return Ok(string.Format(CustomExceptionMessages.DeleteRolesFromPlayer, guid));
        }
        [HttpPost("{guid}/Roles/{roleId}")]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> AddPlayerToRole(Guid guid, Guid roleId)
        {
            var IdentityResult = await _playerService.AddPlayerToRole(guid, roleId);
            if (!IdentityResult.Succeeded)
                return Conflict(string.Format(CustomExceptionMessages.ConflictAddRoleToPlayer, roleId, guid));
            return Ok(string.Format(CustomExceptionMessages.AddPlayerRole, guid));
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

// eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJyZWdpc3RyYXRpb24tZGF0ZSI6IjIwMTUtMDEtMDEiLCJkb2IiOiIxOTg4LTAyLTA5IiwiZmlyc3RuYW1lY2hhciI6IkIiLCJodHRwOi8vc2NoZW1hcy5taWNyb3NvZnQuY29tL3dzLzIwMDgvMDYvaWRlbnRpdHkvY2xhaW1zL3JvbGUiOiJBZG1pbiIsIm5iZiI6MTYyMDkxMjY3MiwiZXhwIjoxNjIxNTE3NDcyLCJpc3MiOiJCb2FyZEdhbWVEQkJWV2ViQXBpIiwiYXVkIjoiaHR0cHM6Ly9sb2NhbGhvc3Q6NTAwMSJ9.A-Ube1bDpARjEWY4nIvI0FHirl0cq4KzeoIzk5n6vuQ
