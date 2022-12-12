using BankClientApi.Models.RequestModels;

namespace BankClientApi.Services.BankService
{
    public class BankService : IBankService
    {
        //BankService class for making HTTP requests to the external API
        private readonly Uri uri = new Uri("https://www.xnes.co.il/ClosedSystemMiddlewareApi/api/generalinformation");
        private readonly HttpClient client = new HttpClient();
        public async Task<List<BankBranch>> GetAllBankBranchDataAsync()
        {
            try
            {
                var rootData = await client.GetFromJsonAsync<Root>(uri);
                if (rootData == null || rootData.Data == null || rootData.Data.BankBranches == null)
                {
                    throw new Exception("No bank branch data found. Please try again later.");
                }
                return rootData.Data.BankBranches;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while making a request to the external API. Please try again later.", ex);
            }
        }

        public async Task<List<BankBranch>> GetBankBranchDataForBankAsync(int bankId)
        {
            try
            {
                var bankBranches = await GetAllBankBranchDataAsync();
                var result = bankBranches.FindAll(b => b.BankCode == bankId);
                if (result == null || result.Count == 0)
                {
                    throw new Exception("No bank branches found for the specified bank ID. Please provide a valid bank ID and try again.");
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while making a request to the external API. Please try again later.", ex);
            }
        }
        public async Task<List<Bank>> GetBankDataAsync()
        {
            try
            {
                var rootData = await client.GetFromJsonAsync<Root>(uri);
                if (rootData == null || rootData.Data == null || rootData.Data.Banks == null)
                {
                    throw new Exception("No bank data found. Please try again later.");
                }
                return rootData.Data.Banks;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while making a request to the external API. Please try again later.", ex);
            }
        }
    }
}
