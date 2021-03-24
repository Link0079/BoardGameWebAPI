using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Games
{
    public class GameScoreRequestDto
    {
        public Guid PlayerId { get; set; }
        public int Score { get; set; }
    }
}
