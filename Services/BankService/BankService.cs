using BankClientApi.Models.RequestModels;

namespace BankClientApi.Services.BankService
{
    public class BankService : IBankService
    {
        private readonly Uri uri = new Uri("https://www.xnes.co.il/ClosedSystemMiddlewareApi/api/generalinformation");
        private readonly HttpClient client = new HttpClient();

        public async Task<List<BankBranch>> GetAllBankBranchDataAsync()
        {
            var rootData = await client.GetFromJsonAsync<Root>(uri);
            return rootData.Data.BankBranches;
        }

        public async Task<List<BankBranch>> GetBankBranchDataForBankAsync(int bankId)
        {
            var bankBranches = await GetAllBankBranchDataAsync();
            return bankBranches.FindAll(b => b.BankCode == bankId);
        }

        public async Task<List<Bank>> GetBankDataAsync()
        {
            var rootData = await client.GetFromJsonAsync<Root>(uri);
            return rootData.Data.Banks;
        }
    }
}
