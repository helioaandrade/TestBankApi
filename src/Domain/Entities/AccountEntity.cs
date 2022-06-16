using Newtonsoft.Json;

namespace BankApi.Domain.Entities
{
    /// <summary>
    /// AccountEntity
    /// </summary>
    public class AccountEntity
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("balance")]
        public int Balance { get; set; }
    }

}
