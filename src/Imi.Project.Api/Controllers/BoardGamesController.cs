using Imi.Project.Api.Core.Dtos.Games;
using Imi.Project.Api.Core.Interfaces.Services;
using Imi.Project.Api.Core.Interfaces.Services.Games;
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
        public async Task<IActionResult> Get([FromQuery] string title)
        {
            if (!String.IsNullOrWhiteSpace(title))
            {
                var boardGames = await _boardGameService.SearchByNameAsycn(title);
                if (boardGames.Any())
                    return Ok(boardGames);
                else
                    return NotFound($"There were no boardgames found that contain \"{title}\" in their title.");
            }
            else
            {
                var boardGames = await _boardGameService.ListAllAsync();
                return Ok(boardGames);
            }
        }
        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {
            var boardGame = await _boardGameService.GetByIdAsync(guid);
            if (boardGame == null)
                return NotFound($"Boardgame with id {guid} does not exist.");
            return Ok(boardGame);
        }
        [HttpPost]
        public async Task<IActionResult> Post(BoardGameRequestDto boardGameRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var boarGameResponseDto = await _boardGameService.AddAsync(boardGameRequestDto);
            return CreatedAtAction(nameof(Get), new { id = boarGameResponseDto.Id }, boarGameResponseDto);
        }
        [HttpPut]
        public async Task<IActionResult> Put(BoardGameRequestDto boardGameRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var boarGameResponseDto = await _boardGameService.UpdateAsync(boardGameRequestDto);
            return CreatedAtAction(nameof(Get), new { id = boarGameResponseDto.Id }, boarGameResponseDto);
        }
        [HttpDelete("{guid}")]
        public async Task<IActionResult> Delete(Guid guid)
        {
            var boardGameEntity = await _boardGameService.GetByIdAsync(guid);
            if (boardGameEntity == null)
                return NotFound($"Boardgame with id {guid} does not exist.");
            await _boardGameService.DeleteAsync(guid);
            return Ok();
        }
    }
}

//{
//  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
//  "title": "The BoardGame Game",
//  "price": 50,
//  "year": 2020,
//  "age": 10,
//  "rating": 4,
//  "minPlayers": 2,
//  "maxPlayers": 4,
//  "stock": false,
//  "playTime": 120,
//  "description": "Just a boardgame",
//  "categories": [
//    {
//        "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6"
//    }
//  ],
//  "artists": [
//    {
//        "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6"
//    }
//  ]
//}