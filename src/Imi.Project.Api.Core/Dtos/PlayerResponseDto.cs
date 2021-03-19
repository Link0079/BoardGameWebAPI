using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos
{
    public class PlayerResponseDto : BaseDto
    {
        public string Name { get; set; }
        public int PlayedGameCount { get; set; }
        public string PlayTimeTotal { get; set; }
        public string FavoPlayedGame { get; set; }
    }
}
