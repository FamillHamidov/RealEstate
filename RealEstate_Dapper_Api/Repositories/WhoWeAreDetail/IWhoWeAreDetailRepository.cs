using RealEstate_Dapper_Api.Dtos.WhoWeAreDetailDto;

namespace RealEstate_Dapper_Api.Repositories.WhoWeAreDetail
{
    public interface IWhoWeAreDetailRepository
    {
        Task<List<ResultWhoWeAreDetailDto>> GetAllWhoWeAreDetailAsync();
        void CreateWhoWeAreDetail(CreateWhoWeAreDetailDto createWhoWeAreDetailDto);
        void DeleteWhoWeAreDetail(int id);
        void UpdateWhoWeAreDetail(UpdateWhoWeAreDetailDto updateWhoWeAreDetailDto);
        Task<GetByIdWhoWeAreDetailDto> GetByIdWhoWeAreDetailAsync(int id);
    }
}
