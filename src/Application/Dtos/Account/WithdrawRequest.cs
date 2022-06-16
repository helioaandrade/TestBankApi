
using Newtonsoft.Json;

namespace BankApi.Application.Dtos.Account
{
    public class WithdrawRequest
    {
        [JsonProperty("origin")]
        public string Origin { get; set; }

        [JsonProperty("amount")]
        public int Amount { get; set; }
    }
}
