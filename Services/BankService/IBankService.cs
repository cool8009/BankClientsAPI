using BankClientApi.Models.RequestModels;

namespace BankClientApi.Services.BankService
{
    public interface IBankService
    {
        Task<List<Bank>> GetBankDataAsync();
        Task<List<BankBranch>> GetAllBankBranchDataAsync();
        Task<List<BankBranch>> GetBankBranchDataForBankAsync(int bankId);
    }
}
