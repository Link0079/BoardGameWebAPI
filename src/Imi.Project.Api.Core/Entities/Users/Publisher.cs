using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities.Users
{
    public class Publisher : User
    {
        public ICollection<BoardGame> PublishedBoardGames { get; set; }
    }
}
