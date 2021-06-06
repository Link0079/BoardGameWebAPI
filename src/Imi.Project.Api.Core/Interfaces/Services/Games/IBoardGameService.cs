using Imi.Project.Api.Core.Dtos.Games;
using Imi.Project.Api.Core.Interfaces.Services.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.Games
{
    public interface IBoardGameService : IBaseService<BoardGameResponseDto, BoardGameRequestDto>
    {
        //Task<IEnumerable<BoardGameResponseDto>> ListAllAsync();
        //Task<BoardGameResponseDto> GetByIdAsync(Guid id);
        //Task<BoardGameResponseDto> AddAsync(BoardGameRequestDto boardGameRequestDto);
        //Task<BoardGameResponseDto> UpdateAsync(BoardGameRequestDto boardGameRequestDto);
        //Task DeleteAsync(Guid id);
        Task<IEnumerable<BoardGameResponseDto>> GetByArtistIdAsync(Guid id);
        Task<IEnumerable<BoardGameResponseDto>> SearchByNameAsycn(string title);
        Task<IEnumerable<BoardGameResponseDto>> GetByCategoryIdAsync(Guid id);
        Task<BoardGameResponseDto> UpdateAsync(Guid guid, bool isActive);
        Task<bool> AddCategoryToBoardGame(Guid boardGameId, Guid categoryId);
        Task<bool> AddArtistToBoardGame(Guid boardGameId, Guid artistId);
        Task<bool> DeleteCategoryFromBoardGame(Guid boardGameId, Guid categoryId);
        Task<bool> DeleteArtistFromBoardGame(Guid boardGameId, Guid artistId);

    }
}
