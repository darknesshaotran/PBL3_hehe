using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO _instance;
        public static AccountDAO Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccountDAO();
                return _instance;
            }
        }
        
        public bool CheckLogin(AccountDTO account)
        {
            string query = "USP_Login @UserName , @PassWord";
            DataTable result = new DataTable();
            try
            {
                result = DataProvider.Instance.ExecuteQuery(query, new object[] {account.UserName, account.Password});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result.Rows.Count > 0;
        }
        public DataTable GetAllAccount()
        {
            try
            {
                return DataProvider.Instance.ExecuteQuery("USP_GetAllAccount");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public DataTable GetAccountByUserName(string UserName)
        {
            string query = "USP_GetAccountByUserName @UserName";
            try
            {
                return DataProvider.Instance.ExecuteQuery(query, new Object[] {UserName});
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
