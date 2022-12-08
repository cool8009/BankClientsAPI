using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BankClientApi.Models.RequestModels
{
    public class Root
    {
        [JsonProperty("Status")]
        [JsonPropertyName("Status")]
        public string Status { get; set; }

        [JsonProperty("Code")]
        [JsonPropertyName("Code")]
        public int Code { get; set; }

        [JsonProperty("Data")]
        [JsonPropertyName("Data")]
        public Data Data { get; set; }

    }
}
