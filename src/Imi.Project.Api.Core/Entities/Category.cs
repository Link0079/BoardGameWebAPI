using System;
using System.Collections.Generic;
using Imi.Project.Api.Core.Entities.Base;
using Imi.Project.Api.Core.Entities.Games;

namespace Imi.Project.Api.Core.Entities
{
    public class Category : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public ICollection<BoardGameCategory> BoardGames { get; set; }
    }
}
