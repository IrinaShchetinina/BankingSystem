using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem.Forms
{
    public partial class InfoAboutDepositForm : Form
    {
        bank_deposit selectedDeposit;

        public InfoAboutDepositForm(bank_deposit selectedDeposit)
        {
            this.selectedDeposit = selectedDeposit;
            InitializeComponent();
        }

        private void InfoAboutDepositForm_Load(object sender, EventArgs e)
        {
            labelAccountNumber.Text = selectedDeposit.bank_account.Number.ToString();
            labelAccountSum.Text = selectedDeposit.bank_account.Sum.ToString();
            labelOpeningDate.Text = selectedDeposit.Opening_date.ToString();
            labelExpiryDate.Text = selectedDeposit.Expiry_date.ToString();
            labelStartSum.Text = selectedDeposit.Start_sum.ToString();
            labelTerm.Text = selectedDeposit.deposite_type.Term.ToString();
            labelInterestRate.Text = selectedDeposit.deposite_type.Interest_rate.ToString();
            labelCapitalisation.Text = selectedDeposit.deposite_type.Capitalization ? "yes" : "no";
            labelEarlyClosure.Text = selectedDeposit.deposite_type.Early_closure ? "yes" : "no";
        }
    }
}
