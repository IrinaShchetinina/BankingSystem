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
            dataGridViewDeposits.Columns[2].Visible = false;
            dataGridViewDeposits.Columns[5].Visible = false;
            dataGridViewDeposits.Columns[6].Visible = false;
        }

        private void buttonOpenAccount_Click(object sender, EventArgs e)
        {
            bank_account newAccount = AccountsAndDepositsRegulator.GenerateNewAccount();
            newAccount.user = user;
            user.bank_account.Add(newAccount);
            userContext.UpdateUser(user);
            MessageBox.Show("The account added!");
        }

        private void buttonCloseAccount_Click(object sender, EventArgs e)
        {
            if (dataGridViewAccounts.SelectedRows.Count > 0)
            {
                int selectedAccountId = Convert.ToInt32(dataGridViewAccounts.SelectedRows[0].Cells[0].Value);
                bank_account deletingAccount = user.bank_account.Where(a => a.id == selectedAccountId).First();

                if (AccountsAndDepositsRegulator.DeleteAccountCheck(deletingAccount))
                {
                    userContext.DeleteBankAccount(deletingAccount);
                    userContext.UpdateUser(user);
                    MessageBox.Show("The account is deleted!");
                }
            }
            else
                MessageBox.Show("Account is not selected!");
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            MoneyTransferForm transferForm = new MoneyTransferForm(user.bank_account.Select(a => a.Number).ToArray(), false);
            if(transferForm.ShowDialog() == DialogResult.OK)
            {
                string numberAccountFrom = transferForm.comboBoxFrom.Text;
                string numberAccountTo = transferForm.comboBoxTo.Text;

                int sum;

                if (numberAccountFrom != null && numberAccountTo != null)
                {
                    if(transferForm.textBoxSum != null && int.TryParse(transferForm.textBoxSum.Text, out sum))
                    {
                        bank_account accountFrom = user.bank_account.Where(a => a.Number == numberAccountFrom).First();
                        bank_account accountTo = user.bank_account.Where(a => a.Number == numberAccountTo).First();

                        if(AccountsAndDepositsRegulator.TransferMoney(accountFrom, accountTo, sum))
                        {
                            userContext.UpdateUser(user);
                            MessageBox.Show("The money was transferred!");
                        }
                    }
                    else
                        MessageBox.Show("The entered sum is incorrect!");
                }
                else
                    MessageBox.Show("The account is not selected!");   
            }
        }

        private void buttonOpenDeposit_Click(object sender, EventArgs e)
        {
            BindingList<deposite_type> types = userContext.GetDepositTypesToBindingList();
            TypesOfDepositsForm typesFotm = new TypesOfDepositsForm(types, user.bank_account.Select(a => a.Number).ToArray());
            if(typesFotm.ShowDialog() == DialogResult.OK)
            {
                int sum;
                if (typesFotm.textBoxSum != null && int.TryParse(typesFotm.textBoxSum.Text, out sum))
                {
                    string numberAccountFrom = typesFotm.comboBoxFrom.Text;
                    if (numberAccountFrom != null)
                    {
                        bank_account accountFrom = user.bank_account.Where(a => a.Number == numberAccountFrom).First();
                        int depositTypeId = Convert.ToInt32(typesFotm.dataGridViewTypesOfDeposits.SelectedRows[0].Cells[0].Value);
                        deposite_type depositType = userContext.FindDepositeTypeById(depositTypeId);
                        bank_account depositAccount = AccountsAndDepositsRegulator.OpenDeposite(depositType, accountFrom, sum);
                        if (depositAccount != null)
                        {
                            depositAccount.user = user;
                            user.bank_account.Add(depositAccount);
                            userContext.UpdateUser(user);
                            dataGridViewDeposits.DataSource = userContext.GetBankDepositsToBindingList(user.Login);
                            MessageBox.Show("Deposit is opened!");
                        }   
                    }
                    else
                        MessageBox.Show("The account is not selected!");
                }
                else
                    MessageBox.Show("The entered sum is incorrect!");
            }
        }

        private void buttonCloseDeposit_Click(object sender, EventArgs e)
        {
            if (dataGridViewDeposits.SelectedRows.Count > 0)
            {
                int selectedDepositAccountId = Convert.ToInt32(dataGridViewDeposits.SelectedRows[0].Cells[0].Value);
                bank_deposit closingDeposit = userContext.FindDepositeByAccountId(selectedDepositAccountId);
                if(AccountsAndDepositsRegulator.CloseDepositCheck(closingDeposit))
                {
                    userContext.DeleteBankDeposit(closingDeposit);
                    dataGridViewDeposits.DataSource = userContext.GetBankDepositsToBindingList(user.Login);
                    MessageBox.Show("Deposit is not selected!");
                }
                else
                    MessageBox.Show("A deposit without the possibility of early closure can not be closed until the expiration date!");
            }
            else
                MessageBox.Show("Deposit is closed!");

        }
    }
}
