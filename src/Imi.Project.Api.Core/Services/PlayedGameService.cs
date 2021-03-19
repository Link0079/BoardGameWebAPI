using AutoMapper;
using Imi.Project.Api.Core.Dtos;
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
    }
}
