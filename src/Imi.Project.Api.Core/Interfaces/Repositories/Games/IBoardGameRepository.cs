using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories.Games
{
    public interface IBoardGameRepository : IRepository<BoardGame>
    {
        IQueryable<BoardGame> GetESOAsync();
        Task<IEnumerable<BoardGame>> GetByCategoryIdAsync(Guid id);
        Task<IEnumerable<BoardGame>> GetByArtistIdAsync(Guid id);
        Task<IEnumerable<BoardGame>> SearchByNameAsync(string title);
        Task<IEnumerable<BoardGame>> GetTopBoardGameWithLongestPlayTime(int totalItems);
        Task<IEnumerable<BoardGame>> GetTopBoardGameWithHighestRating(int totalItems);
        Task<long> GetTotalBoardGamePlayTime();
    }
}
