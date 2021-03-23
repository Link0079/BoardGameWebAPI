﻿using AutoMapper;
using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _playerRepository;
        private readonly IMapper _mapper;
        public PlayerService(IPlayerRepository playerRepository, IMapper mapper)
        {
            _playerRepository = playerRepository;
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
            var playerEntity = _mapper.Map<Player>(playerRequestDto);
            await _playerRepository.UpdateAsync(playerEntity);
            return await GetByIdAsync(playerEntity.Id);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _playerRepository.DeleteAsync(id);
        }
    }
}
