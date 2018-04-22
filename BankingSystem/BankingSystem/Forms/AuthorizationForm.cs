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
                        adminForm.Show();
                        this.Close();
                    }
                    else
                    {
                        UserForm userForm = new UserForm(userContext, user);
                        userForm.Show();
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Incorrect password!!!");
            }
            else
                MessageBox.Show("Incorrect login!!!");
        }
    }
}
