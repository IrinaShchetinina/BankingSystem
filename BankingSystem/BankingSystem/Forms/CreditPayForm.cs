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
    public partial class CreditPayForm : Form
    {

        public CreditPayForm(object[] accounts, double debt, double recommendedPay, double fullyRepaySum)
        {
            InitializeComponent();
            comboBoxFrom.Items.AddRange(accounts);
            labelDebt.Text = debt.ToString();
            labelRecommmendedSum.Text = recommendedPay.ToString();
            labelFullyReplaySum.Text = fullyRepaySum.ToString();
        }
    }
}
