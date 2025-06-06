using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepositories
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        //void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        //void DeleteBottomGrid(int id);
        //void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        //Task<GetBottomGridDto> GetByIdBottomGridAsync(int id);
    }
}
