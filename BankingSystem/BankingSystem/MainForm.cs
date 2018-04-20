using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Connector con = new Connector();
            con.ConnectDBContext();
            user user = new user();
            user.Login = "111";
            user.Password = "111";
            user.Admin = false;
            con.AddUser(user);
            List<user> users = con.GetUsersToList();
        }
    }
}
