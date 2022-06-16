using BankApi.Domain.Entities;

namespace BankApi.Application.Services.Account
{
    public interface IAccountApplicationService
    {
        void Reset();
        AccountEntity GetAccount(string account_id);
        int GetBalance(string account_id);
        dynamic SendEvent(EventEntity entity);
    
    }
}
