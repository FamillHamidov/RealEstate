using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticsRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentDashboardStatisticsController : ControllerBase
    {
        private readonly IStatisticsRepository _statisticsRepository;

        public EstateAgentDashboardStatisticsController(IStatisticsRepository statisticsRepository)
        {
            _statisticsRepository = statisticsRepository;
        }
        [HttpGet("ProductCountByEmployeeId")]
        public IActionResult ProductCountByEmployeeId(int id)
        {
            return Ok(_statisticsRepository.ProductCountByEmployeeId(id));
        }

        [HttpGet("ProductCount")]
        public IActionResult ProductCount()
        {
            return Ok(_statisticsRepository.ProductCount());
        }

        [HttpGet("ActiveProductCountByStatusTrue")]
        public IActionResult ActiveProductCountByStatusTrue(int id)
        {
            return Ok(_statisticsRepository.ActiveProductCountByStatusTrue(id));
        }

        [HttpGet("ActiveProductCountByStatusFalse")]
        public IActionResult ActiveProductCountByStatusFalse(int id)
        {
            return Ok(_statisticsRepository.ActiveProductCountByStatusFalse(id));
        }
    }
}
