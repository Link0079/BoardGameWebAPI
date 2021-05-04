using Imi.Project.Api.Core.Entities.Base;
using Imi.Project.Api.Core.Entities.Games;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Entities.Users
{
    public class Player : ApplicationUser
    {
        public ICollection<GameScore> GameScores { get; set; }
    }
}
