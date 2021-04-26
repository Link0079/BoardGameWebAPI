using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories.Games
{
    public interface IPlayedGameRepository : IRepository<PlayedGame>
    {
        Task<IEnumerable<PlayedGame>> GetByPlayerIdAsync(Guid id);
    }
}
