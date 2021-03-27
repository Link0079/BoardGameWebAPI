using Imi.Project.Api.Core.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.Users
{
    public interface IPlayerService
    {
        Task<IEnumerable<PlayerResponseDto>> ListAllAsync();
        Task<PlayerResponseDto> GetByIdAsync(Guid id);
        Task<PlayerResponseDto> AddAsync(PlayerRequestDto playerRequestDto);
        Task<PlayerResponseDto> UpdateAsync(PlayerRequestDto playerRequestDto);
        Task DeleteAsync(Guid id);

    }
}
