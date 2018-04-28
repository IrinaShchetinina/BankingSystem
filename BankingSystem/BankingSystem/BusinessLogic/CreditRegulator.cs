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
                recommendedSum = (credit.credit_type.Sum * credit.credit_type.Interest_rate / 100) / 12 + monthPayment;
            }
            else
            {
                var newCreditSum = credit.credit_type.Sum - credit.Paid_sum;
                recommendedSum = Convert.ToDouble((newCreditSum * credit.credit_type.Interest_rate / 100) / 12 + monthPayment);
            }
            return recommendedSum;
        }

        public static void PayForCredit(bank_account account, double sumForPay, credit credit)
        {
            if(account.Sum < sumForPay)
            {
                MessageBox.Show("You do not have enough money to pay your credit! Please selet another account!");
                return;
            }
            else if(sumForPay > credit.credit_type.Sum)
            {
                MessageBox.Show("You enter sum which is more than credit sum! Please enter another sum!");
                return;
            }
                account.Sum -= sumForPay;
                credit.Paid_sum += sumForPay;   
        }

        public static double CalculateSumForEarlyPayment(credit credit)
        {
            double sumForEarlyPayment = 0;
            return sumForEarlyPayment = Convert.ToDouble(((credit.credit_type.Sum - credit.Paid_sum) * credit.credit_type.Interest_rate / 100) / 12 + (credit.credit_type.Sum - credit.Paid_sum));
        }
    }



}


