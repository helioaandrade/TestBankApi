using System.ComponentModel;

namespace BankApi.Domain.Common
{
    public class Enumerators
    {
        public enum EventType
        {
            [Description("Deposit")]
            Deposit = 0,

            [Description("Withdraw")]
            Withdraw = 1,

            [Description("Transfer")]
            Transfer = 2
        }
    }
}
