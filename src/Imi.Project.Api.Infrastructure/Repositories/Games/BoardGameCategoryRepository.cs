using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories.Games;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Infrastructure.Repositories.Games
{
    public class BoardGameCategoryRepository : EfCompositeRepository<BoardGameCategory>, IBoardGameCategoryRepository
    {
        public BoardGameCategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
