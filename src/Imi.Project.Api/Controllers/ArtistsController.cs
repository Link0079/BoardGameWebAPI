using Imi.Project.Api.Core.Dtos;
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
    [Authorize(Policy = "OnlyUserAccess")]
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
                var artistsDto = await _artistService.SearchByNameAsycn(name);
                if (artistsDto.Any())
                    return Ok(artistsDto);
                else
                    return NotFound(string.Format(CustomExceptionMessages.NotFoundArtistName, name));
            }
            else
            {
                var artistsDto = await _artistService.ListAllAsync();
                return Ok(artistsDto);
            }
        }
        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {
            var artistDto = await _artistService.GetByIdAsync(guid);
            if (artistDto == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundArtistId, guid));
            return Ok(artistDto);
        }
        [HttpGet("{guid}/boardgames")]
        public async Task<IActionResult> GetbyArtistId(Guid guid)
        {
            var artistDto = await _artistService.GetByIdAsync(guid);
            if(artistDto == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundArtistId, guid));
            var boardgamesDto = await _boardGameService.GetByArtistIdAsync(guid);
            if (!boardgamesDto.Any())
                return NotFound(string.Format(CustomExceptionMessages.NotFoundArtistBoardGames, guid));
            return Ok(boardgamesDto);
        }
        [HttpPost]
        [Authorize(Policy = "ArtistEditors")]
        public async Task<IActionResult> Post(ArtistRequestDto artistRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var artistResponseDto = await _artistService.AddAsync(artistRequestDto);
                return CreatedAtAction(nameof(Get), new { id = artistResponseDto.Id }, artistResponseDto);
            }
            catch (Exception)
            { return Conflict(CustomExceptionMessages.ConflictAddArtist); }
        }
        [HttpPut]
        [Authorize(Policy = "ArtistEditors")]
        public async Task<IActionResult> Put(ArtistRequestDto artistRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
            var artistResponseDto = await _artistService.UpdateAsync(artistRequestDto);
            return CreatedAtAction(nameof(Get), new { id = artistResponseDto.Id }, artistResponseDto);
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictUpdateArtist, artistRequestDto.Id)); }
        }
        [HttpDelete("{guid}")]
        [Authorize(Policy = "ArtistEditors")]
        public async Task<IActionResult> Delete(Guid guid)
        {
            try
            {
                var artistEntity = await _artistService.GetByIdAsync(guid);
                if (artistEntity == null)
                    return NotFound(string.Format(CustomExceptionMessages.NotFoundArtistId, guid));
                await _artistService.DeleteAsync(guid);
                return Ok(string.Format(CustomExceptionMessages.DeleteArtistId, guid));
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictDeleteArtistId, guid)); }
        }
    }
}
