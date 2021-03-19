using Imi.Project.Api.Core.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IPlayerService
    {
        Task<IEnumerable<PlayerResponseDto>> ListAllAsync();
        Task<PlayerResponseDto> GetByIdAsync(Guid id);
    }
}
