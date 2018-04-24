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
    public partial class MoneyTransferForm : Form
    {
        public MoneyTransferForm(object[] userAccounts, bool toAnotherUsersAccount)
        {
            InitializeComponent();
            comboBoxFrom.Items.AddRange(userAccounts);
            if(toAnotherUsersAccount)
            {
                comboBoxTo.Visible = false;
                textBoxToAccount.Visible = true;
            }
            else
                comboBoxTo.Items.AddRange(userAccounts);
        }
    }
}
