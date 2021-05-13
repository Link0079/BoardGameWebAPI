using AutoMapper;
using Imi.Project.Api.Core.Dtos.IdentityManagment;
using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Interfaces.Services.Users;
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
    [Authorize(Policy = "Administrators")]
    public class RolesController : ControllerBase
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IPlayerService _playerService;
        private readonly IMapper _mapper;
        public RolesController(RoleManager<ApplicationRole> roleManager,
            IPlayerService playerService,IMapper mapper)
        {
            _roleManager = roleManager;
            _playerService = playerService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                var roles = _roleManager.Roles.Where(r=>r.Name.Contains(name));
                if (roles.Any())
                {
                    var dto = _mapper.Map<IEnumerable<RoleResponseDto>>(roles);
                    return Ok(dto);
                }
                else
                    return NotFound(string.Format(CustomExceptionMessages.NotFoundRoleName, name));
            }
            else
            {
                var roles = _roleManager.Roles;
                var dto = _mapper.Map<IEnumerable<RoleResponseDto>>(roles);
                return Ok(dto);
            }
        }
        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {
            var role = await _roleManager.FindByIdAsync(guid.ToString());
            if (role == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundRoleId, guid));
            var dto = _mapper.Map<RoleResponseDto>(role);
            return Ok(dto);
        }
        [HttpPost]
        public async Task<IActionResult> Post(RoleRequestDto roleRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var result = await _roleManager.RoleExistsAsync(roleRequestDto.Name);
            if (result)
                return Conflict(string.Format(CustomExceptionMessages.ConfiltRoleNameExists, roleRequestDto.Name));
            var newRole = new ApplicationRole
            {
                Name = roleRequestDto.Name,
                NormalizedName = roleRequestDto.Name.ToUpper()
            };
            var identityResult = await _roleManager.CreateAsync(newRole);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                    ModelState.AddModelError(error.Code, error.Description);
                return BadRequest(ModelState);
            }
            var dto = _mapper.Map<RoleResponseDto>(newRole);
            return Ok(dto);
        }
        [HttpPut]
        public async Task<IActionResult> Put(RoleRequestDto roleRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            var role = await _roleManager.FindByIdAsync(roleRequestDto.Id.ToString());
            role.Name = roleRequestDto.Name;
            var identityResult = await _roleManager.UpdateAsync(role);
            if(!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                    ModelState.AddModelError(error.Code, error.Description);
                return BadRequest(ModelState);
            }
            var dto = _mapper.Map<RoleResponseDto>(role);
            return Ok(dto);
        }
        [HttpDelete("{guid}")]
        public async Task<IActionResult> Delete(Guid guid)
        {
            var result = await _roleManager.FindByIdAsync(guid.ToString());
            if (result == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundRoleId, guid));
            var identityResult = await _roleManager.DeleteAsync(result);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                    ModelState.AddModelError(error.Code, error.Description);
                return BadRequest(ModelState);
            }
            else
                return Ok(string.Format(CustomExceptionMessages.DeleteRoleId, guid));
        }
        [HttpGet("{guid}/Users")]
        public async Task<IActionResult> GetPlayersByRoleId(Guid guid)
        {
            var result = await _roleManager.FindByIdAsync(guid.ToString());
            if (result == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundRoleId, guid));
            var dto = await _playerService.GetPlayersByRole(guid);
            return Ok(dto);
        }
    }
}
