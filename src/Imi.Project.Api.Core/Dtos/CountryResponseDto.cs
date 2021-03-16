using Imi.Project.Api.Core.Dtos.Base;

namespace Imi.Project.Api.Core.Dtos
{
    public class CountryResponseDto : BaseDto
    {
        public string Name { get; set; }
        public string CountryCode { get; set; }
    }
}
