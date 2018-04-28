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

        public static double CalculateRecommendedSumOfPayment(credit credit) // рекомендуемая сумма платежа
        {
            double recommendedSum = 0;
            int mouths = calculateCreditMouths(credit);
            double monthPayment = credit.credit_type.Sum / mouths; // ежемесяный платеж без учта процентов

            if (credit.Paid_sum == 0)
            {
                recommendedSum = (credit.credit_type.Sum * credit.credit_type.Interest_rate / 100) / 12 + monthPayment;
            }
            else
            {
                var newDebtSum = credit.credit_type.Sum - credit.Paid_sum;
                recommendedSum = Convert.ToDouble((newDebtSum * credit.credit_type.Interest_rate / 100) / 12 + monthPayment);
            }
            return recommendedSum;
        }

        public static bool PayForCredit(bank_account account, double sumForPay, credit credit)
        {
            bool payment = false;
            if(account.Sum < sumForPay)
            {
                MessageBox.Show("You do not have enough money to pay your credit! Please selet another account!");
            }
            else if(sumForPay > credit.credit_type.Sum)
            {
                MessageBox.Show("You enter sum which is more than credit sum! Please enter another sum!");
            }
            else
            {
                account.Sum -= sumForPay;
                credit.Paid_sum += sumForPay;
                MessageBox.Show("The payment is successfully completed!");
                payment = true;
            }
            return payment;
        }

        public static double CalculateSumForEarlyPayment(credit credit)
        {
            var sumForEarlyPayment = ((credit.credit_type.Sum - credit.Paid_sum) * credit.credit_type.Interest_rate / 100) / 12 + (credit.credit_type.Sum - credit.Paid_sum);
            return Convert.ToDouble(sumForEarlyPayment); 
        }

        public static double СalculateDebt(credit credit) 
        {
            double debt = 0; //долг
            credit idealCredit = new credit(); //идеальный кедит, его paid_sum = сколько должно быть заплачено на данный момент
            idealCredit.credit_type = credit.credit_type;
            idealCredit.Opening_date = credit.Opening_date;
            idealCredit.Expiry_date = credit.Expiry_date;
            int mouths = calculateCreditMouths(credit); //сколько месяцев прошло с момента открытия

            for (int mouth = 1; mouth <= mouths; mouth++) //считаем сколько должно быть заплачено
            {
                idealCredit.Paid_sum += CalculateRecommendedSumOfPayment(idealCredit);
            }
            if(credit.Paid_sum < idealCredit.Paid_sum)
            {
                debt = Convert.ToDouble(idealCredit.Paid_sum - credit.Paid_sum);
                credit.Paid_sum -= (debt / 100) * 5; //штраф за просрочку списывается с paid sum в размере 5 прицентов от суммы долга
            }

            return debt;
        }

        private static int calculateCreditMouths(credit credit)
        {
            int mouths = 0;
            DateTime tmp = credit.Opening_date;
            while (tmp < DateTime.Now.Date)
            {
                mouths++;
                tmp = tmp.AddMonths(1);
            }
            return mouths;
        }
    }



}


