using AutoMapper;
using Imi.Project.Api.Core.Dtos.IdentityManagment;
using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Interfaces.Repositories.Users;
using Imi.Project.Api.Core.Interfaces.Services.Users;
using Imi.Project.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.Users
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly IMapper _mapper;
        public PlayerService(IPlayerRepository playerRepository,
            RoleManager<ApplicationRole> roleManager, IMapper mapper)
        {
            _playerRepository = playerRepository;
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public async Task<PlayerResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _playerRepository.GetByIdAsync(id);
            var dto = _mapper.Map<PlayerResponseDto>(result);
            return dto;
        }
        public async Task<IEnumerable<PlayerResponseDto>> ListAllAsync()
        {
            var result = await _playerRepository.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<PlayerResponseDto>>(result);
            return dto;
        }
        public async Task<PlayerResponseDto> AddAsync(PlayerRequestDto playerRequestDto)
        {
            var playerEntity = _mapper.Map<Player>(playerRequestDto);
            await _playerRepository.AddAsync(playerEntity);
            return await GetByIdAsync(playerEntity.Id);
        }
        public async Task<PlayerResponseDto> UpdateAsync(PlayerRequestDto playerRequestDto)
        {
            //var updatePlayerEntity = _mapper.Map<Player>(playerRequestDto);
            var comparingPlayerEntity = await _playerRepository.GetByIdAsync(playerRequestDto.Id);

            comparingPlayerEntity.Name = playerRequestDto.Name == null ? comparingPlayerEntity.Name : playerRequestDto.Name;    // Not really necessary to check on null
            comparingPlayerEntity.Dob = playerRequestDto.Dob == null ? comparingPlayerEntity.Dob : playerRequestDto.Dob;        // Not really necessary to check on null
            comparingPlayerEntity.SecurityStamp = Guid.NewGuid().ToString("N");
            if (!string.IsNullOrWhiteSpace(playerRequestDto.Email))
            {
                comparingPlayerEntity.Email = playerRequestDto.Email;
                comparingPlayerEntity.NormalizedEmail = playerRequestDto.Email.ToUpper();
            }
            if (!string.IsNullOrWhiteSpace(playerRequestDto.Password))
            {
                var passwordHasher = new PasswordHasher<Player>();
                comparingPlayerEntity.PasswordHash = passwordHasher.HashPassword(comparingPlayerEntity, playerRequestDto.Password);
            }
            await _playerRepository.UpdateAsync(comparingPlayerEntity);
            return await GetByIdAsync(comparingPlayerEntity.Id);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _playerRepository.DeleteAsync(id);
        }
        public async Task<IEnumerable<PlayerResponseDto>> SearchByNameAsycn(string name)
        {
            var result = await _playerRepository.SearchByNameAsync(name);
            var dto = _mapper.Map<IEnumerable<PlayerResponseDto>>(result);
            return dto;
        }
        public async Task<IdentityResult> AddRegisteredPlayerAsync(RegisterPlayerRequestDto registerPlayerRequestDto)
        {
            var playerEntity = _mapper.Map<Player>(registerPlayerRequestDto);
            var result = await _playerRepository.AddRegisteredPlayerAsync(playerEntity, registerPlayerRequestDto.Password);
            return result;
        }
        public async Task<PlayerResponseDto> UpdateAsync(Guid guid, bool isActive)
        {
            var updatePlayerEntity = await _playerRepository.GetByIdESOAsync(guid);
            updatePlayerEntity.SecurityStamp = Guid.NewGuid().ToString("N");
            updatePlayerEntity.IsDeleted = isActive;
            await _playerRepository.UpdateAsync(updatePlayerEntity);
            return await GetByIdAsync(updatePlayerEntity.Id);
        }
        public async Task<IEnumerable<RoleResponseDto>> GetRolesByPlayerId(Guid guid)
        {
            var entity = await _playerRepository.GetByIdAsync(guid);
            var roles = await _playerRepository.GetRolesByPlayer(entity);
            var result = new List<ApplicationRole>();
            foreach (var role in roles)
            {
                var applicationRole = new ApplicationRole { Name = role, NormalizedName = role.ToUpper() };
                result.Add(applicationRole);
            }
            var dto = _mapper.Map<IEnumerable<RoleResponseDto>>(result);
            return dto;
        }
        public async Task<IdentityResult> DeletePlayerFromRoles(Guid playerId)
        {
            var playerEntity = await _playerRepository.GetByIdAsync(playerId);
            var roles = await _playerRepository.GetRolesByPlayer(playerEntity);
            return await _playerRepository.DeletePlayerFromRoles(playerEntity, roles);
        }
        public async Task<IdentityResult> AddPlayerToRole(Guid playerId, Guid roleId)
        {
            var playerEntity = await _playerRepository.GetByIdAsync(playerId);
            var role = await _roleManager.FindByIdAsync(roleId.ToString());
            return await _playerRepository.AddPlayerToRole(playerEntity, role);
        }
    }
}
