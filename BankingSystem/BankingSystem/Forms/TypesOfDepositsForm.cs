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
    public partial class TypesOfDepositsForm : Form
    {
        public TypesOfDepositsForm(BindingList<deposite_type> types, object[] userAccounts)
        {
            InitializeComponent();
            comboBoxFrom.Items.AddRange(userAccounts);
            dataGridViewTypesOfDeposits.DataSource = types;
            dataGridViewTypesOfDeposits.Columns[0].Visible = false;
            dataGridViewTypesOfDeposits.Columns[5].Visible = false;
        }
    }
}
