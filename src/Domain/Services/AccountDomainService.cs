using BankApi.Application.Dtos.Account;
using BankApi.Domain.Entities;
 
namespace BankApi.Domain.Services
{
    public class AccountDomainService : IAccountDomainService
    {
        public AccountDomainService()
        {
        }

        /// <summary>
        /// Reset accounts
        /// </summary>
        public void Reset()
        {
            AccountStorage.Reset();
        }

        /// <summary>
        /// Get account
        /// </summary>
        /// <param name="account_id"></param>
        /// <returns></returns>
        public AccountEntity GetAccount(string account_id)
        {
            return AccountStorage.Find(account_id);
        }

        /// <summary>
        /// Get balance
        /// </summary>
        /// <param name="account_id"></param>
        /// <returns></returns>
        public int GetBalance(string account_id)
        {
            return AccountStorage.GetBalance(account_id);
        }

        /// <summary>
        /// Execute deposut event
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DepositResponse Deposit(DepositRequest request)
        {
            return AccountStorage.Deposit(request);
        }

        /// <summary>
        /// Execute transfer event
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public TransferResponse Transfer(TransferRequest request)
        {
            return AccountStorage.Transfer(request);
        }

        /// <summary>
        /// Execute withdraw event
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public WithdrawResponse Withdraw(WithdrawRequest request)
        {
            return AccountStorage.Withdraw(request);
        }
 
    }
}
