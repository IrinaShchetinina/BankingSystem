using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class UserContext : Connector
    {
        private static UserContext userContext;

        public static UserContext GetUserContext() //singletone
        {
            if (userContext == null)
                userContext = new UserContext();
            return userContext;
        }

        private UserContext()
        {
            connectDBContext();
        }

        public List<user> GetUsersToList()
        {
            return getUsersToList();
        }

        public List<data_of_user> GetUsersDataToList()
        {
            return getUsersDataToList();
        }

        public List<bank_account> GetBankAccountsToList(string userLogin)
        {
            return getBankAccountsToList(userLogin); ;
        }

        public List<bank_deposit> GetBankDepositsToList(string userLogin)
        {
            return getBankDepositsToList(userLogin);
        }

        public List<credit> GetCreditsToList()
        {
            return getCreditsToList();
        }

        public List<credit_type> GetCreditTypesToList()
        {
            return getCreditTypesToList();
        }

        public List<deposite_type> GetDepositTypesToList()
        {
            return getDepositTypesToList();
        }

        public bool AddUser(user user)
        {
            return addUser(user);
        }

        public user FindUserByLogin(string userLogin)
        {
            return findUserByLogin(userLogin);
        }

        public data_of_user FindUserDataByLogin(string userLogin)
        {
            return findUserDataByLogin(userLogin);
        }

        public void UpdateUser(user user) //the login is not changing
        {
            updateUser(user);
        }

        public void DeleteUser(user user)
        {
            deleteUser(user);
        }
    }
}
