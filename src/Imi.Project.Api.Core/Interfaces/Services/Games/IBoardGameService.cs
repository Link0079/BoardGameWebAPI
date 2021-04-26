using Imi.Project.Api.Core.Dtos.Games;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.Games
{
    public interface IBoardGameService
    {
        Task<IEnumerable<BoardGameResponseDto>> ListAllAsync();
        Task<BoardGameResponseDto> GetByIdAsync(Guid id);
        Task<IEnumerable<BoardGameResponseDto>> GetByCategoryIdAsync(Guid id);
        Task<IEnumerable<BoardGameResponseDto>> GetByArtistIdAsync(Guid id);
        Task<IEnumerable<BoardGameResponseDto>> SearchByNameAsycn(string title);
        Task<BoardGameResponseDto> AddAsync(BoardGameRequestDto boardGameRequestDto);
        Task<BoardGameResponseDto> UpdateAsync(BoardGameRequestDto boardGameRequestDto);
        Task DeleteAsync(Guid id);

    }
}
