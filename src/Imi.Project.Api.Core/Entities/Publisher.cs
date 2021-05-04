using System;
using System.Collections.Generic;
using Imi.Project.Api.Core.Entities.Base;
using Imi.Project.Api.Core.Entities.Games;

namespace Imi.Project.Api.Core.Entities
{
    public class Publisher : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public DateTime Dob { get; set; }
        //public Guid CountryId { get; set; }
        //public Country Country { get; set; }
        public bool IsDeleted { get; set; }
        //public ICollection<BoardGame> PublishedBoardGames { get; set; }
    }
}
