using AutoMapper;
using Imi.Project.Api.Core.Dtos.Games;
using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class BoardGameService : IBoardGameService
    {
        private readonly IBoardGameCategoryRepository _bcRepository;
        private readonly IBoardGameRepository _boardGameRepository;
        private readonly IBoardGameArtistRepository _baRepository;
        private readonly IMapper _mapper;
        public BoardGameService(IBoardGameRepository boardGameRepository, IMapper mapper,
            IBoardGameArtistRepository baRepository, IBoardGameCategoryRepository bcRepository )
        {
            _boardGameRepository = boardGameRepository;
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
            var boardGameEntity = _mapper.Map<BoardGame>(boardGameRequestDto);                      // map current Dto to Entity.. 'No way Sherlock'
            Expression<Func<BoardGameCategory, bool>> bcExpression = bc => bc.BoardGameId == boardGameEntity.Id;    // Prepare expression for CurrentBoardGameCategoryList
            Expression<Func<BoardGameArtist, bool>> baExpression = ba => ba.BoardGameId == boardGameEntity.Id;      // Prepare expression for CurrentBoardGameArtistList
            var currentBCList = _bcRepository.GetFiltered(bcExpression);                            // Make new List and fill up by BoardGameCategoryExpression
            var currentBAList = _baRepository.GetFiltered(baExpression);                            // Make new list and fill up by BoardGameArtistExpression
            await _bcRepository.DeleteAsync(currentBCList);                                         // Drastic but necessary.. Delete CurrentBCList. 
            await _baRepository.DeleteAsync(currentBAList);                                         // Drastic but necessary.. Delete CurrentBAList.
            boardGameEntity = HandleCompositeTablesForUpdate(boardGameEntity, boardGameRequestDto); // This will add the new records to the Composite Tables that were just deleted.
            await _boardGameRepository.UpdateAsync(boardGameEntity);
            return await GetByIdAsync(boardGameEntity.Id);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _boardGameRepository.DeleteAsync(id);
        }
        private BoardGame HandleCompositeTablesForUpdate(BoardGame boardGameEntity, BoardGameRequestDto boardGameRequestDto)
        {
            if (boardGameRequestDto.Artists != null)                        // Check if Dto inner list is null
            {
                boardGameEntity.Artists = new List<BoardGameArtist>();      // Make new list in Entity
                foreach (var artist in boardGameRequestDto.Artists)         // Loop through the Dto inner list
                    boardGameEntity.Artists.Add(new BoardGameArtist         // Add the item to the Entity list
                    {                                                       // Using ID's of the Entities cuz if I used the entity
                        ArtistId = artist.ArtistId,                         // it was trying to create a new Artist.. 
                        BoardGameId = boardGameEntity.Id                    // which gave an exception for obviouse reasons.. ¯\_(ツ)_/¯
                    });
                _baRepository.AddAsync(boardGameEntity.Artists);            // Add the list to the Composite Table..
            }
            if (boardGameRequestDto.Categories != null)                     // Check if Dto inner list is null
            {
                boardGameEntity.Categories = new List<BoardGameCategory>(); // Same shizzle as Artist
                foreach (var category in boardGameRequestDto.Categories) 
                    boardGameEntity.Categories.Add(new BoardGameCategory
                    {
                        CategoryId = category.CategoryId,
                        BoardGameId = boardGameEntity.Id
                    });
                _bcRepository.AddAsync(boardGameEntity.Categories);         // Add the list to the Composite Table
            }
            return boardGameEntity;
        }

    }
}
