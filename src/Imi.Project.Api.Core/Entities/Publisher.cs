using System.Collections.Generic;
using Imi.Project.Api.Core.Entities.Base;
using Imi.Project.Api.Core.Entities.Games;

namespace Imi.Project.Api.Core.Entities
{
    public class Publisher : User
    {
        public ICollection<BoardGame> PublishedBoardGames { get; set; }
    }
}
