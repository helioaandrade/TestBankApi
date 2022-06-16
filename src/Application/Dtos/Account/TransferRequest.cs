using Newtonsoft.Json;

namespace BankApi.Application.Messages.Account
{
    public class TransferRequest
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
