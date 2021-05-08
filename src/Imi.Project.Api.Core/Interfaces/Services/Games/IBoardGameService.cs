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

    }
}
