using BankClientApi.Contracts;
using BankClientApi.Data;

namespace BankClientApi.Repository
{
    public class ClientsRepository : GenericRepository<Client>, IClientsRepository
    {

        public ClientsRepository(BankClientsDbContext context) : base(context)
        {

        }
    }
}
