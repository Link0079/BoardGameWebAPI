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
        private readonly IBoardGameCategoryRepository _bcRepository;
        private readonly IBoardGameRepository _boardGameRepository;
        private readonly IBoardGameArtistRepository _baRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IArtistRepository _artistRepository;
        private readonly IMapper _mapper;
        public BoardGameService(IBoardGameRepository boardGameRepository, ICategoryRepository categoryRepository, IMapper mapper,
            IArtistRepository artistRepository, IBoardGameArtistRepository baRepository, IBoardGameCategoryRepository bcRepository )
        {
            _boardGameRepository = boardGameRepository;
            _categoryRepository = categoryRepository;
            _artistRepository = artistRepository;
            _bcRepository = bcRepository;
            _baRepository = baRepository;
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
            var boardGameEntity = _mapper.Map<BoardGame>(boardGameRequestDto);                  // map current Dto to Entity.. 'No way Sherlock'
            if (boardGameRequestDto.Categories != null)                                         // Check if Dto inner list is null
            {
                boardGameEntity.Categories = new List<BoardGameCategory>();                     // make new list in Entity
                foreach (var category in boardGameRequestDto.Categories)                        // Loop through the Dto inner list
                    boardGameEntity.Categories.Add(new BoardGameCategory                        // Add the item to the Entity list
                    {                                                                           // Using ID's of the Entities cuz the Entity that needs to be linked
                        CategoryId = category.CategoryId, BoardGameId = boardGameEntity.Id      // must already exist. (You might be selecting them from a list)
                    });                                                                         // Otherwise you'll be making a new item in db which will not work cuz of constrains on Name
                await _bcRepository.AddAsync(boardGameEntity.Categories);                       // Add the list to the composite table 
            }
            if (boardGameRequestDto.Artists != null)                                            // Same logic as Categories list
            {
                boardGameEntity.Artists = new List<BoardGameArtist>();
                foreach (var artist in boardGameRequestDto.Artists)
                    boardGameEntity.Artists.Add(new BoardGameArtist
                    {
                        ArtistId = artist.ArtistId, BoardGameId = boardGameEntity.Id
                    });
                await _baRepository.AddAsync(boardGameEntity.Artists);
            }
            await _boardGameRepository.UpdateAsync(boardGameEntity);                            // Had to use logic from above cuz update doesn't handle with the composite tables
            return await GetByIdAsync(boardGameEntity.Id);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _boardGameRepository.DeleteAsync(id);
        }
    }
}
