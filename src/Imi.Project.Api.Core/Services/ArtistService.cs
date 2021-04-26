using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _artistRepository;
        private readonly IMapper _mapper;
        public ArtistService(IArtistRepository artistRepository, IMapper mapper)
        {
            _artistRepository = artistRepository;
            _mapper = mapper;
        }
        public async Task<ArtistResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _artistRepository.GetByIdAsync(id);
            var dto = _mapper.Map<ArtistResponseDto>(result);
            return dto;
        }
        public async Task<IEnumerable<ArtistResponseDto>> ListAllAsync()
        {
            var result = await _artistRepository.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<ArtistResponseDto>>(result);
            return dto;
        }
        public async Task<ArtistResponseDto> AddAsync(ArtistRequestDto artistRequestDto)
        {
            var artistEntity = _mapper.Map<Artist>(artistRequestDto);
            await _artistRepository.AddAsync(artistEntity);
            return await GetByIdAsync(artistEntity.Id);
        }
        public async Task<ArtistResponseDto> UpdateAsync(ArtistRequestDto artistRequestDto)
        {
            var artistEntity = _mapper.Map<Artist>(artistRequestDto);
            await _artistRepository.UpdateAsync(artistEntity);
            return await GetByIdAsync(artistEntity.Id);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _artistRepository.DeleteAsync(id);
        }
        public async Task<IEnumerable<ArtistResponseDto>> SearchByNameAsycn(string name)
        {
            var result = await _artistRepository.SearchByNameAsync(name);
            var dto = _mapper.Map<IEnumerable<ArtistResponseDto>>(result);
            return dto;
        }

    }
}
