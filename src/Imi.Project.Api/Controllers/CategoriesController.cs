using Imi.Project.Api.Core.Dtos;
using Imi.Project.Api.Core.Interfaces.Services;
using Imi.Project.Api.Core.Interfaces.Services.Games;
using Imi.Project.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imi.Project.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "OnlyUserAccess")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IBoardGameService _boardGameService;
        public CategoriesController(ICategoryService categoryService, IBoardGameService boardGameService)
        {
            _categoryService = categoryService;
            _boardGameService = boardGameService;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                var categoriesDto = await _categoryService.SearchByNameAsync(name);
                if (categoriesDto.Any())
                    return Ok(categoriesDto);
                else
                    return NotFound(string.Format(CustomExceptionMessages.NotFoundCategoryName, name));
            }
            else
            {
                var categoriesDto = await _categoryService.ListAllAsync();
                return Ok(categoriesDto);
            }
        }
        [HttpGet("{guid}")]
        public async Task<IActionResult> Get(Guid guid)
        {
            var category = await _categoryService.GetByIdAsync(guid);
            if (category == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundCategoryId, guid));
            return Ok(category);
        }
        [HttpGet("{guid}/boardgames")]
        public async Task<IActionResult> GetByCategoryId(Guid guid)
        {
            var category = await _categoryService.GetByIdAsync(guid);
            if(category == null)
                return NotFound(string.Format(CustomExceptionMessages.NotFoundCategoryId, guid));
            var boardgames = await _boardGameService.GetByCategoryIdAsync(guid);
            if (!boardgames.Any())
                return NotFound(string.Format(CustomExceptionMessages.NotFoundCategoryBoardGames, guid));
            return Ok(boardgames);
        }
        [HttpPost]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> Post(CategoryRequestDto categoryRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var categoryResponseDto = await _categoryService.AddAsync(categoryRequestDto);
                return CreatedAtAction(nameof(Get), new { id = categoryResponseDto.Id }, categoryResponseDto);
            }
            catch (Exception)
            { return Conflict(CustomExceptionMessages.ConflictAddCategory); }
        }
        [HttpPut]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> Put(CategoryRequestDto categoryRequestDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            try
            {
                var categoryResponseDto = await _categoryService.UpdateAsync(categoryRequestDto);
                return CreatedAtAction(nameof(Get), new { id = categoryResponseDto.Id }, categoryResponseDto);
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictUpdateCategory, categoryRequestDto.Id)); }
        }
        [HttpDelete("{guid}")]
        [Authorize(Policy = "Administrators")]
        public async Task<IActionResult> Delete(Guid guid)
        {
            try
            {
                var categoryEntity = await _categoryService.GetByIdAsync(guid);
                if (categoryEntity == null)
                    return NotFound(string.Format(CustomExceptionMessages.NotFoundCategoryId, guid));
                await _categoryService.DeleteAsync(guid);
                return Ok(string.Format(CustomExceptionMessages.DeleteCategoryId, guid));
            }
            catch (Exception)
            { return Conflict(string.Format(CustomExceptionMessages.ConflictDeleteCategoryId, guid)); }
        }
    }
}
