using Imi.Project.Api.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imi.Project.Api.Core.Entities.Users
{
    public class Artist : User
    {
        public int Year { get; set; }
        public ICollection<BoardGameArtist> Artwork { get; set; }
    }
}
