using Imi.Project.Api.Core.Dtos.Base;
using System.Collections.Generic;

namespace Imi.Project.Api.Core.Dtos.Games
{
    public class BoardGameResponseDto : BaseDto
    {
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Year { get; set; }
        public string PhotoUrl { get; set; }
        public int Rating { get; set; }
        public int MinPlayers { get; set; }
        public int MaxPlayers { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }
        //public string CountryName { get; set; }
        public string Stock { get; set; } // CreateMap
        public string PlayTime { get; set; } // CreateMap
        public int NumberOfCategories { get; set; } // CreateMap
        public ICollection<CategoryResponseDto> Categories { get; set; } // CreateMap
        public int NumberofArtists { get; set; } // CreateMap

    }
}
