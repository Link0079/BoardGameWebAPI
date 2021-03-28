using Imi.Project.Api.Core.Entities.Games;
using Imi.Project.Api.Core.Interfaces.Repositories.Games;
using Imi.Project.Api.Infrastructure.Data;
using Imi.Project.Api.Infrastructure.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Infrastructure.Repositories.Games
{
    public class GameScoreRepository : EfCompositeRepository<GameScore>, IGameScoreRepository
    {
        public GameScoreRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}
