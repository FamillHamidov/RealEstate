using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstateAgentDashboardLastProductsController : ControllerBase
    {
        private readonly ILastFiveProductRepository _lastFiveProductRepository;

        public EstateAgentDashboardLastProductsController(ILastFiveProductRepository lastFiveProductRepository)
        {
            _lastFiveProductRepository = lastFiveProductRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetLastFiveProduct(int id)
        {
            var values = await _lastFiveProductRepository.GetLastFiveProductAsync(id);
            return Ok(values);
        }
    }
}
