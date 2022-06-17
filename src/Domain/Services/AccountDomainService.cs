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

        public AccountEntity GetAccount(string account_id)
        {
            return AccountStorage.Find(account_id);
        }

        public int GetBalance(string account_id)
        {
            return AccountStorage.GetBalance(account_id);
        }

        /// <summary>
        /// Deposit money into account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public DepositResponse Deposit(DepositRequest request)
        {
            return AccountStorage.Deposit(request);
        }
 
        /// <summary>
        /// Transfer money from origin to destiny account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public TransferResponse Transfer(TransferRequest request)
        {
             return AccountStorage.Transfer(request);
        }

        /// <summary>
        /// Withdraw money from account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception ref="NotImplementedException"></exception>
        public WithdrawResponse Withdraw(WithdrawRequest request)
        {
            return AccountStorage.Withdraw(request);
        }

        
    }
}
