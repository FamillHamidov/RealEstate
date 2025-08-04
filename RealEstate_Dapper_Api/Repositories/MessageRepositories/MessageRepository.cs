using Dapper;
using RealEstate_Dapper_Api.Dtos.MessageDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.MessageRepositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly Context _context;

        public MessageRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultInBoxMessageDto>> GetLast3Message(int id)
        {
            string query = "select top(3) Name, MessageId, Subject, Message, SendDate, IsRead, PictureUrl from Message inner join AppUser on " +
                "Message.Sender=AppUser.Id Where Receiver=@receiverId order by MessageId desc";
            var parameters = new DynamicParameters();
            parameters.Add("@receiverId", id);
            using (var connection = _context.CreateConnection())
            {
                var value = await connection.QueryAsync<ResultInBoxMessageDto>(query, parameters);
                return value.ToList();
            }
        }
    }
}
