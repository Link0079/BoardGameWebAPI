using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Users
{
    public class PlayerResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string Dob { get; set; }
        public string Email { get; set; }
        public int? PlayedGameCount { get; set; }
        public string PlayTimeTotal { get; set; }
        public string MostPlayedGame { get; set; }
    }
}
