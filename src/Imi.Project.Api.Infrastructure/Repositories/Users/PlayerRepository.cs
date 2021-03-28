using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Interfaces.Repositories.Users;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories.Users
{
    public class PlayerRepository : EfRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<Player> GetAllAsync()
        {
            return _dbContext.Players.AsNoTracking().Include(p => p.GameScores)
                .ThenInclude(gs => gs.PlayedGame).ThenInclude(pg=>pg.BoardGame)
                .Where(p=>p.IsDeleted == false);
        }
        public IQueryable<Player> GetESOAsync() // Get Every Single One 
        {
            return _dbContext.Players.AsNoTracking().Include(p => p.GameScores)
                .ThenInclude(gs => gs.PlayedGame).ThenInclude(pg => pg.BoardGame);
        }
        public override async Task<Player> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(p => p.Id.Equals(id));
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
    }
}
