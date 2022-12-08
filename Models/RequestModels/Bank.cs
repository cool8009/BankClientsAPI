using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BankClientApi.Models.RequestModels
{

    public class Bank
    {
        [JsonProperty("Code")]
        [JsonPropertyName("Code")]
        public int Code { get; set; }

        [JsonProperty("Description")]
        [JsonPropertyName("Description")]
        public string Description { get; set; }

        [JsonProperty("Status")]
        [JsonPropertyName("Status")]
        public bool Status { get; set; }
    }



}
