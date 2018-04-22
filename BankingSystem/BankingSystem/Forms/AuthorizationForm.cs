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
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private UserContext userContext;
        private user user;

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            userContext = UserContext.GetUserContext();
            this.FormClosed += exit;
        }

        private void AuthorizeButton_Click(object sender, EventArgs e)
        {
            user = userContext.FindUserByLogin(LoginTextBox.Text.Trim());
            if (user != null)
            {
                if (PasswordTextBox.Text.Trim() == user.Password)
                {
                    if (user.Admin)
                    {
                        AdministratorForm adminForm = new AdministratorForm(userContext, user);
                        adminForm.FormClosed += checkedFormClosed;
                        adminForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        UserForm userForm = new UserForm(userContext, user);
                        userForm.FormClosed += checkedFormClosed;
                        userForm.Show();
                        this.Hide();
                    }
                }
                else
                    MessageBox.Show("Incorrect password!!!");
            }
            else
                MessageBox.Show("Incorrect login!!!");
        }

        private void checkedFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void exit(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
