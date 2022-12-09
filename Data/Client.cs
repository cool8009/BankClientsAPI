using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankClientApi.Data
{
    public class Client
    {
        public int Id { get; set; }
        public string HebrewName { get; set; } //20 chars, hebrew only, no special chars except space - '
        public string EnglishName { get; set; } //15 chars, english only, no special chars except space - '
        public DateTime DateOfBirth { get; set; }
        public string SSN { get; set; } //9 chars, only numbers
        [ForeignKey(nameof(CityId))]
        public int CityId { get; set; }
        public City City { get; set; }
        public int BankCode { get; set; }
        public int BankBranch { get; set; }
        public string BankAccountNumber { get; set; } //up to 10 chars, nums only


    }
}
