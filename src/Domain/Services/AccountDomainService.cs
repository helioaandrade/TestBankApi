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
            // TODO - exclude mock
        }
        public int GetBalance(string account_id)
        {
            // TODO - exclude mock
            return 10;
        }

        public AccountEntity GetAccount(string account_id)
        {
            // TODO - exclude mock
            var response = new AccountEntity
            {
                Id = "100",
                Balance = 10
            };

            return response;
        }


        /// <summary>
        /// Transfer money from origin to destiny account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public TransferResponse Transfer(TransferRequest request)
        {
            // TODO - exclude mock

            var response = new TransferResponse
            {
                Origin = new AccountEntity
                {
                    Id = request.Origin,
                    Balance = request.Amount
                },
                Destination = new AccountEntity
                {
                    Id = request.Destination,
                    Balance = request.Amount
                }
            };

            return response;
        }

        /// <summary>
        /// Withdraw money from account
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public WithdrawResponse Withdraw(WithdrawRequest request)
        {
            // TODO - exclude mock

            var response = new WithdrawResponse
            {
                Origin = new AccountEntity
                {
                    Id = request.Origin,
                    Balance = request.Amount
                }
            };

            return response;
        }

        public DepositResponse Deposit(DepositRequest request)
        {
            // TODO - exclude mock

            var response = new DepositResponse
            {
                Destination = new AccountEntity
                {
                    Id = request.Destination,
                    Balance = request.Amount
                }
            };

            return response;
        }
    }
}
