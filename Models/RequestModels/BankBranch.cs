using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BankClientApi.Models.RequestModels
{

    public class BankBranch
    {
        [JsonProperty("BankCode")]
        [JsonPropertyName("BankCode")]
        public int BankCode { get; set; }

        [JsonProperty("BranchNumber")]
        [JsonPropertyName("BranchNumber")]
        public int BranchNumber { get; set; }

        [JsonProperty("BranchName")]
        [JsonPropertyName("BranchName")]
        public string BranchName { get; set; }
    }



}
