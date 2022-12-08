using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace BankClientApi.Models.RequestModels
{

    public class Country
    {
        [JsonProperty("Id")]
        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonProperty("Value")]
        [JsonPropertyName("Value")]
        public string Value { get; set; }

        [JsonProperty("Name")]
        [JsonPropertyName("Name")]
        public string Name { get; set; }
    }



}
