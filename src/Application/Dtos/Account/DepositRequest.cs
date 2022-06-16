using Newtonsoft.Json;

namespace BankApi.Application.Dtos.Account
{
    public class DepositRequest
    {
        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}
