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
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = CustomExceptionMessages.RequierdPlayerDob)]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(100, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = CustomExceptionMessages.RequiredPlayerConfirmPassword)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        //public bool IsDeleted { get; set; }
    }
}
