using Imi.Project.Api.Core.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface ICountryService
    {
        Task<IEnumerable<CountryResponseDto>> ListAllAsync();
        Task<CountryResponseDto> GetByIdAsync();
        Task<IEnumerable<CountryResponseDto>> SearchByNameAsycn(string name);
    }
}
