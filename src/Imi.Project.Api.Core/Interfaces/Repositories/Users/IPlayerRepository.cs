using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Interfaces.Repositories.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Repositories.Users
{
    public interface IPlayerRepository : IUserRepository<Player>
    {
        Task<IEnumerable<Player>> SearchByNameAsync(string name);
        IQueryable<Player> GetESOAsync(); // Get"EverySingleOne"Async
        Task<Player> GetByIdESOAsync(Guid id);
        Task<IEnumerable<Player>> GetTopPlayerWithLongestTotalPlaytimeAsync(int totalItems);
        Task<IEnumerable<Player>> TopPlayerWithMostPlayedGamesAsync(int totalItems);
        Task<IEnumerable<Player>> TopFirstPlayersAsync(int totalItems);
        Task<IdentityResult> AddRegisteredPlayerAsync(Player entity, string password);
        Task<IEnumerable<string>> GetRolesByPlayer(Player entity);
        Task<IEnumerable<Player>> GetPlayersByRole(ApplicationRole role);
        Task<IdentityResult> DeletePlayerFromRoles(Player entity, IEnumerable<string> roles);
        Task<IdentityResult> AddPlayerToRole(Player entity, ApplicationRole role);
    }
}
