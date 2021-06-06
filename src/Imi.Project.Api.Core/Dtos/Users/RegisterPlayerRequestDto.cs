using Imi.Project.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Users
{
    public class RegisterPlayerRequestDto
    {
        [Required(ErrorMessage = CustomExceptionMessages.RequiredPlayerName)]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }
        [Required(ErrorMessage = CustomExceptionMessages.RequiredPlayerUserName)]
        [StringLength(100, MinimumLength = 5)]
        public string Username { get; set; }
        [Required(ErrorMessage = CustomExceptionMessages.RequiredPlayerEmail)]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = CustomExceptionMessages.RequiredPlayerPassword)]
        [StringLength(100, MinimumLength = 8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Compare("Password", ErrorMessage = CustomExceptionMessages.RequiredPlayerConfirmPassword)]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = CustomExceptionMessages.RequiredPlayerDob)]
        [DataType(DataType.Date)]
        public DateTime Dob { get; set; }
    }
}
