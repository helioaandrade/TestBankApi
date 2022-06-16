using BankApi.Application.Messages.Account;

namespace BankApi.Domain.Services
{
    public interface IAccountService
    {
        void Reset();
        Task<int> Balance(int account_id);

        DepositResponse Deposit(DepositRequest request);
        TransferResponse Transfer(TransferRequest request);
        WithdrawResponse Withdraw(WithdrawRequest request);

    }
}
