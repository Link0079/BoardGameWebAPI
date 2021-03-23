using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Interfaces.Services;
using Microsoft.AspNetCore.Http;
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
        public PlayersController(IPlayerService playerService, IPlayedGameService playedGameService)
        {
            _playerService = playerService;
            _playedGameService = playedGameService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var players = await _playerService.ListAllAsync();
            return Ok(players);
        }
        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {
            var player = await _playerService.GetByIdAsync(guid);
            if (player == null)
                return NotFound($"Players with id {guid} does not exist.");
            return Ok(player);
        }
        [HttpGet("{guid}/playedGames")]
        public async Task<IActionResult> GetByPlayerId(Guid guid)
        {
            var playedGames = await _playedGameService.GetByPlayerIdAsync(guid);
            if (!playedGames.Any())
                return NotFound($"Players with id {guid} has not played any games yet.");
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
                return NotFound($"Artist with id {guid} does not exist.");
            await _playerService.DeleteAsync(guid);
            return Ok();
        }
    }
}
