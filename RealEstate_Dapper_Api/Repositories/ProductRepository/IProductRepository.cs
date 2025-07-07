using RealEstate_Dapper_Api.Dtos.ProductDto;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task <List<ResultProductDto>> GetAllProductAsync();
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        void ProductDealOfTheDayStatusChangeTrue(int id);
        void ProductDealOfTheDayStatusChangeFalse(int id);
    }
}
