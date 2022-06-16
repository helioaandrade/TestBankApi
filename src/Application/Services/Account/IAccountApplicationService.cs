using BankApi.Domain.Entities;

namespace BankApi.Application.Services.Account
{
    public interface IAccountApplicationService
    {
        void Reset();
        public AccountEntity GetAccount(string id);
        public int GetBalance(string id);
        void SendEvent(EventEntity entity);
    
    }
}
