using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IArtistService
    {
        Task<IEnumerable<ArtistResponseDto>> ListAllAsync();
        Task<ArtistResponseDto> GetByIdAsync(Guid id);
        Task<ArtistResponseDto> AddAsync(ArtistRequestDto artistRequestDto);
        Task<ArtistResponseDto> UpdateAsync(ArtistRequestDto artistRequestDto);
        Task DeleteAsync(Guid id);
    }
}
