using Imi.Project.Api.Core.Entities.Games;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories
{
    public interface IBoardGameRepository : IRepository<BoardGame>
    {
        Task<IEnumerable<BoardGame>> GetByCategoryIdAsync(Guid id);
        Task<IEnumerable<BoardGame>> GetByArtistIdAsync(Guid id);
    }
}
