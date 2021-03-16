using Imi.Project.Api.Core.Dtos.Base;

namespace Imi.Project.Api.Core.Dtos
{
    public class PublisherResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string CountryName { get; set; }
        public int NumberOfPublishedBoardGames { get; set; } // CreateMap
    }
}
