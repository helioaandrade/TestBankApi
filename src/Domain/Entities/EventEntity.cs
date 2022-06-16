using Newtonsoft.Json;
using static BankApi.Domain.Common.Enumerators;

namespace BankApi.Domain.Entities
{
    public class EventEntity
    {
        [JsonProperty("type")]
        public EventType Type { get; set; }

        [JsonProperty("origem")]
        public string Origem { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }

   
}
