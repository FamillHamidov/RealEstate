using RealEstate_Dapper_Api.Dtos.ProductDto;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public interface IProductRepository
    {
        Task <List<ResultProductDto>> GetAllProductAsync();
        Task <List<ResultProductAdsListWithCategoryByEmployeeDto>> GetProductAdsListWithCategoryByEmployeeAsyncByTrue(int id);
        Task <List<ResultProductAdsListWithCategoryByEmployeeDto>> GetProductAdsListWithCategoryByEmployeeAsyncByFalse(int id);
        Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync();
        void ProductDealOfTheDayStatusChangeTrue(int id);
        void ProductDealOfTheDayStatusChangeFalse(int id);
        Task<List<ResultLastFiveProductWithCategoryDto>> GetLastFiveProductAsync();
        Task CreateProduct(CreateProductDto createProductDto);

    }
}
