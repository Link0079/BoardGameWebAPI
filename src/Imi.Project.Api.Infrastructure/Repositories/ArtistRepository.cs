using Imi.Project.Api.Core.Entities.Users;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class ArtistRepository : EfRepository<Artist>
    {
        public ArtistRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<Artist> GetAllAsync()
        {
            return _dbContext.Artists.AsNoTracking().Include(a => a.Artwork)
                .ThenInclude(art => art.BoardGame).Include(a => a.Country);
        }
        public override async Task<Artist> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(a => a.Id.Equals(id));
        }
    }
}
