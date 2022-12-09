using Microsoft.Extensions.Hosting;

namespace BankClientApi.Data
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Client> Clients { get; set; }

    }
}
