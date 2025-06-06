using RealEstate_Dapper_Api.Dtos.TestimonialDtos;

namespace RealEstate_Dapper_Api.Repositories.TestimonialRepositories
{
    public interface ITestimonialRepository
    {
        Task<List<ResulTestimonialDto>> GetAllTestimonialAsync();
        //void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        //void DeleteBottomGrid(int id);
        //void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);
        //Task<GetBottomGridDto> GetByIdBottomGridAsync(int id);
    }
}
