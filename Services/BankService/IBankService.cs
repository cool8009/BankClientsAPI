using BankClientApi.Models.RequestModels;

namespace BankClientApi.Services.BankService
{
    public interface IBankService
    {
        /// <summary>
        /// GET all branch data for all banks from external API
        /// </summary>
        /// <returns>A List of BankBranch objects</returns>
        /// <exception cref="Exception"></exception>
        Task<List<Bank>> GetBankDataAsync();
        /// <summary>
        /// GET branches for specific bank by id
        /// </summary>
        /// <param name="bankId"></param>
        /// <returns>A List of BankBranch objects</returns>
        /// <exception cref="Exception"></exception>
        Task<List<BankBranch>> GetAllBankBranchDataAsync();
        /// <summary>
        /// GET all of the available banks
        /// </summary>
        /// <returns>A list of the Bank object</returns>
        /// <exception cref="Exception"></exception>
        Task<List<BankBranch>> GetBankBranchDataForBankAsync(int bankId);
    }
}
