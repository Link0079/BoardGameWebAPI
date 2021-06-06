using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Interfaces.Services.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IArtistService : IBaseService<ArtistResponseDto, ArtistRequestDto>
    {
        //Task<IEnumerable<ArtistResponseDto>> ListAllAsync();
        //Task<ArtistResponseDto> GetByIdAsync(Guid id);
        //Task<ArtistResponseDto> AddAsync(ArtistRequestDto artistRequestDto);
        //Task<ArtistResponseDto> UpdateAsync(ArtistRequestDto artistRequestDto);
        //Task DeleteAsync(Guid id);
        Task<IEnumerable<ArtistResponseDto>> SearchByNameAsycn(string name);
    }
}
