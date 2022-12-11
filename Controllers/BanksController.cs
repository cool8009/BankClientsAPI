using BankClientApi.Models.RequestModels;
using BankClientApi.Services.BankService;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BankClientApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BanksController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BanksController(IBankService bankService)
        {
            this._bankService = bankService;
        }
        [HttpGet]
        public async Task<IEnumerable<Bank>> GetBankData()
        {
            var banks = await _bankService.GetBankDataAsync();
            return banks;
        }
        [HttpGet("{id}")]
        public async Task<IEnumerable<BankBranch>> GetBranchesForId(int id)
        {
            var branchesForBankId = await _bankService.GetBankBranchDataForBankAsync(id);
            return branchesForBankId;
        }
        [HttpGet]
        [Route("/getallbranches")]
        public async Task<IEnumerable<BankBranch>> GetAllBranches()
        {
            var branchesForBankId = await _bankService.GetAllBankBranchDataAsync();
            return branchesForBankId;
        }
    }
}
