using Imi.Project.Api.Core.Dtos.Base;

namespace Imi.Project.Api.Core.Dtos
{
    public class ArtistResponseDto: BaseDto
    {
        public string Name { get; set; }
        public string CountryName { get; set; }
        public string Dob { get; set; } // CreateMap
        public int NumberOfArtwork { get; set; } // CreateMap
    }
}
