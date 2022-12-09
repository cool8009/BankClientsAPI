using BankClientApi.Contracts;
using BankClientApi.Data;

namespace BankClientApi.Repository
{
    public class CitiesRepository : GenericRepository<City>, ICitiesRepository
    {

        public CitiesRepository(BankClientsDbContext context) : base(context)
        {

        }
    }
}
