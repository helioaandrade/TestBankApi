using BankApi.Domain.Entities;

namespace BankApi.Application.Services.Account
{
    public class AccountApplicationService : IAccountApplicationService
    {
        public AccountApplicationService()
        {

        }

        public AccountEntity GetAccount(string id)
        {
            throw new NotImplementedException();
        }

        public int GetBalance(string id)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void SendEvent(EventEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
