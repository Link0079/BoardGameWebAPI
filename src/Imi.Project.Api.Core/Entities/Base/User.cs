using System;

namespace Imi.Project.Api.Core.Entities.Base
{
    public abstract class User : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public Guid CountryId { get; set; }
        public Country Country { get; set; }
        public bool IsDeleted { get; set; }
    }
}
