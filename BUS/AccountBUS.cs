using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class AccountBUS
    {
        private static AccountBUS _instance;
        public static AccountBUS Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountBUS();
                return _instance;
            }
        }
        private AccountBUS() { }
        public bool CheckLogin(AccountDTO account)
        {
            if(account.UserName == null)
            {
                return false;
            }    
            if(account.Password == null)
            { 
                return false;
            }
            try
            {
                return AccountDAO.Instance.CheckLogin(account);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAllAccount()
        {
            try
            {
                return AccountDAO.Instance.GetAllAccount();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AccountDTO GetAccountByUserName(string UserName)
        {
            DataTable data;
            try
            {
                data = AccountDAO.Instance.GetAccountByUserName(UserName);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return new AccountDTO(data.Rows[0]);
        }
    }
}
