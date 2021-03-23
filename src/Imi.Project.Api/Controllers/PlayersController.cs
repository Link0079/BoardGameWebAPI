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
        public PlayersController(IPlayerService playerService)
        {
            _playerService = playerService;
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
    }
}
