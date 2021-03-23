using Imi.Project.Api.Core.Entities.Games;
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
    public class PlayedGameRepository : EfRepository<PlayedGame>, IPlayedGameRepository
    {
        public PlayedGameRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<PlayedGame> GetAllAsync()
        {
            return _dbContext.PlayedGames.AsNoTracking().Include(p => p.GameScores)
                .ThenInclude(gs => gs.Player).Include(p=>p.BoardGame);
        }
        public override async Task<PlayedGame> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(p => p.Id.Equals(id));
        }
        public async Task<IEnumerable<PlayedGame>> GetByPlayerIdAsync(Guid id)
        {
            return await GetAllAsync().Where(pg => pg.GameScores
                .Any(gs => gs.PlayerId.Equals(id))).ToListAsync();
        }
    }
}
