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
    public partial class AdministratorForm : Form
    {
        UserContext userContext;
        user user;

        public AdministratorForm(UserContext userContext, user user)
        {
            InitializeComponent();
            this.userContext = userContext;
            this.user = user;
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            labelSurname.Text = user.data_of_user.Surname;
            labelName.Text = user.data_of_user.Name;
            labelPatronymic.Text = user.data_of_user.Patronymic;
            labelPassSer.Text = user.data_of_user.Passport_series;
            labelPassNum.Text = user.data_of_user.Passport_number;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            user createdUser = new user();
            data_of_user userData = new data_of_user();

            createdUser.Login = textBoxLogin.Text.Trim();
            createdUser.data_of_user = userData;
            userData.user = createdUser;
            createdUser.Admin = Convert.ToBoolean(checkBoxAdmin.CheckState);
            userData.Surname = textBoxSurname.Text.Trim();
            userData.Name = textBoxName.Text.Trim();
            userData.Patronymic = textBoxPatronymic.Text.Trim();
            userData.Passport_series = textBoxPassSer.Text.Trim();
            userData.Passport_number = textBoxPassNum.Text.Trim();
            

            UserCreatingForm creatingForm = new UserCreatingForm(createdUser);

            if(creatingForm.ShowDialog() == DialogResult.OK)
            {
                PasswordForm passForm = new PasswordForm(createdUser.Login);
                if(passForm.ShowDialog() == DialogResult.OK)
                {
                    string pass = passForm.textBoxPassword.Text.Trim();
                    if (pass != null)
                    {
                        createdUser.Password = pass;
                        if(userContext.AddUser(createdUser))
                        textBoxLogin.Clear();
                        checkBoxAdmin.CheckState = CheckState.Unchecked;
                        textBoxSurname.Clear();
                        textBoxName.Clear();
                        textBoxPatronymic.Clear();
                        textBoxPassSer.Clear();
                        textBoxPassNum.Clear();
                        MessageBox.Show("User added!");
                    }
                    else
                        MessageBox.Show("A password is not entered!!! User addition canceled!");
                }
                else
                    MessageBox.Show("User addition canceled!");
            }
        }
    }
}
