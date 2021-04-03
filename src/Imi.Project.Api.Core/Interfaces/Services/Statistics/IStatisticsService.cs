using Imi.Project.Api.Core.Dtos.Statistics;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Imi.Project.Api.Core.Interfaces.Services.Statistics
{
    public interface IStatisticsService
    {
        Task<StatisticsResponseDto> GetStatisticsAsync(int totalItems);
    }
}
