using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public BindingList<bank_account> GetBankAccountsToBindingList(string userLogin)
        {
            BindingList<bank_account> bl = new BindingList<bank_account>(getBankAccountsToList(userLogin));
            return bl; 
        }

        public BindingList<bank_deposit> GetBankDepositsToBindingList(string userLogin)
        {
            BindingList<bank_deposit> bl = new BindingList<bank_deposit>(getBankDepositsToList(userLogin));
            return bl;
        }

        public BindingList<credit> GetCreditsToBindingList(string userLogin)
        {
            BindingList<credit> bl = new BindingList<credit>(getCreditsToList(userLogin));
            return bl;
        }

        public BindingList<credit_type> GetCreditTypesToBindingList()
        {
            BindingList<credit_type> bl = new BindingList<credit_type>(getCreditTypesToList());
            return bl;
        }

        public BindingList<deposite_type> GetDepositTypesToBindingList()
        {
            BindingList<deposite_type> bl = new BindingList<deposite_type>(getDepositTypesToList());
            return bl;
        }

        public bool AddUser(user user)
        {
            return addUser(user);
        }

        public user FindUserByLogin(string userLogin)
        {
            return findUserByLogin(userLogin);
        }

        public deposite_type FindDepositeTypeById(int id)
        {
            return findDepositeTypeById(id);
        }

        public data_of_user FindUserDataByLogin(string userLogin)
        {
            return findUserDataByLogin(userLogin);
        }

        public bank_deposit FindDepositeByAccountId(int accountId)
        {
            return findDepositeByAccountId(accountId);
        }

        public void UpdateUser(user user) //the login is not changing
        {
            updateUser(user);
        }

        public void DeleteUser(user user)
        {
            deleteUser(user);
        }

        public void DeleteBankAccount(bank_account account)
        {
            deleteBankAccount(account);
        }

        public void DeleteBankDeposit(bank_deposit deposit)
        {
            deleteBankDeposit(deposit);
        }
    }
}
