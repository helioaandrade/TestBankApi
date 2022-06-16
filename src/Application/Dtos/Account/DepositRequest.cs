using Newtonsoft.Json;

namespace BankApi.Application.Messages.Account
{
    public class DepositRequest
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("destination")]
        public string? Destination { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}
