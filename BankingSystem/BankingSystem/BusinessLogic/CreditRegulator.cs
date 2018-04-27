using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem.BusinessLogic
{
    public static class CreditRegulator
    {

        public static double CalculateRecommendedSumOfDebt(bank_account account, credit credit) // рекомендуемая сумма долга
        {
            double recommendedSum = 0;
            double interestRate = credit.credit_type.Interest_rate;
            int mouths = 0;
            DateTime tmp = credit.Opening_date;
            while (tmp < credit.Expiry_date)
            {
                mouths++;
                tmp = tmp.AddMonths(1);
            }
            double monthPayment = credit.credit_type.Sum / mouths; // ежемесяный платеж без учта процентов
            if (credit.Paid_sum == 0)
            {
                recommendedSum = (credit.credit_type.Sum * interestRate / 100) / 12 + monthPayment;
            }
            else
            {
                var newCreditSum = credit.credit_type.Sum - credit.Paid_sum;
                recommendedSum = Convert.ToDouble((newCreditSum * interestRate / 100) / 12 + monthPayment);
            }
            return recommendedSum;
        }

        public static void CheckPayForCredit(bank_account account, int sumForPay, credit credit)
        {
            var paidSum = credit.Paid_sum;
            if(account.Sum < sumForPay)
            {
                MessageBox.Show("You do not have enough money to pay your credit. Please selet another account");
                return;
            }
            else if(sumForPay==credit.credit_type.Sum)
            {
                MessageBox.Show("You enter sum which is equal your credit sum. If you want to do early payment for credit, please select option for early payment");
                return;
            }
            else if(sumForPay>credit.credit_type.Sum)
            {
                MessageBox.Show("You enter sum which is more than credit sum. Please enter another sum");
                return;
            }
                account.Sum = account.Sum - sumForPay;
                credit.Paid_sum = credit.Paid_sum + sumForPay;
            
        }
        public static double SumForEarlyPayment(credit credit)
        {
            double sumForEarlyPayment = 0;
            return sumForEarlyPayment = Convert.ToDouble(((credit.credit_type.Sum - credit.Paid_sum) * credit.credit_type.Interest_rate / 100) / 12 + (credit.credit_type.Sum - credit.Paid_sum));
        }

    }



}


