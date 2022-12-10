using BankClientApi.Contracts;
using BankClientApi.Data;
using Microsoft.EntityFrameworkCore;

namespace BankClientApi.Repository
{
    public class CitiesRepository : GenericRepository<City>, ICitiesRepository
    {

        public CitiesRepository(BankClientsDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<City>> GetAllCitiesAsync()
        {
            //Stored procedure implementation
            var storedProcedureName = "[dbo].[GetCities]";
            var entities = await _context.Cities
                .FromSqlInterpolated($"{storedProcedureName}")
                .ToListAsync();

            return entities;
        }
    }
}
