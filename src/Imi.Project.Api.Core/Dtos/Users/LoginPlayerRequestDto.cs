using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Users
{
    public class LoginPlayerRequestDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
