using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class PublisherRepository : EfRepository<Publisher>
    {
        public PublisherRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<Publisher> GetAllAsync()
        {
            return _dbContext.Publishers.AsNoTracking().Include(p => p.Country)
                .Include(p => p.PublishedBoardGames);
        }
        public override async Task<Publisher> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(pub => pub.Id.Equals(id));
        }
    }
}
