using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ProductRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct()
        {
            var values = await _productRepository.GetAllProductAsync();
            return Ok(values);
        }
        [HttpGet("GetAllProductWithCategory")]
        public async Task<IActionResult> GetAllProductWithCategory()
        {
            var values = await _productRepository.GetAllProductWithCategoryAsync();
            return Ok(values);
        }
        [HttpGet("ProductDealOfTheDayStatusChangeTrue/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeTrue(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeTrue(id);
            return Ok("Product Deal Of The Day Status change true");
        }
        [HttpGet("ProductDealOfTheDayStatusChangeFalse/{id}")]
        public async Task<IActionResult> ProductDealOfTheDayStatusChangeFalse(int id)
        {
            _productRepository.ProductDealOfTheDayStatusChangeFalse(id);
            return Ok("Product Deal Of The Day Status change false");
        }
        [HttpGet("GetLastFiveProductAsync")]
        public async Task<IActionResult> GetLastFiveProductAsync()
        {
            var values = await _productRepository.GetLastFiveProductAsync();
            return Ok(values);
        }
        [HttpGet("GetProductAdsListWithCategoryByEmployee")]
        public async Task<IActionResult> GetProductAdsListWithCategoryByEmployee(int id)
        {
            var values=await _productRepository.GetProductAdsListWithCategoryByEmployeeAsync(id);
            return Ok(values);  
        }
    }
}
