using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BankClientApi.Models.RequestModels
{

    public class Data
    {
        [JsonProperty("Cities")]
        [JsonPropertyName("Cities")]
        public List<City> Cities { get; set; }

        [JsonProperty("Banks")]
        [JsonPropertyName("Banks")]
        public List<Bank> Banks { get; set; }

        [JsonProperty("BankBranches")]
        [JsonPropertyName("BankBranches")]
        public List<BankBranch> BankBranches { get; set; }

        [JsonProperty("Resellers")]
        [JsonPropertyName("Resellers")]
        public List<Reseller> Resellers { get; set; }

        [JsonProperty("Countries")]
        [JsonPropertyName("Countries")]
        public List<Country> Countries { get; set; }
    }



}
