using Newtonsoft.Json;

namespace BankApi.Domain.Entities
{
    /// <summary>
    /// AccountEntity
    /// </summary>
    public class AccountEntity
    {
        public AccountEntity()
        {

        }
        public AccountEntity(string id, int balance)
        {
            this.Id = id;
            this.Balance= balance;
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("balance")]
        public int Balance { get; set; }

          
    }

}
