using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.Entity;

namespace BankingSystem
{
    public class Connector
    {

        private static bank_systemEntities dbContext;

        protected static void connectDBContext() //singletone
        {
            if (dbContext == null)
                dbContext = new bank_systemEntities();
        }

        protected List<user> getUsersToList()
        {
            return dbContext.user.ToList();
        }

        protected List<data_of_user> getUsersDataToList()
        {
            return dbContext.data_of_user.ToList();
        }

        protected List<bank_account> getBankAccountsToList()
        {
            return dbContext.bank_account.ToList();
        }

        protected List<bank_account> getBankAccountsToList(string userLogin)
        {
            return dbContext.bank_account.Where(a => a.User_login == userLogin).ToList();
        }

        protected List<bank_deposit> getBankDepositsToList(string userLogin)
        {
            return dbContext.bank_deposit.Where(d => d.bank_account.User_login == userLogin).ToList();
        }

        protected List<credit> getCreditsToList(string userLogin)
        {
            return dbContext.credit.Where(d => d.User_login == userLogin).ToList(); 
        }

        protected List<credit_type> getCreditTypesToList()
        {
            return dbContext.credit_type.ToList();
        }

        protected List<deposite_type> getDepositTypesToList()
        {
            return dbContext.deposite_type.ToList();
        }

        protected bool addUser(user user)
        {
            bool added = true;
            user foundUser = findUserByLogin(user.Login);
            if(foundUser!=null)
            {
                MessageBox.Show("This login already exist!");
                added = false;
            }
            try
            {
                dbContext.user.Add(user);
                dbContext.SaveChanges();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                added = false;
            }
            return added;
        }

        protected user findUserByLogin(string userLogin)
        {
            return dbContext.user.Where(l => l.Login == userLogin).FirstOrDefault(); //находим по логину или возвращаем null
        }

        protected deposite_type findDepositeTypeById(int id)
        {
            return dbContext.deposite_type.Where(dt => dt.id == id).FirstOrDefault(); //находим или возвращаем null
        }

        protected bank_deposit findDepositeByAccountId(int accountId)
        {
            return dbContext.bank_deposit.Where(d => d.Account_id == accountId).FirstOrDefault(); //находим или возвращаем null
        }

        protected data_of_user findUserDataByLogin(string userLogin)
        {
            return dbContext.data_of_user.Where(l => l.User_login == userLogin).FirstOrDefault(); //находим по логину или возвращаем null
        }

        protected void updateUser(user user) //the login is not changing
        {
            user foundUser = findUserByLogin(user.Login);
            if (foundUser != null) //если нашли
            {
                //изменить юзера
                //foundUser.Password = user.Password;
                //foundUser.Admin = user.Admin;
                // Обновить данные в БД с помощью Entity Framework
                try
                {
                    dbContext.Entry<user>(foundUser).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }
        }

        protected void deleteUser(user user)
        {
            try
            {
                dbContext.user.Remove(user);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected void deleteBankAccount(bank_account account)
        {
            try
            {
                dbContext.bank_account.Remove(account);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected void deleteBankDeposit(bank_deposit deposit)
        {
            try
            {
                dbContext.bank_deposit.Remove(deposit);
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
