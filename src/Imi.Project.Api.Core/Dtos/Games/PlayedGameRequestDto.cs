using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Games
{
    public class PlayedGameRequestDto : BaseDto
    {
        public int PlayTime { get; set; }
        public Guid BoardGameId { get; set; }
        public IEnumerable<GameScoreRequestDto> GameScores { get; set; }

        //public bool IsDeleted { get; set; }
    }
}
