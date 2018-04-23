using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankingSystem.BusinessLogic;

namespace BankingSystem.Forms
{
    public partial class UserForm : Form
    {
        UserContext userContext;
        user user;

        public UserForm(UserContext userContext, user user)
        {
            InitializeComponent();
            this.userContext = userContext;
            this.user = user;
            //this.user.data_of_user = userContext.FindUserDataByLogin(user.Login);
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            labelSurname.Text = user.data_of_user.Surname;
            labelName.Text = user.data_of_user.Name;
            labelPatronymic.Text = user.data_of_user.Patronymic;
            labelPassSer.Text = user.data_of_user.Passport_series;
            labelPassNum.Text = user.data_of_user.Passport_number;

            user.bank_account = userContext.GetBankAccountsToBindingList(user.Login);
            
            dataGridViewAccounts.DataSource = user.bank_account;
            dataGridViewAccounts.Columns[0].Visible = false;
            dataGridViewAccounts.Columns[2].Visible = false;
            dataGridViewAccounts.Columns[4].Visible = false;
            dataGridViewAccounts.Columns[5].Visible = false;

            dataGridViewDeposits.DataSource = userContext.GetBankDepositsToBindingList(user.Login);
            dataGridViewDeposits.Columns[0].Visible = false;
            dataGridViewDeposits.Columns[1].Visible = false;
            dataGridViewDeposits.Columns[4].Visible = false;
            dataGridViewDeposits.Columns[5].Visible = false;
        }

        private void buttonOpenAccount_Click(object sender, EventArgs e)
        {
            bank_account newAccount = AccountsAndDepositsRegulator.GenerateNewAccount();
            newAccount.user = user;
            user.bank_account.Add(newAccount);
            userContext.UpdateUser(user);
            MessageBox.Show("The account added!");
        }
    }
}
