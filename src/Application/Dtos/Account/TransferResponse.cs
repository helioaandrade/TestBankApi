
using BankApi.Domain.Entities;
using Newtonsoft.Json;
namespace BankApi.Application.Messages.Account
{
    public class TransferResponse
    {
        [JsonProperty("origin")]
        public AccountEntity Origin { get; set; }

        [JsonProperty("destination")]
        public AccountEntity Destination { get; set; }
    }

    
}
