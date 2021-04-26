using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class ArtistRepository : EfRepository<Artist> , IArtistRepository
    {
        public ArtistRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<Artist> GetAllAsync()
        {
            return _dbContext.Artists.AsNoTracking().Include(a => a.Artwork)
                .ThenInclude(art => art.BoardGame);
        }
        public override async Task<Artist> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(a => a.Id.Equals(id));
        }
        public async Task<IEnumerable<Artist>> SearchByNameAsync(string name)
        {
            return await GetAllAsync().Where(b => b.Name.ToUpper()
                .Contains(name.ToUpper())).ToListAsync();
        }
        public async Task<IEnumerable<Artist>> TopArtistWithMostArtworkAsync (int totalItems)
        {
            return await GetAllAsync().OrderByDescending(a => a.Artwork.Count()).Take(totalItems).ToListAsync();
        }
    }
}
