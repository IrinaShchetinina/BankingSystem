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

        internal static bool TransferMoney(bank_account accountFrom, bank_account accountTo, int sum)
        {
            if(accountFrom.Number != accountTo.Number)
            {
                if (accountFrom.bank_deposit == null && accountTo.bank_deposit == null)
                {
                    if(accountFrom.Sum >= sum)
                    {
                        accountFrom.Sum -= sum;
                        accountTo.Sum += sum;
                        return true;
                    }
                    else
                        MessageBox.Show("There is not enough money in the write-off account!");
                }
                else
                    MessageBox.Show("This account is deposit!!! Transfer is not possible while the deposit is not closed!");
            }
            else
                MessageBox.Show("The same account is selected!");
            return false;
        }
    }
}
