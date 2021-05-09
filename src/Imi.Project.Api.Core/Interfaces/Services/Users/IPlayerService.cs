using Imi.Project.Api.Core.Dtos.IdentityManagment;
using Imi.Project.Api.Core.Dtos.Users;
using Imi.Project.Api.Core.Interfaces.Services.Base;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.Users
{
    public interface IPlayerService : IBaseService<PlayerResponseDto, PlayerRequestDto>
    {
        //Task<IEnumerable<PlayerResponseDto>> ListAllAsync();
        //Task<PlayerResponseDto> GetByIdAsync(Guid id);
        //Task<PlayerResponseDto> AddAsync(PlayerRequestDto playerRequestDto);
        //Task<PlayerResponseDto> UpdateAsync(PlayerRequestDto playerRequestDto);
        //Task DeleteAsync(Guid id);
        Task<IEnumerable<PlayerResponseDto>> SearchByNameAsycn(string name);
        Task<PlayerResponseDto> UpdateAsync(Guid guid, bool isActive);
        Task<IdentityResult> AddRegisteredPlayerAsync(RegisterPlayerRequestDto registerPlayerRequestDto);
        Task<IEnumerable<RoleResponseDto>> GetRolesByPlayerId(Guid guid);
    }
}
