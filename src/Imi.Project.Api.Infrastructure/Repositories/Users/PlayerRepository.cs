using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Interfaces.Repositories.Users;
using Imi.Project.Api.Infrastructure.Repositories.Base;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories.Users
{
    public class PlayerRepository : EfUserRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(UserManager<Player> userManager) : base(userManager)
        {
        }
        public override IQueryable<Player> GetAllAsync()
        {
            return _userManager.Users.Include(p => p.GameScores)
                .ThenInclude(gs => gs.PlayedGame).ThenInclude(pg=>pg.BoardGame)
                .Where(p=>p.IsDeleted == false);
        }
        public IQueryable<Player> GetESOAsync() // Get Every Single One 
        {
            return _userManager.Users.Include(p => p.GameScores)
                .ThenInclude(gs => gs.PlayedGame).ThenInclude(pg => pg.BoardGame);
        }
        public override async Task<Player> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(p => p.Id.Equals(id));
        }
        public async Task<Player> GetByIdESOAsync(Guid id)
        {
            return await GetESOAsync().SingleOrDefaultAsync(p => p.Id.Equals(id));
        }
        public override async Task<Player> DeleteAsync(Player entity)
        {
            entity.IsDeleted = true;
            await UpdateAsync(entity);
            return entity;
        }
        public async Task<IEnumerable<Player>> SearchByNameAsync(string name)
        {
            return await GetAllAsync().Where(b => b.Name.ToUpper()
                .Contains(name.ToUpper())).ToListAsync();
        }
        public async Task<IEnumerable<Player>> GetTopPlayerWithLongestTotalPlaytimeAsync (int totalItems)
        {
            return await GetAllAsync().OrderByDescending(p => p.GameScores
                //.Where(gs=> gs.PlayerId == p.Id)
                .Sum(gs => gs.PlayedGame.PlayTime)).Take(totalItems).ToListAsync();
        }
        public async Task<IEnumerable<Player>> TopPlayerWithMostPlayedGamesAsync (int totalItems)
        {
            return await GetAllAsync().OrderByDescending(p => p.GameScores.Count()).Take(totalItems).ToListAsync();
        }
        public async Task<IEnumerable<Player>> TopFirstPlayersAsync (int totalItems)
        {
            return await GetAllAsync().OrderByDescending(p => p.GameScores.Where(gs=>gs.PlayerId == p.Id).Max(gs=>gs.Score)).Take(totalItems).ToListAsync();
        }
        public async Task<IdentityResult> AddRegisteredPlayerAsync(Player entity, string password)
        {
            var result = await _userManager.CreateAsync(entity, password);
            if (result.Succeeded)
            {
                var newPlayer = await _userManager.FindByEmailAsync(entity.Email);
                await _userManager.AddToRoleAsync(newPlayer, "Player");
                await _userManager.AddClaimAsync(newPlayer, new Claim("registration-date", DateTime.UtcNow.ToString("yyyy-MM-dd")));
                await _userManager.AddClaimAsync(newPlayer, new Claim("dob", entity.Dob.ToString("yyyy-MM-dd")));
                await _userManager.AddClaimAsync(newPlayer, new Claim("firstnamechar", entity.Name[0].ToString().ToUpper()));
            }
            return result;
        }
        public async Task<IEnumerable<string>> GetRolesByPlayer(Player entity)
        {
            return await _userManager.GetRolesAsync(entity);
        }
        public async Task<IdentityResult> DeletePlayerFromRoles(Player entity, IEnumerable<string> roles)
        {
            return await _userManager.RemoveFromRolesAsync(entity, roles);
        }
        public async Task<IdentityResult> AddPlayerToRole(Player entity, ApplicationRole role)
        {
            return await _userManager.AddToRoleAsync(entity, role.Name);
        }
    }
}
