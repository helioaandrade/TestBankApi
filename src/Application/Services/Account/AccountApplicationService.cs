using BankApi.Application.Dtos.Account;
using BankApi.Domain.Entities;
using BankApi.Domain.Services;
 
namespace BankApi.Application.Services.Account
{
    public class AccountApplicationService : IAccountApplicationService
    {

        private readonly IAccountDomainService _accountDomainService;
        public AccountApplicationService(IAccountDomainService accountDomainService)
        {
            _accountDomainService = accountDomainService;
        }

        public void Reset()
        {
            _accountDomainService.Reset();
        }

        public AccountEntity GetAccount(string account_id)
        {
            return _accountDomainService.GetAccount(account_id);
        }

        public int GetBalance(string account_id)
        {
            return _accountDomainService.GetBalance(account_id);
        }
 
        public dynamic SendEvent(EventEntity entity)
        {
            dynamic result = null;

            switch (entity.Type.ToLower())
            {
                case "deposit":

                    result = _accountDomainService
                             .Deposit(new DepositRequest
                             {
                                 Destination = entity.Destination,
                                 Amount = entity.Amount
                             });
                    break;

                case "transfer":

                    result = _accountDomainService
                             .Transfer(new TransferRequest
                             {
                                 Origin = entity.Origin,
                                 Destination = entity.Destination,
                                 Amount = entity.Amount
                             });

                    break;

                case "withdraw":

                    result = _accountDomainService
                            .Withdraw(new WithdrawRequest
                            {
                                Origin = entity.Origin,
                                Amount = entity.Amount
                            });

                    break;


            }

            return result;
        }

      
    }
}
