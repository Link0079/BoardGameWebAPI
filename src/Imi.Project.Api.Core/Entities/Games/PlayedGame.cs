using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities.Games
{
    public class PlayedGame : BaseEntity<Guid>
    {
        public Guid BoardGameId { get; set; }
        public int PlayTime { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<GameScore> GameScores { get; set; }
        // NaviProperties
        public BoardGame BoardGame { get; set; }
    }
}
