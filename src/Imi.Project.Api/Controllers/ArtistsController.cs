using Imi.Project.Api.Core.Dtos;
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
    public class ArtistsController : ControllerBase
    {
        private readonly IArtistService _artistService;
        public ArtistsController(IArtistService artistService)
        {
            _artistService = artistService;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var artists = await _artistService.ListAllAsync();
            return Ok(artists);
        }
        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {
            var artist = await _artistService.GetByIdAsync(guid);
            if (artist == null)
                return NotFound($"Artist with id {guid} does not exist.");
            return Ok(artist);
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
    }
}
