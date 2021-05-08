using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.IdentityManagment
{
    public class RoleResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string NormalizedName { get; set; }
    }
}
