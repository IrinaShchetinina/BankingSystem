﻿using System;
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

        internal static bank_account OpenDeposite(deposite_type depositeType, bank_account accountFrom, double sum)
        {
            if(accountFrom.bank_deposit == null)
            {
                if (accountFrom.Sum >= sum)
                {
                    accountFrom.Sum -= sum;
                    bank_deposit newDeposit = new bank_deposit();
                    bank_account newAccount = GenerateNewAccount();
                    newAccount.Sum = sum;
                    newAccount.bank_deposit = newDeposit;
                    newDeposit.Account_id = newAccount.id;
                    newDeposit.bank_account = newAccount;
                    newDeposit.deposite_type = depositeType;
                    newDeposit.Opening_date = DateTime.Now.Date;
                    newDeposit.Expiry_date = newDeposit.Opening_date.AddMonths(depositeType.Term);
                    newDeposit.Start_sum = sum;
                    return newAccount;
                }
                else
                    MessageBox.Show("This account is deposit!!!Transfer is not possible while the deposit is not closed!");
            }
            else
                MessageBox.Show("There is not enough money in the write-off account!");

            return null;
        }

        internal static bool InterestAccrual(bank_deposit deposit) //возвращает истёк ли срок
        {
            bool expired = false;
            var total = deposit.bank_account.Sum;
            double amountOfaccrual = 0;
            double sumStart = 0; //от чего начисляем проценты

            int mouths = 0; //сколько месяцев прошло с момента открытия
            sumStart = deposit.Start_sum;
            if (deposit.Expiry_date.CompareTo(DateTime.Now.Date) <= 0)
            {
                mouths = deposit.deposite_type.Term;
                expired = true;
            }
            else
            {
                DateTime tmp = deposit.Opening_date;
                while (tmp < DateTime.Now.Date)
                {
                    mouths++;
                    tmp = tmp.AddMonths(1);
                }
            }

            if (deposit.deposite_type.Capitalization)
            {
                int mouth; //месяц с момента открытия
                for(mouth = 1; mouth <= mouths; mouth++) //начислить проценты за каждый месяц
                {
                    amountOfaccrual += (sumStart / 100) * (deposit.deposite_type.Interest_rate / 12);
                    sumStart += amountOfaccrual;
                }
            }
            else
            {
                amountOfaccrual = (sumStart / 100) * (deposit.deposite_type.Interest_rate / 12) * mouths;
            }
            total += amountOfaccrual;
            deposit.bank_account.Sum = total;
            return expired;
        }

        internal static bool CloseDepositCheck(bank_deposit closingDeposit)
        {
            if((closingDeposit.deposite_type.Early_closure) | (closingDeposit.Expiry_date.CompareTo(DateTime.Now.Date) <= 0))
            {
                return true;
            }
            return false;
        }
    }
}
