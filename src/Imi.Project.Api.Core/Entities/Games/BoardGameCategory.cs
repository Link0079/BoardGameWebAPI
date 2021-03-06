using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities.Games
{
    public class BoardGameCategory
    {
        public Guid BoardGameId { get; set; }
        public Guid CategoryId { get; set; }
        public BoardGame BoardGame { get; set; }
        public Category Category { get; set; }

    }
}
