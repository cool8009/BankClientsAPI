using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BankClientApi.Models.RequestModels
{

    public class City
    {
        [JsonProperty("Code")]
        [JsonPropertyName("Code")]
        public int Code { get; set; }

        [JsonProperty("Description")]
        [JsonPropertyName("Description")]
        public string Description { get; set; }
    }

}
