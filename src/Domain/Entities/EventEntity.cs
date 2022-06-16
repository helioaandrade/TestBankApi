using Newtonsoft.Json;
 

namespace BankApi.Domain.Entities
{
    public class EventEntity
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("origin")]
        public string? Origin { get; set; }

        [JsonProperty("destination")]
        public string? Destination { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

   
}
