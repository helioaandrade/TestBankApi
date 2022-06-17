﻿using BankApi.Application.Dtos.Account;

namespace BankApi.Domain.Entities
{
    public static class AccountStorage
    {
        public static List<AccountEntity>? Accounts { get; set; }

        /// <summary>
        /// Reset account
        /// </summary>
        public static void Reset() => Accounts?.Clear();


        /// <summary>
        /// Create account
        /// </summary>
        /// <param name="account_id"></param>
        /// <returns></returns>
        public static AccountEntity Create(string account_id, int balance)
        {
            return new AccountEntity(account_id, balance);

        }

        /// <summary>
        /// Verify if account exists
        /// </summary>
        /// <param name="account_id"></param>
        /// <returns></returns>
        public static bool? Exists(string account_id)
        {
            return Accounts?.Any(x => x.Id == account_id);
        }

        public static AccountEntity Find(string account_id)
        {
            var account = Accounts?.Find(x => x.Id == account_id);

            if (account != null)
            {
                return account;
            }

            return new AccountEntity();
        }

        public static DepositResponse Deposit(DepositRequest request)
        {
            var account = Find(request.Destination);

            if (account.Id == null)
            {
                account = Create(request.Destination, request.Amount);
            }
            else
            {
                account.Balance = request.Amount;
            }

            if (Accounts == null)
            {
                Accounts = new List<AccountEntity>();
            }

            Accounts?.Add(account);

            var response = new DepositResponse
            {
                Destination = new AccountEntity
                {
                    Id = request.Destination,
                    Balance = GetBalance(request.Destination)
                }
            };

            return response;
        }

        public static WithdrawResponse Withdraw(WithdrawRequest request)
        {
            var account = Find(request.Origin);

            if (account.Id == null)
            {
                return new WithdrawResponse();
            }

            account.Balance -= request.Amount;
            Accounts?.Add(account); 

            var response = new WithdrawResponse
            {
                Origin = new AccountEntity
                {
                    Id = request.Origin,
                    Balance = GetBalance(request.Origin)
                }
            };

            return response;
        }

        public static TransferResponse Transfer(TransferRequest request)
        {
            var accountOrigin = Find(request.Origin);

            if (accountOrigin != null)
            {
                accountOrigin.Balance = -request.Amount;
                Accounts?.Add(accountOrigin);
            }

            var accountDestination = Find(request.Origin);

            if (accountDestination != null)
            {
                accountDestination.Balance = request.Amount;
                Accounts?.Add(accountDestination);
            }

            var response = new TransferResponse
            {
                Origin = new AccountEntity { Id = request.Origin, Balance = GetBalance(request.Origin) },
                Destination = new AccountEntity { Id = request.Destination, Balance = GetBalance(request.Destination) },
            };

            return response;
        }

        public static int GetBalance(string account_id)
        {
            var balance = Accounts?
                         .FindAll(x => x.Id == account_id)
                         .Sum(x => x.Balance);

            return balance.Value;
        }

    }
}
