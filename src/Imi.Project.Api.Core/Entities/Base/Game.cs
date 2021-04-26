using System;

namespace Imi.Project.Api.Core.Entities.Base
{
    public abstract class Game : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        //public Guid CountryId { get; set; }
        //public Country Country { get; set; }
        public bool IsDeleted { get; set; }
    }
}
