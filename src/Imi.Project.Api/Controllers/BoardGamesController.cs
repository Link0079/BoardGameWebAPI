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
    public class BoardGamesController : ControllerBase
    {
        private readonly IBoardGameService _boardGameService;
        public BoardGamesController(IBoardGameService boardGameService)
        {
            _boardGameService = boardGameService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var boardGames = await _boardGameService.ListAllAsync();
            return Ok(boardGames);
        }
        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {
            var boardGame = await _boardGameService.GetByIdAsync(guid);
            if (boardGame == null)
                return NotFound($"Boardgame with id {guid} does not exist.");
            return Ok(boardGame);
        }
    }
}
