using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeAn.DAO
{
    public class RoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance 
        {
            get { if (instance == null) instance = new RoleDAO(); return instance; }
            set => instance = value; 
        }

        private RoleDAO() { }

        public DataTable GetListRole()
        {
            return DataProvider.Instance.ExecuteQuery(@"SELECT * FROM DBA_ROLES");
        }

        public bool CreateRole(string rolename)
        {
            try
            {
                // Tìm xem có role hay chưa, nếu đã có thì truy vấn trả về số dòng > 0 
                string query = string.Format("SELECT * FROM DBA_ROLES WHERE ROLE = '{0}'", rolename);
                DataTable result = DataProvider.Instance.ExecuteQuery(query);
                if (result.Rows.Count > 0)
                {
                    return false;
                }
                DataProvider.Instance.ExecuteOracleProcedure("sp_createRole", new OracleParameter("role_name", rolename));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
           
        }

        public bool DeleteRole(string rolename)
        {
            try
            {
                string query = string.Format("SELECT * FROM DBA_ROLES WHERE ROLE = '{0}'", rolename);
                DataTable result = DataProvider.Instance.ExecuteQuery(query);
                if (result.Rows.Count <= 0)
                {
                    return false;
                }
                DataProvider.Instance.ExecuteOracleProcedure("sp_dropRole", new OracleParameter("role_name", rolename));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
          
        }

        //------------------------------------------------------------------------

        public DataTable GetSYSPrivilegesRole(string rolename)
        {
            string query = string.Format("SELECT * FROM ROLE_SYS_PRIVS WHERE ROLE = '{0}'", rolename);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetTABPrivilegesRole(string rolename)
        {
            string query = string.Format("SELECT * FROM ROLE_TAB_PRIVS WHERE ROLE= '{0}'", rolename);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetCOLPrivilegesRole(string rolename)
        {
            string query = string.Format("SELECT * FROM USER_COL_PRIVS WHERE GRANTEE = '{0}'", rolename);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetRole(string name)
        {
            string query = string.Format("SELECT * FROM DBA_ROLE_PRIVS WHERE GRANTEE = '{0}'", name);
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool GrantPrivilegesRole(string rolename, string privilegesName, string tableName)
        {
            string query = string.Format("SELECT * FROM DBA_ROLES WHERE ROLE = '{0}'", rolename);
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
            else
            {
                DataProvider.Instance.ExecuteOracleProcedure("grantTablePrivilege", new OracleParameter("p_username", rolename), new OracleParameter("p_privilege", privilegesName), new OracleParameter("p_table", tableName));
            }
            return true;
        }

        public bool RevokePrivilegesRole(string rolename, string privilegesName, string tableName)
        {
            string query = string.Format("SELECT * FROM DBA_ROLES WHERE ROLE = '{0}'", rolename);
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
            string query3 = string.Format("SELECT * FROM USER_TAB_PRIVS WHERE GRANTEE = '{0}' AND PRIVILEGE = '{1}' AND TABLE_NAME = '{2}'", rolename, privilegesName, tableName);
            DataTable checkPrivilage = DataProvider.Instance.ExecuteQuery(query3);
            if (checkPrivilage.Rows.Count <= 0)
            {
                return false;
            }
            DataProvider.Instance.ExecuteOracleProcedure("revokeUserPrivilege",
                new OracleParameter("p_username", rolename),
                new OracleParameter("p_privilege", privilegesName),
                new OracleParameter("p_object_name", tableName));
            return true;
        }

        public bool GrantRoleToUser(string rolename, string username)
        {
            string query = string.Format("SELECT * FROM DBA_ROLES WHERE ROLE = '{0}'", rolename);
            DataTable checkUsername = DataProvider.Instance.ExecuteQuery(query);
            if (checkUsername.Rows.Count <= 0)
            {
                return false;
            }
            string query1 = string.Format("SELECT * FROM ALL_USERS WHERE USERNAME = '{0}'", username);
            DataTable checkUsername1 = DataProvider.Instance.ExecuteQuery(query1);
            if (checkUsername1.Rows.Count <= 0)
            {
                return false;
            }
            else
            {
                DataProvider.Instance.ExecuteOracleProcedure("grantRole", new OracleParameter("p_rolename", rolename), new OracleParameter("p_username", username));
            }
            return true;
        }
        public bool GrantRoleToRole(string rolenamecap, string rolename)
        {
            string query = string.Format("SELECT * FROM DBA_ROLES WHERE ROLE = '{0}'", rolename);
            DataTable checkUsername = DataProvider.Instance.ExecuteQuery(query);
            if (checkUsername.Rows.Count <= 0)
            {
                return false;
            }
            string query1 = string.Format("SELECT * FROM DBA_ROLES WHERE ROLE = '{0}'", rolenamecap);
            DataTable checkUsername1 = DataProvider.Instance.ExecuteQuery(query1);
            if (checkUsername1.Rows.Count <= 0)
            {
                return false;
            }
            else
            {
                DataProvider.Instance.ExecuteOracleProcedure("grantRole", new OracleParameter("p_rolename", rolenamecap), new OracleParameter("p_username", rolename));
            }
            return true;
        }
        public bool RevokeRoleFromUser(string rolename, string username)
        {
            string query = string.Format("SELECT * FROM DBA_ROLES WHERE ROLE = '{0}'", rolename);
            DataTable checkUsername = DataProvider.Instance.ExecuteQuery(query);
            if (checkUsername.Rows.Count <= 0)
            {
                return false;
            }
            string query1 = string.Format("SELECT * FROM ALL_USERS WHERE USERNAME = '{0}'", username);
            DataTable checkUsername1 = DataProvider.Instance.ExecuteQuery(query1);
            if (checkUsername1.Rows.Count <= 0)
            {
                return false;
            }
            DataProvider.Instance.ExecuteOracleProcedure("revokeRole", new OracleParameter("p_rolename", rolename), new OracleParameter("p_username", username));
            return true;
        }
        public bool RevokeRoleFromRole(string rolenamecap, string rolename)
        {
            string query = string.Format("SELECT * FROM DBA_ROLES WHERE ROLE = '{0}'", rolename);
            DataTable checkUsername = DataProvider.Instance.ExecuteQuery(query);
            if (checkUsername.Rows.Count <= 0)
            {
                return false;
            }
            string query1 = string.Format("SELECT * FROM DBA_ROLES WHERE ROLE = '{0}'", rolenamecap);
            DataTable checkUsername1 = DataProvider.Instance.ExecuteQuery(query1);
            if (checkUsername1.Rows.Count <= 0)
            {
                return false;
            }
            DataProvider.Instance.ExecuteOracleProcedure("revokeRole", new OracleParameter("p_rolename", rolenamecap), new OracleParameter("p_username", rolename));
            return true;
        }
    }
}
