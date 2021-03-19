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
    public class BoardGameService : IBoardGameService
    {
        private readonly IBoardGameRepository _boardGameRepository;
        private readonly IMapper _mapper;
        public BoardGameService(IBoardGameRepository boardGameRepository, IMapper mapper)
        {
            _boardGameRepository = boardGameRepository;
            _mapper = mapper;
        }
        public async Task<BoardGameResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _boardGameRepository.GetByIdAsync(id);
            var dto = _mapper.Map<BoardGameResponseDto>(result);
            return dto;
        }
        public async Task<IEnumerable<BoardGameResponseDto>> ListAllAsync()
        {
            var result = await _boardGameRepository.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<BoardGameResponseDto>>(result);
            return dto;
        }
        public async Task<IEnumerable<BoardGameResponseDto>> GetByCategoryIdAsync(Guid id)
        {
            var result = await _boardGameRepository.GetByCategoryIdAsync(id);
            var dto = _mapper.Map<IEnumerable<BoardGameResponseDto>>(result);
            return dto;
        }
    }
}
