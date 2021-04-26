using Imi.Project.Api.Core.Interfaces.Services.Statistics;
using Imi.Project.Common;
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
    public class StatisticsController : ControllerBase
    {
        private readonly IStatisticsService _statisticsService;
        public StatisticsController(IStatisticsService statisticsService)
        {
            _statisticsService = statisticsService;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] int totalItems)
        {
            if (totalItems < 1)
                return BadRequest(string.Format(CustomExceptionMessages.NotFoundStatisticsTotalItems, totalItems));
            var result = await _statisticsService.GetStatisticsAsync(totalItems);
            return Ok(result);
        }
    }
}
