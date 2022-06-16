using Newtonsoft.Json;

namespace BankApi.Application.Dtos.Account
{
    public class TransferRequest
    {
        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
