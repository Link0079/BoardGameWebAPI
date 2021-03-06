using System;
using Imi.Project.Api.Core.Entities.Users;

namespace Imi.Project.Api.Core.Entities.Games
{
    public class BoardGameArtist
    {
        public Guid BoardGameId { get; set; }
        public Guid ArtistId { get; set; }
        public BoardGame BoardGame { get; set; }
        public Artist Artist { get; set; }
    }
}
