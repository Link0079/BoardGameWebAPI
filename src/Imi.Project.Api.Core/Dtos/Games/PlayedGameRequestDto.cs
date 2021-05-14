using Imi.Project.Api.Core.Dtos.Base;
using Imi.Project.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Games
{
    public class PlayedGameRequestDto : BaseDto
    {
        public int PlayTime { get; set; }
        [Required(ErrorMessage = CustomExceptionMessages.RequiredPlayedGameBoardGameId)]
        public Guid BoardGameId { get; set; }
        public IEnumerable<GameScoreRequestDto> GameScores { get; set; }

        //public bool IsDeleted { get; set; }
    }
}
