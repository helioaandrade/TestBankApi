using BankApi.Application.Dtos.Account;
using BankApi.Domain.Entities;

namespace BankApi.Domain.Services
{
    public interface IAccountDomainService
    {
        void Reset();
        int GetBalance(string account_id);
        AccountEntity GetAccount(string account_id);
        DepositResponse Deposit(DepositRequest request);
        TransferResponse Transfer(TransferRequest request);
        WithdrawResponse Withdraw(WithdrawRequest request);
    }
}
