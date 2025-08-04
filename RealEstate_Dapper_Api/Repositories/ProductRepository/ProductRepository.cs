using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.ProductDto;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.ProductRepository
{
    public class ProductRepository : IProductRepository
    {
        private readonly Context _context;

        public ProductRepository(Context context)
        {
            _context = context;
        }

        public async Task CreateProduct(CreateProductDto createProductDto)
        {
            string query = "Insert into Product (Title, Price, CoverImage, City, District, Address, Description, Type, EmployeeId, ProductCategory, DealOfTheDay, AnnouncementDate, ProductStatus)" +
                " values (@title, @price, @coverImage, @city, @district, @address, @description, @type, @employeeId, @productCategory, @dealOfTheDay, @announcementDate, @productStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@title", createProductDto.Title);
            parameters.Add("@price", createProductDto.Price);
            parameters.Add("@coverImage", createProductDto.CoverImage);
            parameters.Add("@city", createProductDto.City);
            parameters.Add("@district", createProductDto.District);
            parameters.Add("@address", createProductDto.Address);
            parameters.Add("@description", createProductDto.Description);
            parameters.Add("@type", createProductDto.Type);
            parameters.Add("@employeeId", createProductDto.EmployeeId);
            parameters.Add("@productCategory", createProductDto.ProductCategory);
            parameters.Add("@dealOfTheDay", createProductDto.DealOfTheDay);
            parameters.Add("@announcementDate", createProductDto.AnnouncementDate);
            parameters.Add("@productStatus", createProductDto.ProductStatus);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultProductDto>> GetAllProductAsync()
        {
            string query = "Select * from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductWithCategoryDto>> GetAllProductWithCategoryAsync()
        {
            string query = "Select ProductId, Title, Price, City, District, CategoryName, CoverImage, Type, Address, DealOfTheDay " +
                "from Product inner join Category on Product.ProductCategory=Category.CategoryId";
                
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultLastFiveProductWithCategoryDto>> GetLastFiveProductAsync()
        {
            string query = "select Top(5) ProductId, City, District, Price, AnnouncementDate, Title, CategoryName from Product inner join Category" +
                " on Product.ProductCategory=Category.CategoryId where Type=N'Kirayə' order by ProductId desc";

            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLastFiveProductWithCategoryDto>(query);
                return values.ToList();
            }
        }

        public async Task<List<ResultProductAdsListWithCategoryByEmployeeDto>> GetProductAdsListWithCategoryByEmployeeAsyncByFalse(int id)
        {
            string query = "Select ProductId, Title, Price, City, District, CategoryName, CoverImage, Type, Address, DealOfTheDay " +
                "from Product inner join Category on Product.ProductCategory=Category.CategoryId where EmployeeId=@employeeId and ProductStatus=0";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdsListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }
        public async Task<List<ResultProductAdsListWithCategoryByEmployeeDto>> GetProductAdsListWithCategoryByEmployeeAsyncByTrue(int id)
        {
            string query = "Select ProductId, Title, Price, City, District, CategoryName, CoverImage, Type, Address, DealOfTheDay " +
                "from Product inner join Category on Product.ProductCategory=Category.CategoryId where EmployeeId=@employeeId and ProductStatus=1";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultProductAdsListWithCategoryByEmployeeDto>(query, parameters);
                return values.ToList();
            }
        }

        public async void ProductDealOfTheDayStatusChangeFalse(int id)
        {
            string query = "Update Product set DealOfTheDay=0 where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async void ProductDealOfTheDayStatusChangeTrue(int id)
        {
            string query = "Update Product set DealOfTheDay=1 where ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
