using BankApi.Domain.Entities;
using Newtonsoft.Json;

namespace BankApi.Application.Dtos.Account
{
    public partial class DepositResponse
    {
        
        [JsonProperty("destination")]
        public AccountEntity Destination { get; set; }
    }

}
