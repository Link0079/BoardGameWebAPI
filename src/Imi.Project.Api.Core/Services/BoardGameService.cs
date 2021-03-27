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
    public class BoardGameService : IBoardGameService
    {
        private readonly IBoardGameRepository _boardGameRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IArtistRepository _artistRepository;
        private readonly IMapper _mapper;
        public BoardGameService(IBoardGameRepository boardGameRepository, ICategoryRepository categoryRepository,
            IArtistRepository artistRepository, IMapper mapper)
        {
            _boardGameRepository = boardGameRepository;
            _categoryRepository = categoryRepository;
            _artistRepository = artistRepository;
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
        public async Task<IEnumerable<BoardGameResponseDto>> GetByArtistIdAsync(Guid id)
        {
            var result = await _boardGameRepository.GetByArtistIdAsync(id);
            var dto = _mapper.Map<IEnumerable<BoardGameResponseDto>>(result);
            return dto;
        }
        public async Task<BoardGameResponseDto> AddAsync(BoardGameRequestDto boardGameRequestDto)
        {
            var boardGameEntity = _mapper.Map<BoardGame>(boardGameRequestDto);
            await _boardGameRepository.AddAsync(boardGameEntity);
            return await GetByIdAsync(boardGameEntity.Id);
        }
        public async Task<BoardGameResponseDto> UpdateAsync(BoardGameRequestDto boardGameRequestDto)
        {
            var boardGameEntity = _mapper.Map<BoardGame>(boardGameRequestDto);
            if (boardGameRequestDto.Categories != null)
                boardGameEntity.Categories = new List<BoardGameCategory>();
                foreach (var category in boardGameRequestDto.Categories)
                    boardGameEntity.Categories.Add(new BoardGameCategory
                    {
                        Category = await _categoryRepository.GetByIdAsync(category.CategoryId)
                    });
            if (boardGameRequestDto.Artists != null)
                boardGameEntity.Artists = new List<BoardGameArtist>();
                foreach (var artist in boardGameRequestDto.Artists)
                    boardGameEntity.Artists.Add(new BoardGameArtist
                    {
                        Artist = await _artistRepository.GetByIdAsync(artist.ArtistId)
                    });
            await _boardGameRepository.UpdateAsync(boardGameEntity);
            return await GetByIdAsync(boardGameEntity.Id);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _boardGameRepository.DeleteAsync(id);
        }
    }
}
