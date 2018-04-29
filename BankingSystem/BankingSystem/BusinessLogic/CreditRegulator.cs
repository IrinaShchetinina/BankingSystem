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
            int mouths = calculateCreditMouths(credit, false);
            double monthPayment = credit.credit_type.Sum / mouths; // ежемесяный платеж без учта процентов
            
            recommendedSum = Convert.ToDouble(((credit.credit_type.Sum - credit.Paid_sum) * credit.credit_type.Interest_rate / 100) / 12 + monthPayment);
      
            return Math.Round(recommendedSum, 1);
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
            idealCredit.Paid_sum = 0;
            int mouths = calculateCreditMouths(credit, true); //сколько месяцев прошло с момента открытия

            for (int mouth = 1; mouth <= mouths; mouth++) //считаем сколько должно быть заплачено
            {
                idealCredit.Paid_sum += CalculateRecommendedSumOfPayment(idealCredit);
            }
            if(credit.Paid_sum < idealCredit.Paid_sum)
            {
                debt = Convert.ToDouble(idealCredit.Paid_sum - credit.Paid_sum);
            }

            return Math.Round(debt, 1);
        }

        public static bool CheckImpositionOfFine(credit credit)
        {
            if ((credit.LastPenalty.Value.Month.CompareTo(DateTime.Now.Month) == 0) &&(credit.LastPenalty.Value.Year.CompareTo(DateTime.Now.Year) == 0))//в этом месяце штраф уже наложен
                return false;
            return true;
        }

        public static double ImposeAFine(credit credit, double debt)
        {
            double fine = 0;

            if(debt > 0)
            {
                fine = (debt / 100) * 5;
                credit.Paid_sum -= (debt / 100) * 5; //штраф за просрочку списывается с paid sum в размере 5 процентов от суммы долга
                credit.LastPenalty = DateTime.Now;
            }

            return Math.Round(fine, 1);
        }

        private static int calculateCreditMouths(credit credit, bool now)
        {
            int mouths = 0;
            DateTime tmp = credit.Opening_date;
            DateTime end;
            if (now)
                end = DateTime.Now.Date;
            else
                end = credit.Expiry_date;
            while (tmp < end)
            {
                mouths++;
                tmp = tmp.AddMonths(1);
            }
            return mouths;
        }
    }



}


