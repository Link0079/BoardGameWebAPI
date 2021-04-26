using Imi.Project.Api.Core.Dtos.Base;
using Imi.Project.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Users
{
    public class PlayerRequestDto : BaseDto
    {
        [Required(ErrorMessage = CustomExceptionMessages.RequiredPlayerName)]
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        //public bool IsDeleted { get; set; }
    }
}
