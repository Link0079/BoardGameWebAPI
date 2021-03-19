using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class PlayedGameResponseDto : BaseDto
    {
        public string BoardGameTitle { get; set; }
        public string PlayTime { get; set; }
        public int PlayerCount { get; set; }
        public IEnumerable<GameScoreResponseDto> GameScores { get; set; }
    }
}
