using AutoMapper;
using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Entities;
using Imi.Project.Api.Core.Interfaces.Repositories;
using Imi.Project.Api.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public async Task<CategoryResponseDto> GetByIdAsync(Guid id)
        {
            var result = await _categoryRepository.GetByIdAsync(id);
            var dto = _mapper.Map<CategoryResponseDto>(result);
            return dto;
        }
        public async Task<IEnumerable<CategoryResponseDto>> ListAllAsync()
        {
            var result = await _categoryRepository.ListAllAsync();
            var dto = _mapper.Map<IEnumerable<CategoryResponseDto>>(result);
            return dto;
        }
        public async Task<CategoryResponseDto> AddAsync(CategoryRequestDto categoryRequestDto)
        {
            var categoryEntity = _mapper.Map<Category>(categoryRequestDto);
            await _categoryRepository.AddAsync(categoryEntity);
            return await GetByIdAsync(categoryEntity.Id);
        }
        public async Task<CategoryResponseDto> UpdateAsync(CategoryRequestDto categoryRequestDto)
        {
            var categoryEntity = _mapper.Map<Category>(categoryRequestDto);
            await _categoryRepository.UpdateAsync(categoryEntity);
            return await GetByIdAsync(categoryEntity.Id);
        }
        public async Task DeleteAsync(Guid id)
        {
            await _categoryRepository.DeleteAsync(id);
        }
        public async Task<IEnumerable<CategoryResponseDto>> SearchByNameAsycn(string name)
        {
            var result = await _categoryRepository.SearchByNameAsync(name);
            var dto = _mapper.Map<IEnumerable<CategoryResponseDto>>(result);
            return dto;
        }
    }
}
