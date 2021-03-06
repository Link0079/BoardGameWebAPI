﻿using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities
{
    public class Category : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public ICollection<BoardGameCategory> BoardGames { get; set; }
    }
}
