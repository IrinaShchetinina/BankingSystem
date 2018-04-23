using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static bool DeleteAccountCheck(bank_account account)
        {
            if (account.bank_deposit == null)
            {
                if(account.Sum == 0)
                {
                    return true;
                }
                else
                    MessageBox.Show("This account balance is not zero!!! Deletion is not possible while the balance of the account is not zero!");
            }
            else
                MessageBox.Show("This account is deposit!!! Deletion is not possible while the deposit is not closed!");
            return false;
        }
    }
}
