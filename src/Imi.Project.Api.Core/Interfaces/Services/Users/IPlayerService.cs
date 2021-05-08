using Imi.Project.Api.Core.Dtos.Users;
using Microsoft.AspNetCore.Identity;
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
        Task<IEnumerable<PlayerResponseDto>> SearchByNameAsycn(string name);
        Task<PlayerResponseDto> AddAsync(PlayerRequestDto playerRequestDto);
        Task<PlayerResponseDto> UpdateAsync(PlayerRequestDto playerRequestDto);
        Task<PlayerResponseDto> UpdateAsync(Guid guid, bool isActive);
        Task DeleteAsync(Guid id);
        Task<IdentityResult> AddRegisteredPlayerAsync(RegisterPlayerRequestDto registerPlayerRequestDto);
    }
}
