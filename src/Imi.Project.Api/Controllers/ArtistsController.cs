using Imi.Project.Api.Core.Dtos;
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
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistService _artistService;
        private readonly IBoardGameService _boardGameService;
        public ArtistsController(IArtistService artistService, IBoardGameService boardGameService)
        {
            _artistService = artistService;
            _boardGameService = boardGameService;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                var boardGames = await _artistService.SearchByNameAsycn(name);
                if (boardGames.Any())
                    return Ok(boardGames);
                else
                    return NotFound($"There were no artists found that contain \"{name}\" in their Name.");
            }
            else
            {
                var boardGames = await _artistService.ListAllAsync();
                return Ok(boardGames);
            }
        }
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var artists = await _artistService.ListAllAsync();
        //    return Ok(artists);
        //}
        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {
            var artist = await _artistService.GetByIdAsync(guid);
            if (artist == null)
                return NotFound($"Artist with id {guid} does not exist.");
            return Ok(artist);
        }
        [HttpGet("{guid}/boardgames")]
        public async Task<IActionResult> GetbyArtistId(Guid guid)
        {
            var boardgames = await _boardGameService.GetByArtistIdAsync(guid);
            if (!boardgames.Any())
                return NotFound($"Artist with id {guid} has no boardgames.");
            return Ok(boardgames);
        }
        [HttpPost]
        public async Task<IActionResult> Post(ArtistRequestDto artistRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var artistResponseDto = await _artistService.AddAsync(artistRequestDto);
            return CreatedAtAction(nameof(Get), new { id = artistResponseDto.Id }, artistResponseDto);
        }
        [HttpPut]
        public async Task<IActionResult> Put(ArtistRequestDto artistRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var artistResponseDto = await _artistService.UpdateAsync(artistRequestDto);
            return CreatedAtAction(nameof(Get), new { id = artistResponseDto.Id }, artistResponseDto);
        }
        [HttpDelete("{guid}")]
        public async Task<IActionResult> Delete(Guid guid)
        {
            var artistEntity = await _artistService.GetByIdAsync(guid);
            if (artistEntity == null)
                return NotFound($"Artist with id {guid} does not exist.");
            await _artistService.DeleteAsync(guid);
            return Ok();
        }
    }
}
