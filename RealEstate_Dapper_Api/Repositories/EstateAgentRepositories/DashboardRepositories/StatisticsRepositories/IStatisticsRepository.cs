namespace RealEstate_Dapper_Api.Repositories.EstateAgentRepositories.DashboardRepositories.StatisticsRepositories
{
    public interface IStatisticsRepository
    {
        
       
        int ProductCountByEmployeeId(int id);
        int ProductCount();
        int ActiveProductCountByStatusTrue(int id);
        int ActiveProductCountByStatusFalse(int id);
        
    }
}
