using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankClientApi.Models.Client
{
    public class CreateClientDto
    {
        //data transfer object for the Client db model
        [Required]
        [StringLength(20, ErrorMessage = "Name length can't be more than 20.")]
        [RegularExpression(@"[א-תןםץךף'\s-]+",
         ErrorMessage = "Only Hebrew and the following: ' - are allowed.")]
        public string HebrewName { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Name length can't be more than 15.")]
        [RegularExpression(@"^[a-zA-Z'\-\s]+$",
         ErrorMessage = "Only English and the following: ' - are allowed.")]
        public string EnglishName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [RegularExpression("^[0-9]{9}$", ErrorMessage = "SSN must be numeric and contain 9 numbers")]
        public string SSN { get; set; }
        [Required]
        public int CityId { get; set; }
        [Required]
        public int BankCode { get; set; }
        [Required]
        public int BankBranch { get; set; }
        [Required]
        [RegularExpression("^[0-9]{0,9}$", ErrorMessage = "Bank account number must be numeric and contain 9 numbers")]
        public string BankAccountNumber { get; set; } 



    }
}
