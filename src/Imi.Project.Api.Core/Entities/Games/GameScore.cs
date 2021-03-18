using Imi.Project.Api.Core.Entities.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities.Games
{
    public class GameScore
    {
        public Guid PlayerId { get; set; }
        public Guid PlayedGameId { get; set; }
        public int Score { get; set; }
        public bool IsDeleted { get; set; }
        // NaviProperties
        public Player Player { get; set; }
        public PlayedGame PlayedGame { get; set; }
    }
}
