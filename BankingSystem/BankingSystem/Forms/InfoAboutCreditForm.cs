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
    public partial class InfoAboutCreditForm : Form
    {
        private credit selectedCredit;

        public InfoAboutCreditForm(credit selectedCredit)
        {
            InitializeComponent();
            this.selectedCredit = selectedCredit;
        }

        private void InfoAboutCreditForm_Load(object sender, EventArgs e)
        {
            labelOpeningDate.Text = selectedCredit.Opening_date.Date.ToShortDateString().ToString();
            labelExpiryDate.Text = selectedCredit.Expiry_date.ToShortDateString().ToString();
            labelPaidSum.Text = selectedCredit.Paid_sum.ToString();
            labelInterestRate.Text = selectedCredit.credit_type.Interest_rate.ToString();
            labelSum.Text = selectedCredit.credit_type.Sum.ToString();
        }
    }
}
