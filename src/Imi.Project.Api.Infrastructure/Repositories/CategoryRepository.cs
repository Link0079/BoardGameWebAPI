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
    public class CategoryRepository : EfRepository<Category>
    {
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override async Task<Category> GetByIdAsync(Guid id)
        {
            return await GetAllAsync().SingleOrDefaultAsync(cat => cat.Id.Equals(id));
        }
        public override IQueryable<Category> GetAllAsync()
        {
            return _dbContext.Categories.AsNoTracking();
        }
    }
}
