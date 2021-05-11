using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Games
{
    public class BoardGameArtistRequestDto
    {
        public Guid BoardGameId { get; set; }
        public Guid ArtistId { get; set; }
    }
}
