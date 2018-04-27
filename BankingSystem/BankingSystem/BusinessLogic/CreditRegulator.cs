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
                credit.credit_type.Sum = credit.credit_type.Sum - credit.Paid_sum;
                recommendedSum = (credit.credit_type.Sum * interestRate / 100) / 12 + monthPayment;
            }
            return recommendedSum;
        }

        public static void PayForCredit(bank_account account, int sumForPay, credit credit)
        {
            int sumTotal = Convert.ToInt32(account.Sum);
            int paidSum = Convert.ToInt32(credit.Paid_sum);
            if(sumTotal<sumForPay)
            {
                MessageBox.Show("You do not have enough money to pay your credit. Please selet another account");
            }
            else
            {
                if (sumForPay<recommendedSumForPay)
                {
                    MessageBox.Show("You can not pay less than the recommended amount. Please enter another sum for paid");
                }
                account.Sum = sumTotal - sumForPay;
                credit.Paid_sum = paidSum + sumForPay;
            }

        }


    }
}
