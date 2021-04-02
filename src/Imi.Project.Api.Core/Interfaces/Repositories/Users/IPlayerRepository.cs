using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories.Users
{
    public interface IPlayerRepository : IRepository<Player>
    {
        Task<IEnumerable<Player>> SearchByNameAsync(string name);
        IQueryable<Player> GetESOAsync(); // Get"EverySingleOne"Async
        Task<IEnumerable<Player>> GetTopPlayerWithLongestTotalPlaytime(int totalItems);
        Task<IEnumerable<Player>> TopPlayerWithMostPlayedGames(int totalItems);
        Task<IEnumerable<Player>> TopFirstPlayers(int totalItems);
    }
}
