using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories
{
    public class BoardGameCategoryRepository : EfCompositeRepository<BoardGameCategory>, IBoardGameCategoryRepository
    {
        public BoardGameCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
