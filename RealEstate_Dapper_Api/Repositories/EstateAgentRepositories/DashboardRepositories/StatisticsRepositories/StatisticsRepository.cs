using Dapper;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticsRepositories
{
    public class StatisticsRepository : IStatisticsRepository
    {
        private readonly Context _context;

        public StatisticsRepository(Context context)
        {
            _context = context;
        }
        public int ActiveProductCountByStatusFalse(int id)
        {
            string query = "select Count(*) from Product Where EmployeeId=@employeeId And ProductStatus=0";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, parameters);
                return values;
            }
        }

        public int ActiveProductCountByStatusTrue(int id)
        {
            string query = "select Count(*) from Product Where EmployeeId=@employeeId And ProductStatus=1";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, parameters);
                return values;
            }
        }

        public int ProductCount()
        {
            string query = "select Count(*) from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ProductCountByEmployeeId(int id)
        {
            string query = "select Count(*) from Product Where EmployeeId=@employeeId";
            var parameters = new DynamicParameters();
            parameters.Add("@employeeId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, parameters);
                return values;
            }
        }
    }
}
