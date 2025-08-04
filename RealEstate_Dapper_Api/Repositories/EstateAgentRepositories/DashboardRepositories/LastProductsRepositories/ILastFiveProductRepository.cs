using RealEstate_Dapper_Api.Dtos.ProductDto;

namespace RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories
{
    public interface ILastFiveProductRepository
    {
        Task<List<ResultLastFiveProductWithCategoryDto>> GetLastFiveProductAsync(int id);
    }
}
