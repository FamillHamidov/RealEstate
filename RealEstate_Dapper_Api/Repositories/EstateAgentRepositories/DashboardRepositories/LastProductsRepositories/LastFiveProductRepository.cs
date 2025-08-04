using Dapper;
using RealEstate_Dapper_Api.Dtos.ProductDto;
using RealEstate_Dapper_Api.Models.DapperContext;
using System.Reflection.Metadata;

namespace RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.LastProductsRepositories
{

    public class LastFiveProductRepository : ILastFiveProductRepository
    {
        private readonly Context _context;

        public LastFiveProductRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultLastFiveProductWithCategoryDto>> GetLastFiveProductAsync(int id)
        {
            string query = "select Top(5) ProductId, City, District, Price, AnnouncementDate, Title, CategoryName from Product inner join Category" +
                " on Product.ProductCategory=Category.CategoryId where EmployeeId=@employeeId order by ProductId desc";
            var parameters = new DynamicParameters();
            parameters.Add("employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLastFiveProductWithCategoryDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
