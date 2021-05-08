using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Interfaces.Services.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface ICategoryService : IBaseService<CategoryResponseDto, CategoryRequestDto>
    {
        //Task<IEnumerable<CategoryResponseDto>> ListAllAsync();
        //Task<CategoryResponseDto> GetByIdAsync(Guid id);
        //Task<CategoryResponseDto> AddAsync(CategoryRequestDto categoryRequestDto);
        //Task<CategoryResponseDto> UpdateAsync(CategoryRequestDto categoryRequestDto);
        //Task DeleteAsync(Guid id);
        Task<IEnumerable<CategoryResponseDto>> SearchByNameAsync(string name);
    }
}
