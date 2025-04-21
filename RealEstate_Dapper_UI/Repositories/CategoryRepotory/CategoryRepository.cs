using Dapper;
using RealEstate_Dapper_UI.Dtos.CategoryDtos;
using RealEstate_Dapper_UI.Models.DapperContext;

namespace RealEstate_Dapper_UI.Repositories.CategoryRepotory
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            string query = "Select * from Category";
            using (var connection = _context.CreateConnection())
            {
                var values =await  connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
