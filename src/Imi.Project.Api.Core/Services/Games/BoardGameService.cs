using AutoMapper;
using Imi.Project.Api.Core.Dtos.Games;
using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Repositories.Games;
using Imi.Project.Api.Core.Interfaces.Services.Games;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services.Games
{
    public class BoardGameService : IBoardGameService
    {
        private readonly IBoardGameCategoryRepository _bcRepository;
        private readonly IBoardGameRepository _boardGameRepository;
        private readonly IBoardGameArtistRepository _baRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IArtistRepository _artistRepository;
        private readonly IMapper _mapper;
        public BoardGameService(IBoardGameRepository boardGameRepository, IMapper mapper,
            IBoardGameArtistRepository baRepository, IBoardGameCategoryRepository bcRepository,
            IArtistRepository artistReposistory, ICategoryRepository categoryRepository)
        {
            _boardGameRepository = boardGameRepository;
            _categoryRepository = categoryRepository;
            _artistRepository = artistReposistory;
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
            #region Old logic for making Boardgames
            //var boardGameEntity = _mapper.Map<BoardGame>(boardGameRequestDto);                      // map current Dto to Entity.. 'No way Sherlock'
            //Expression<Func<BoardGameCategory, bool>> bcExpression = bc => bc.BoardGameId == boardGameEntity.Id;    // Prepare expression for CurrentBoardGameCategoryList
            //Expression<Func<BoardGameArtist, bool>> baExpression = ba => ba.BoardGameId == boardGameEntity.Id;      // Prepare expression for CurrentBoardGameArtistList
            //var currentBCList = _bcRepository.GetFiltered(bcExpression);                            // Make new List and fill up by BoardGameCategoryExpression
            //var currentBAList = _baRepository.GetFiltered(baExpression);                            // Make new list and fill up by BoardGameArtistExpression
            //await _bcRepository.DeleteAsync(currentBCList);                                         // Drastic but necessary.. Delete CurrentBCList. 
            //await _baRepository.DeleteAsync(currentBAList);                                         // Drastic but necessary.. Delete CurrentBAList.
            //boardGameEntity = HandleCompositeTablesForUpdate(boardGameEntity, boardGameRequestDto); // This will add the new records to the Composite Tables that were just deleted.
            //await _boardGameRepository.UpdateAsync(boardGameEntity);
            //return await GetByIdAsync(boardGameEntity.Id); 
            #endregion

            var boardGameEntity = _mapper.Map<BoardGame>(boardGameRequestDto);
            await _boardGameRepository.UpdateAsync(boardGameEntity);
            return await GetByIdAsync(boardGameEntity.Id);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _boardGameRepository.DeleteAsync(id);
        }
        public async Task<BoardGameResponseDto> UpdateAsync(Guid guid, bool isActive)
        {
            var updateBoardGameEntity = await _boardGameRepository.GetByIdAsync(guid);
            updateBoardGameEntity.IsDeleted = isActive;
            await _boardGameRepository.UpdateAsync(updateBoardGameEntity);
            return await GetByIdAsync(updateBoardGameEntity.Id);
        }
        public async Task<bool> AddCategoryToBoardGame(Guid boardGameId, Guid categoryId)
        {
            var result = false;
            var boardGameExists = await _boardGameRepository.EntityExists(boardGameId);
            var categoryExists = await _categoryRepository.EntityExists(categoryId);
            if (boardGameExists && categoryExists)
            {
                var boardGameEntity = await _boardGameRepository.GetByIdAsync(boardGameId);
                var categoryEntity = await _categoryRepository.GetByIdAsync(categoryId);
                var bcEntityList = new List<BoardGameCategory>{ new BoardGameCategory { BoardGameId = boardGameEntity.Id, CategoryId = categoryEntity.Id } };
                result = await _bcRepository.AddAsync(bcEntityList);
            }
            return result;
        }
        public async Task<bool> AddArtistToBoardGame(Guid boardGameId, Guid artistId)
        {
            var result = false;
            var boardGameExists = await _boardGameRepository.EntityExists(boardGameId);
            var artistExists = await _artistRepository.EntityExists(artistId);
            if (boardGameExists && artistExists)
            {
                var boardGameEntity = await _boardGameRepository.GetByIdAsync(boardGameId);
                var artistEntity = await _artistRepository.GetByIdAsync(artistId);
                var baEntityList = new List<BoardGameArtist>{ new BoardGameArtist { BoardGameId = boardGameEntity.Id, ArtistId = artistEntity.Id } };
                result = await _baRepository.AddAsync(baEntityList);
            }
            return result;
        }
        public async Task<bool> DeleteCategoryFromBoardGame(Guid boardGameId, Guid categoryId)
        {
            var result = false;
            var boardGameExists = await _boardGameRepository.EntityExists(boardGameId);
            var categoryExists = await _categoryRepository.EntityExists(categoryId);
            if (boardGameExists && categoryExists)
            {
                //var boardGameEntity = await _boardGameRepository.GetByIdAsync(boardGameId);
                //var categoryEntity = await _categoryRepository.GetByIdAsync(categoryId);
                var bcEntityList = new List<BoardGameCategory> { new BoardGameCategory { BoardGameId = boardGameId, CategoryId = categoryId } };
                result = await _bcRepository.DeleteAsync(bcEntityList);
            }
            return result;
        }
        public async Task<bool> DeleteArtistFromBoardGame(Guid boardGameId, Guid artistId)
        {
            var result = false;
            var boardGameExists = await _boardGameRepository.EntityExists(boardGameId);
            var artistExists = await _artistRepository.EntityExists(artistId);
            if (boardGameExists && artistExists)
            {
                //var boardGameEntity = await _boardGameRepository.GetByIdAsync(boardGameId);
                //var artistEntity = await _artistRepository.GetByIdAsync(artistId);
                var baEntityList = new List<BoardGameArtist> { new BoardGameArtist { BoardGameId = boardGameId, ArtistId = artistId } };
                result = await _baRepository.DeleteAsync(baEntityList);
            }
            return result;
        }
        public async Task<IEnumerable<BoardGameResponseDto>> SearchByNameAsycn(string title)
        {
            var result = await _boardGameRepository.SearchByNameAsync(title);
            var dto = _mapper.Map<IEnumerable<BoardGameResponseDto>>(result);
            return dto;
        }

        #region Old logic for making Boardgames
        //private BoardGame HandleCompositeTablesForUpdate(BoardGame boardGameEntity, BoardGameRequestDto boardGameRequestDto)
        //{
        //    if (boardGameRequestDto.Artists != null)                        // Check if Dto inner list is null
        //    {
        //        boardGameEntity.Artists = new List<BoardGameArtist>();      // Make new list in Entity
        //        foreach (var artist in boardGameRequestDto.Artists)         // Loop through the Dto inner list
        //            boardGameEntity.Artists.Add(new BoardGameArtist         // Add the item to the Entity list
        //            {                                                       // Using ID's of the Entities cuz if I used the entity
        //                ArtistId = artist.ArtistId,                         // it was trying to create a new Artist.. 
        //                BoardGameId = boardGameEntity.Id                    // which gave an exception for obviouse reasons.. ¯\_(ツ)_/¯
        //            });
        //        _baRepository.AddAsync(boardGameEntity.Artists);            // Add the list to the Composite Table..
        //    }
        //    if (boardGameRequestDto.Categories != null)                     // Check if Dto inner list is null
        //    {
        //        boardGameEntity.Categories = new List<BoardGameCategory>(); // Same shizzle as Artist
        //        foreach (var category in boardGameRequestDto.Categories) 
        //            boardGameEntity.Categories.Add(new BoardGameCategory
        //            {
        //                CategoryId = category.CategoryId,
        //                BoardGameId = boardGameEntity.Id
        //            });
        //        _bcRepository.AddAsync(boardGameEntity.Categories);         // Add the list to the Composite Table
        //    }
        //    return boardGameEntity;
        //}
        #endregion

    }
}
