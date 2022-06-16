using BankApi.Domain.Entities;
using Newtonsoft.Json;

namespace BankApi.Application.Messages.Account
{
    public partial class DepositResponse
    {
        [JsonProperty("origin")]
        public AccountEntity Origin { get; set; }

        [JsonProperty("destination")]
        public AccountEntity Destination { get; set; }
    }

}
