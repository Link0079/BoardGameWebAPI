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
    public class PlayedGamesController : ControllerBase
    {
        private readonly IPlayedGameService _playedGameService;
        public PlayedGamesController(IPlayedGameService playedGameService)
        {
            _playedGameService = playedGameService;
        }
        [HttpGet]
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
                return NotFound($"Games with id {guid} does not exist.");
            return Ok(playedGame);
        }
    }
}
