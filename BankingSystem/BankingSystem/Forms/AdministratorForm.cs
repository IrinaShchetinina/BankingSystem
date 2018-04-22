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
            this.user.data_of_user = userContext.FindUserDataByLogin(user.Login);
        }

        private void AdministratorForm_Load(object sender, EventArgs e)
        {
            tabControl.TabPages["tabPagePersonalData"].Controls["labelSurname"].Text = user.data_of_user.Surname;
            tabControl.TabPages["tabPagePersonalData"].Controls["labelName"].Text = user.data_of_user.Name;
            tabControl.TabPages["tabPagePersonalData"].Controls["labelPatronymic"].Text = user.data_of_user.Patronymic;
            tabControl.TabPages["tabPagePersonalData"].Controls["labelPassSer"].Text = user.data_of_user.Passport_series;
            tabControl.TabPages["tabPagePersonalData"].Controls["labelPassNum"].Text = user.data_of_user.Passport_number;
        }
    }
}
