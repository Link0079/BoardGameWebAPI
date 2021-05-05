using AutoMapper.Configuration;
using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Interfaces.Services.Games;
using Imi.Project.Api.Core.Interfaces.Services.Users;
using Imi.Project.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        private readonly IPlayerService _playerService;
        private readonly IPlayedGameService _playedGameService;
        private readonly SignInManager<Player> _signInManager;
        public PlayersController(IPlayerService playerService, IPlayedGameService playedGameService, SignInManager<Player> signInManager)
        {
            _playerService = playerService;
            _playedGameService = playedGameService;
            _signInManager = signInManager;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                var boardGames = await _playerService.SearchByNameAsycn(name);
                if (boardGames.Any())
                    return Ok(boardGames);
                else
                    return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerName, name));
            }
            else
            {
                var boardGames = await _playerService.ListAllAsync();
                return Ok(boardGames);
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
        public async Task<IActionResult> Post(PlayerRequestDto playerRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var playerResponseDto = await _playerService.AddAsync(playerRequestDto);
            return CreatedAtAction(nameof(Get), new { id = playerResponseDto.Id }, playerResponseDto);
        }
        [HttpPut]
        public async Task<IActionResult> Put(PlayerRequestDto playerRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var playerResponseDto = await _playerService.UpdateAsync(playerRequestDto);
            return CreatedAtAction(nameof(Get), new { id = playerResponseDto.Id }, playerResponseDto);
        }
        [HttpDelete("{guid}")]
        public async Task<IActionResult> Delete(Guid guid)
        {
            var playerEntity = await _playerService.GetByIdAsync(guid);
            if (playerEntity == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayerId, guid));
            await _playerService.DeleteAsync(guid);
            return Ok();
        }
        [HttpPost("register")]
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
    }
}
