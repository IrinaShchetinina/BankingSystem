using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace BankingSystem
{
    class Connector
    {

        private static bank_systemEntities dbContext;

        public void ConnectDBContext() //singletone
        {
            if (dbContext == null)
                dbContext = new bank_systemEntities();
        }

        public List<user> GetUsersToList()
        {
            return dbContext.user.ToList();
        }

        public List<data_of_user> GetUsersDataToList()
        {
            return dbContext.data_of_user.ToList();
        }

        public List<bank_account> GetBankAccountsToList()
        {
            return dbContext.bank_account.ToList();
        }

        public List<bank_deposit> GetBankDepositsToList()
        {
            return dbContext.bank_deposit.ToList();
        }

        public List<credit> GetCreditsToList()
        {
            return dbContext.credit.ToList();
        }

        public List<credit_type> GetCreditTypesToList()
        {
            return dbContext.credit_type.ToList();
        }

        public List<deposite_type> GetDepositTypesToList()
        {
            return dbContext.deposite_type.ToList();
        }

        public void AddUser(user user)
        {
            try
            {
                dbContext.user.Add(user);
            }
            catch(MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
