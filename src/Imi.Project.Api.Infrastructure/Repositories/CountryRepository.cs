using Imi.Project.Api.Core.Entities;
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
    public class CountryRepository : EfRepository<Country>
    {
        public CountryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override IQueryable<Country> GetAllAsync()
        {
            return null; // _dbContext.Countries.AsNoTracking();
        }
        public override async Task<Country> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(c => c.Id.Equals(id));
        }
    }
}
