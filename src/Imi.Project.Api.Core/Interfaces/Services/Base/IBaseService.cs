using Imi.Project.Api.Core.Dtos.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.Base
{
    public interface IBaseService<TResponse, TRequest> where TResponse : BaseDto where TRequest : BaseDto
    {
        Task<IEnumerable<TResponse>> ListAllAsync();
        Task<TResponse> GetByIdAsync(Guid id);
        Task<TResponse> AddAsync(TRequest entityRequestDto);
        Task<TResponse> UpdateAsync(TRequest entityRequestDto);
        Task DeleteAsync(Guid id);
    }
}
