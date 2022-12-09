using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankClientApi.Data
{
    public class Client
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Name length can't be more than 20.")]
        [RegularExpression(@"^[א-ת'\-\s]+$",
         ErrorMessage = "Only Hebrew and the following: ' - are allowed.")]
        public string HebrewName { get; set; } //20 chars, hebrew only, no special chars except space - '
        [Required]
        [StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        [RegularExpression(@"^[a-zA-Z'\-\s]+$",
         ErrorMessage = "Only English and the following: ' - are allowed.")]
        public string EnglishName { get; set; } //15 chars, english only, no special chars except space - '
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [RegularExpression("^[0-9]{9}$", ErrorMessage = "SSN must be numeric and contain 9 numbers")]
        public string SSN { get; set; } //9 chars, only numbers
        [Required]
        [ForeignKey(nameof(CityId))]
        public int CityId { get; set; }
        [Required]
        public int BankCode { get; set; }
        [Required]
        public int BankBranch { get; set; }
        [Required]
        [RegularExpression("^[0-9]{0,10}$", ErrorMessage = "SSN must be numeric and contain 9 numbers")]
        public string BankAccountNumber { get; set; } //up to 10 chars, nums only


    }
}
