using System.ComponentModel.DataAnnotations.Schema;

namespace BankClientApi.Models.Client
{
    public class GetClientDto
    {
        public int Id { get; set; }
        public string HebrewName { get; set; } 
        public string EnglishName { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string SSN { get; set; } 
        public int CityId { get; set; }
        public int BankCode { get; set; }
        public int BankBranch { get; set; }
        public string BankAccountNumber { get; set; } 
    }
}
