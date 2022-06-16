using BankApi.Domain.Entities;
using Newtonsoft.Json;

namespace BankApi.Application.Messages.Account
{
    public class WithdrawResponse
    {
        [JsonProperty("origin")]
        public AccountEntity Origin { get; set; }
    }
}
