using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class BoardGameCategoryRepository : EfCompositeRepository<BoardGameCategory>, IBoardGameCategoryRepository
    {
        public BoardGameCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
        public override async Task<BoardGameCategory> AddAsync(IEnumerable<BoardGameCategory> entityList)
        {
            foreach (var item in entityList)
                await _dbContext.BoardGameCategories.AddAsync(item);
            //await _dbContext.SaveChangesAsync();
            return null;
        }
    }
}
