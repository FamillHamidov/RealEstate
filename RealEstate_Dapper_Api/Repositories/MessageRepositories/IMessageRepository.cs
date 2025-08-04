using RealEstate_Dapper_Api.Dtos.MessageDtos;

namespace RealEstate_Dapper_Api.Repositories.MessageRepositories
{
    public interface IMessageRepository
    {
        public Task<List<ResultInBoxMessageDto>> GetLast3Message(int id);
    }
}
