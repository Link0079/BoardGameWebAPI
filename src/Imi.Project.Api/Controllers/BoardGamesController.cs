using Imi.Project.Api.Core.Dtos.Games;
using Imi.Project.Api.Core.Interfaces.Services;
using Imi.Project.Api.Core.Interfaces.Services.Games;
using Imi.Project.Common;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
    public class BoardGamesController : ControllerBase
    {
        private readonly IBoardGameService _boardGameService;
        private readonly ICategoryService _categoryService;
        private readonly IArtistService _artistService;
        public BoardGamesController(IBoardGameService boardGameService, ICategoryService categoryService, IArtistService artistService)
        {
            _boardGameService = boardGameService;
            _categoryService = categoryService;
            _artistService = artistService;
        }
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Get([FromQuery] string title)
        {
            if (!String.IsNullOrWhiteSpace(title))
            {
                var boardGamesDto = await _boardGameService.SearchByNameAsycn(title);
                if (boardGamesDto.Any())
                    return Ok(boardGamesDto);
                else
                    return NotFound(string.Format(CustomExceptionMessages.NotFoundBoardGameTitle, title));
            }
            else
            {
                var boardGamesDto = await _boardGameService.ListAllAsync();
                return Ok(boardGamesDto);
            }
        }
        [HttpGet("{guid}")]
        [AllowAnonymous]
        public async Task<IActionResult> Get(Guid guid)
        {
            var boardGameDto = await _boardGameService.GetByIdAsync(guid);
            if (boardGameDto == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundBoardGameId, guid));
            return Ok(boardGameDto);
        }
        [HttpPost]
        [Authorize(Policy = "BoardGameEditors")]
        public async Task<IActionResult> Post(BoardGameRequestDto boardGameRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var boarGameResponseDto = await _boardGameService.AddAsync(boardGameRequestDto);
                return CreatedAtAction(nameof(Get), new { id = boarGameResponseDto.Id }, boarGameResponseDto);
            }
            catch (Exception)
            { return Conflict(CustomExceptionMessages.ConflictAddBoardGame); }
        }
        [HttpPut]
        [Authorize(Policy = "BoardGameEditors")]
        public async Task<IActionResult> Put(BoardGameRequestDto boardGameRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var boarGameResponseDto = await _boardGameService.UpdateAsync(boardGameRequestDto);
                return CreatedAtAction(nameof(Get), new { id = boarGameResponseDto.Id }, boarGameResponseDto);
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictUpdateBoardgame, boardGameRequestDto.Id)); }
        }
        [HttpDelete("{guid}")]
        [Authorize(Policy = "BoardGameEditors")]
        public async Task<IActionResult> Delete(Guid guid)
        {
            try
            {
                var boardGameEntity = await _boardGameService.GetByIdAsync(guid);
                if (boardGameEntity == null)
                    return NotFound(string.Format(CustomExceptionMessages.NotFoundBoardGameId, guid));
                await _boardGameService.DeleteAsync(guid);
                return Ok(string.Format(CustomExceptionMessages.DeleteBoardGameId, guid));
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictDeleteBoardGameId, guid)); }
        }
        [HttpPut("{guid}/IsActive")]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> Put(Guid guid, [FromQuery] bool isActive)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                await _boardGameService.UpdateAsync(guid, isActive);
                return Ok(string.Format(CustomExceptionMessages.UpdateBoardGameInfo, guid));
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictUpdateBaordGameIsActive, guid)); }
        }
        [HttpPost("{guid}/Categories/{categoryId}")]
        [Authorize(Policy = "BoardGameEditors")]
        public async Task<IActionResult> PostBoardgameCategory(Guid guid, Guid categoryId)
        {
            try
            {
                var result = await _boardGameService.AddCategoryToBoardGame(guid, categoryId);
                if (!result)
                    return BadRequest("Category was not added to the boardgame");
                return Ok();
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictAddCategoryToBoardGame, guid, categoryId)); }
        }
        [HttpPost("{guid}/Artists/{artistId}")]
        [Authorize(Policy = "BoardGameEditors")]
        public async Task<IActionResult> PostBoardgameArtist(Guid guid, Guid artistId)
        {
            try
            {
                var result = await _boardGameService.AddArtistToBoardGame(guid, artistId);
                if (!result)
                    return BadRequest("Artist was not added to the boardgame.");
                return Ok();
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictAddArtistToBoardGame, guid, artistId)); }
        }
        [HttpDelete("{guid}/Categories/{categoryId}")]
        [Authorize(Policy = "BoardGameEditors")]
        public async Task<IActionResult> DeleteBoardgameCategory(Guid guid, Guid categoryId)
        {
            try
            {
                var result = await _boardGameService.DeleteCategoryFromBoardGame(guid, categoryId);
                if (!result)
                    return BadRequest("Category was not deleted from the boardgame.");
                return Ok();
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictDeleteCategoryFromBoardGame, guid, categoryId)); }
        }
        [HttpDelete("{guid}/Artists/{artistId}")]
        [Authorize(Policy = "BoardGameEditors")]
        public async Task<IActionResult> DeleteBoardgameArtist(Guid guid, Guid artistId)
        {
            try
            {
                var result = await _boardGameService.DeleteArtistFromBoardGame(guid, artistId);
                if (!result)
                    return BadRequest("Artist was not deleted from the boardgame.");
                return Ok();
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictDeleteArtistFromBoardGame, guid, artistId)); }
        }
    }
}