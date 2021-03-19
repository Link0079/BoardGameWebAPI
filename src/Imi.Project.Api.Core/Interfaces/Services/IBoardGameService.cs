﻿using Imi.Project.Api.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services
{
    public interface IBoardGameService
    {
        Task<IEnumerable<BoardGameResponseDto>> ListAllAsync();
        Task<BoardGameResponseDto> GetByIdAsync(Guid id);
        Task<IEnumerable<BoardGameResponseDto>> GetByCategoryIdAsync(Guid id);
    }
}
