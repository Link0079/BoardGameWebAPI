using System.Collections.Generic;
using Imi.Project.Api.Core.Entities.Base;
using Imi.Project.Api.Core.Entities.Games;

namespace Imi.Project.Api.Core.Entities.Users
{
    public class Artist : User
    {
        public int Year { get; set; }
        public ICollection<BoardGameArtist> Artwork { get; set; }
    }
}
