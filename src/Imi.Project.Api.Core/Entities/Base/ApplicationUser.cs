using Microsoft.AspNetCore.Identity;
using System;

namespace Imi.Project.Api.Core.Entities.Base
{
    public abstract class ApplicationUser : IdentityUser<Guid>
    {
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        //public Guid CountryId { get; set; }
        //public Country Country { get; set; }
        public bool IsDeleted { get; set; }
    }
}
