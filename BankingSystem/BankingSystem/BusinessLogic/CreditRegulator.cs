using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.BusinessLogic
{
    class CreditRegulator
    {

        public int recommendedSumOfDebt(bank_account account, credit_type typeCredit, credit credit) // рекомендуемая сумма долга
        {
            int recommendedSum = 0;
            int sumOfDebt = typeCredit.Sum;
            double interestRate = typeCredit.Interest_rate;
            int timeOfcredit = 6; //Convert.ToInt32((credit.Expiry_date - credit.Opening_date).TotalDays / 30); Не знаю как посчитать количество месяцев
            int monthPayment = sumOfDebt / timeOfcredit; // ежемесяный платеж без учта процентов
            if (credit.Paid_sum == 0 || credit.Paid_sum == null)
            {
                return recommendedSum = Convert.ToInt32((sumOfDebt * interestRate / 100) / 12 + monthPayment);
            }
            else
            {
                sumOfDebt = typeCredit.Sum - credit.Paid_sum.Value;
                return recommendedSum = Convert.ToInt32((sumOfDebt * interestRate / 100) / 12 + monthPayment);
            }
        }

    }
}
