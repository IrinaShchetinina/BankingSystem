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
    public partial class UserCreatingForm : Form
    {
        user createdUser;

        public UserCreatingForm(user user)
        {
            InitializeComponent();

            createdUser = user;
            labelLogin.Text = createdUser.Login;
            labelSurname.Text = createdUser.data_of_user.Surname;
            labelName.Text = createdUser.data_of_user.Name;
            labelPatronymic.Text = createdUser.data_of_user.Patronymic;
            labelPassSer.Text = createdUser.data_of_user.Passport_series;
            labelPassNum.Text = createdUser.data_of_user.Passport_number;
            labelAdmin.Text = createdUser.Admin ? "yes" : "no";
        }
    }
}
