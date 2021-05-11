using Imi.Project.Api.Core.Dtos.Games;
using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Interfaces.Services;
using Imi.Project.Api.Core.Interfaces.Services.Games;
using Imi.Project.Common;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Policy = "OnlyUserAccess")]
    public class PlayedGamesController : ControllerBase
    {
        private readonly IPlayedGameService _playedGameService;
        public PlayedGamesController(IPlayedGameService playedGameService)
        {
            _playedGameService = playedGameService;
        }
        [HttpGet]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> Get()
        {
            var playedGames = await _playedGameService.ListAllAsync();
            return Ok(playedGames);
        }
        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {
            var playedGame = await _playedGameService.GetByIdAsync(guid);
            if (playedGame == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayedGameId, guid));
            return Ok(playedGame);
        }
        [HttpPost]
        public async Task<IActionResult> Post(PlayedGameRequestDto playedGameRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var playedGameResponseDto = await _playedGameService.AddAsync(playedGameRequestDto);
            return CreatedAtAction(nameof(Get), new { id = playedGameResponseDto.Id }, playedGameResponseDto);
        }
        [HttpPut]
        public async Task<IActionResult> Put(PlayedGameRequestDto playedGameRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var playedGameResponseDto = await _playedGameService.UpdateAsync(playedGameRequestDto);
            return CreatedAtAction(nameof(Get), new { id = playedGameResponseDto.Id }, playedGameResponseDto);
        }
        [HttpDelete("{guid}")]
        public async Task<IActionResult> Delete(Guid guid)
        {
            var playedGameEntity = await _playedGameService.GetByIdAsync(guid);
            if (playedGameEntity == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundPlayedGameId, guid));
            await _playedGameService.DeleteAsync(guid);
            return Ok(string.Format(CustomExceptionMessages.DeletePlayedGameId, guid));
        }

    }
}
