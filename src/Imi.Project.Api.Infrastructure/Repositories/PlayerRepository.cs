using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class PlayerRepository : EfRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<Player> GetAllAsync()
        {
            return _dbContext.Players.AsNoTracking().Include(p => p.GameScores)
                .ThenInclude(gs => gs.PlayedGame).ThenInclude(pg=>pg.BoardGame);
        }
        public override async Task<Player> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(p => p.Id.Equals(id));
        }
    }
}
