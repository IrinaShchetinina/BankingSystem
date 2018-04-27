using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem.BusinessLogic
{
    class CreditRegulator
    {

       private int recommendedSumForPay;
        public int recommendedSumOfDebt(bank_account account, credit_type typeCredit, credit credit) // рекомендуемая сумма долга
        {
            int recommendedSum = 0;
            int sumOfDebt = typeCredit.Sum;
            double interestRate = typeCredit.Interest_rate;
            int timeOfcredit = 6; //Convert.ToInt32((credit.Expiry_date - credit.Opening_date).TotalDays / 30); Не знаю как посчитать количество месяцев
            int monthPayment = sumOfDebt / timeOfcredit; // ежемесяный платеж без учта процентов
            if (credit.Paid_sum == 0 || credit.Paid_sum == null)
            {
                recommendedSum = Convert.ToInt32((sumOfDebt * interestRate / 100) / 12 + monthPayment);
                recommendedSumForPay = recommendedSum;
                return recommendedSumForPay;
            }
            else
            {
                sumOfDebt = typeCredit.Sum - credit.Paid_sum.Value;
                recommendedSum = Convert.ToInt32((sumOfDebt * interestRate / 100) / 12 + monthPayment);
                recommendedSumForPay = recommendedSum;
                return recommendedSumForPay;
            }
        }

        public void PayForCredit(bank_account sum, int sumForPay, credit paid)
        {
            int sumTotal = Convert.ToInt32(sum.Sum);
            int paidSum = Convert.ToInt32(paid.Paid_sum);
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
                sum.Sum = sumTotal - sumForPay;
                paid.Paid_sum = paidSum + sumForPay;
            }

        }


    }
}
