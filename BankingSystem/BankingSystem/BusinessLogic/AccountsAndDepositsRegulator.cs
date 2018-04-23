using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.BusinessLogic
{
    public static class AccountsAndDepositsRegulator
    {
        public static bank_account GenerateNewAccount()
        {
            bank_account newAccount = new bank_account();
            newAccount.Number = DateTime.Now.ToString("yyyyMMddHHmmssffffff");
            newAccount.Sum = 0;
            return newAccount;
        }
    }
}
