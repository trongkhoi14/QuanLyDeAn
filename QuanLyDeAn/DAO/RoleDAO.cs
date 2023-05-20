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
            // Tìm xem có tài khoản hay chưa, nếu đã có thì truy vấn trả về số dòng > 0 
            string query = string.Format("SELECT * FROM DBA_ROLES WHERE ROLE = '{0}'", rolename);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            if (result.Rows.Count > 0)
            {
                return false;
            }
            DataProvider.Instance.ExecuteOracleProcedure("sp_createRole", new OracleParameter("role_name", rolename));
            return true;
        }

        public bool DeleteRole(string rolename)
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

        
    }
}
