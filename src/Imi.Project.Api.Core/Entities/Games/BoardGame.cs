using System;
using System.Collections.Generic;
using Imi.Project.Api.Core.Entities.Base;
using Imi.Project.Api.Core.Entities.Users;

namespace Imi.Project.Api.Core.Entities.Games
{
    public class BoardGame : Game
    {
        public int Age { get; set; }
        public int Rating { get; set; }
        public int PlayTime { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public string Description { get; set; }
        public bool Stock { get; set; }
        public Uri PhotoUrl { get; set; }
        public Guid PublisherId { get; set; }
        public Publisher Publisher { get; set; }
        public ICollection<BoardGameCategory> Categories { get; set; }
        public ICollection<BoardGameArtist> Artists { get; set; }

    }
}
