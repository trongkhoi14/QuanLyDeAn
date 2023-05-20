using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyDeAn.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            set => instance = value;
        }

        private AccountDAO() { }


        public bool Login(string userName, string passWord)
        {
            
            try
            {
                string connectionSTR = @"DATA SOURCE=localhost:1521/xe; USER ID="+ userName + ";PASSWORD="+ passWord;
                    
                DataProvider.Instance.SetConnectionString(connectionSTR);
            }
            catch (Exception ex)
            {
                return false;
            }
                
            return true;
               
            
        }

        public DataTable GetListUser()
        {
            
            return DataProvider.Instance.ExecuteQuery(@"SELECT 
                                                            USERNAME,
                                                            USER_ID,
                                                            ACCOUNT_STATUS ,
                                                            CREATED,
                                                            EXPIRY_DATE,
                                                            LAST_LOGIN AS,
                                                            PASSWORD_CHANGE_DATE
                                                        FROM DBA_USERS 
                                                        ORDER BY created DESC");
        }

        public bool CreateUser(string username, string password)
        {
            // Tìm xem có tài khoản hay chưa, nếu đã có thì truy vấn trả về số dòng > 0 
            string query = string.Format("SELECT * FROM ALL_USERS WHERE USERNAME = '{0}'", username);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if(result.Rows.Count > 0)
            {
                return false;
            }
            DataProvider.Instance.ExecuteOracleProcedure("sp_addUser", new OracleParameter("username", username), new OracleParameter("password", password));
            return true;
        }

        public bool DeleteUser(string username)
        {
            // Tìm xem tồn tại tài khoản này không, nếu không (số dòng trả về = 0) thì không thể xóa user
            string query = string.Format("SELECT * FROM ALL_USERS WHERE USERNAME = '{0}'", username);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count <= 0)
            {
                return false;
            }
            DataProvider.Instance.ExecuteOracleProcedure("sp_deleteUser", new OracleParameter("username", username));
            return true;
        }

        public bool UpdateUser(string username, string newpassword)
        {
            string query = string.Format("SELECT * FROM ALL_USERS WHERE USERNAME = '{0}'", username);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count <= 0)
            {
                return false;
            }
            DataProvider.Instance.ExecuteOracleProcedure("sp_updateUser", new OracleParameter("username", username), new OracleParameter("newpassword", newpassword));
            return true;
        }

        public DataTable GetSYSPrivileges(string username)
        {
            string query = string.Format("SELECT * FROM USER_SYS_PRIVS WHERE USERNAME = '{0}'", username);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetTABPrivileges(string username)
        {
            string query = string.Format("SELECT * FROM USER_TAB_PRIVS WHERE GRANTEE = '{0}'", username);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetCOLPrivileges(string username)
        {
            string query = string.Format("SELECT * FROM USER_COL_PRIVS WHERE GRANTEE = '{0}'", username);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool GrantPrivileges(string username, string privilegesName, string tableName, bool withOption)
        {
            string query = string.Format("SELECT * FROM ALL_USERS WHERE USERNAME = '{0}'", username);
            DataTable checkUsername = DataProvider.Instance.ExecuteQuery(query);
            if (checkUsername.Rows.Count <= 0)
            {
                return false;
            }
            string query2= string.Format("SELECT * FROM ALL_TABLES WHERE TABLE_NAME = '{0}'", tableName);
            DataTable checkTableName = DataProvider.Instance.ExecuteQuery(query2);
            if (checkTableName.Rows.Count <= 0)
            {
                return false;
            }
            if (withOption)
            {
                DataProvider.Instance.ExecuteOracleProcedure("grantTablePrivilegeWGO", new OracleParameter("p_username", username), new OracleParameter("p_privilege", privilegesName), new OracleParameter("p_table", tableName));
            }
            else
            {
                DataProvider.Instance.ExecuteOracleProcedure("grantTablePrivilege", new OracleParameter("p_username", username), new OracleParameter("p_privilege", privilegesName), new OracleParameter("p_table", tableName));
            }
            return true;
        }

        public bool RevokePrivileges(string username, string privilegesName, string tableName, bool withOption)
        {
            string query = string.Format("SELECT * FROM ALL_USERS WHERE USERNAME = '{0}'", username);
            DataTable checkUsername = DataProvider.Instance.ExecuteQuery(query);
            if (checkUsername.Rows.Count <= 0)
            {
                return false;
            }
            string query2 = string.Format("SELECT * FROM ALL_TABLES WHERE TABLE_NAME = '{0}'", tableName);
            DataTable checkTableName = DataProvider.Instance.ExecuteQuery(query2);
            if (checkTableName.Rows.Count <= 0)
            {
                return false;
            }
            string query3 = string.Format("SELECT * FROM USER_TAB_PRIVS WHERE GRANTEE = '{0}' AND PRIVILEGE = '{1}' AND TABLE_NAME = '{2}'", username, privilegesName, tableName);
            DataTable checkPrivilage = DataProvider.Instance.ExecuteQuery(query3);
            if (checkPrivilage.Rows.Count <= 0)
            {
                return false;
            }
            DataProvider.Instance.ExecuteOracleProcedure("revokeUserPrivilege", 
                new OracleParameter("p_username", username), 
                new OracleParameter("p_privilege", privilegesName), 
                new OracleParameter("p_object_name", tableName));
            return true;
        }
    }

}

