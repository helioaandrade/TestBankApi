using BankApi.Application.Messages.Account;

namespace BankApi.Domain.Services
{
    public class AccountDomainService : IAccountService
    {
        public AccountDomainService()
        {

        }

        public Task<int> Balance(int account_id)
        {
            throw new NotImplementedException();
        }

        public DepositResponse Deposit(DepositRequest request)
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public TransferResponse Transfer(TransferRequest request)
        {
            throw new NotImplementedException();
        }

        public WithdrawResponse Withdraw(WithdrawRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
