using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories.Games
{
    public interface IBoardGameRepository : IRepository<BoardGame>
    {
        Task<IEnumerable<BoardGame>> GetByCategoryIdAsync(Guid id);
        Task<IEnumerable<BoardGame>> GetByArtistIdAsync(Guid id);
    }
}
