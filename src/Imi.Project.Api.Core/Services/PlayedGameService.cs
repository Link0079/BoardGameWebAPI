using AutoMapper;
using Imi.Project.Api.Core.Dtos.Games;
using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class PlayedGameService : IPlayedGameService
    {
        private readonly IPlayedGameRepository _playedGameRepository;
        private readonly IMapper _mapper;
        public PlayedGameService(IPlayedGameRepository playedGameRepository, IMapper mapper)
        {
            _playedGameRepository = playedGameRepository;
            _mapper = mapper;
        }
        public async Task<PlayedGameResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _playedGameRepository.GetByIdAsync(id);
            var dto = _mapper.Map<PlayedGameResponseDto>(result);
            return dto;
        }
        public async Task<IEnumerable<PlayedGameResponseDto>> ListAllAsync()
        {
            var result = await _playedGameRepository.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<PlayedGameResponseDto>>(result);
            return dto;
        }
        public async Task<PlayedGameResponseDto> AddAsync(PlayedGameRequestDto playedGameRequestDto)
        {
            var playedGameEntity = _mapper.Map<PlayedGame>(playedGameRequestDto);
            await _playedGameRepository.AddAsync(playedGameEntity);
            return await GetByIdAsync(playedGameEntity.Id);
        }
        public async Task<PlayedGameResponseDto> UpdateAsync(PlayedGameRequestDto playedGameRequestDto)
        {
            var playedGameEntity = _mapper.Map<PlayedGame>(playedGameRequestDto);
            await _playedGameRepository.UpdateAsync(playedGameEntity);
            return await GetByIdAsync(playedGameEntity.Id);
        }
        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
