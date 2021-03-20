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

    }
}
