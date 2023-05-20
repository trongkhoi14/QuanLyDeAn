using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QuanLyDeAn.DAO
{
    internal class DepartmentDAO
    {
        private static DepartmentDAO instance;

        
        public static DepartmentDAO Instance 
        {
            get { if (instance == null) instance = new DepartmentDAO(); return instance; }
            set => instance = value;
        }

        private DepartmentDAO() { }

        public DataTable GetListDepartment()
        {
            return DataProvider.Instance.ExecuteQuery(@"SELECT 
                                                            MAPB,
                                                            TENPB,
                                                            TRPHG
                                                        FROM SYS.PHONGBAN");
        }

        public bool CreateDepartment(string departmentID, string departmentName, string departmentHeadID)
        {
            // Tìm xem tồn tại ID phòng ban hay chưa, nếu đã có thì truy vấn trả về số dòng > 0 
            string query1 = string.Format("SELECT * FROM SYS.PHONGBAN WHERE MAPB = '{0}'", departmentID);
            DataTable result1 = DataProvider.Instance.ExecuteQuery(query1);

            // Tìm xem tồn tại tên phòng ban hay chưa, nếu đã có thì truy vấn trả về số dòng > 0 
            string query2 = string.Format("SELECT * FROM SYS.PHONGBAN WHERE TENPB = '{0}'", departmentName);
            DataTable result2 = DataProvider.Instance.ExecuteQuery(query2);

            if (result1.Rows.Count > 0 || result2.Rows.Count > 0)
            {
                return false;
            }

            DataProvider.Instance.ExecuteOracleProcedure("sp_addDepartment", new OracleParameter("departmentID", departmentID), 
                                                                            new OracleParameter("departmentName", departmentName), 
                                                                            new OracleParameter("departmentHeadID", int.Parse(departmentHeadID)));
            return true;
        }

        //public bool DeleteUser(string username)
        //{
        //    // Tìm xem tồn tại tài khoản này không, nếu không (số dòng trả về = 0) thì không thể xóa user
        //    string query = string.Format("SELECT * FROM ALL_USERS WHERE USERNAME = '{0}'", username);
        //    DataTable result = DataProvider.Instance.ExecuteQuery(query);
        //    if (result.Rows.Count <= 0)
        //    {
        //        return false;
        //    }
        //    DataProvider.Instance.ExecuteOracleProcedure("sp_deleteUser", new OracleParameter("username", username));
        //    return true;
        //}

        //public bool UpdateUser(string username, string newpassword)
        //{
        //    string query = string.Format("SELECT * FROM ALL_USERS WHERE USERNAME = '{0}'", username);
        //    DataTable result = DataProvider.Instance.ExecuteQuery(query);
        //    if (result.Rows.Count <= 0)
        //    {
        //        return false;
        //    }
        //    DataProvider.Instance.ExecuteOracleProcedure("sp_updateUser", new OracleParameter("username", username), new OracleParameter("newpassword", newpassword));
        //    return true;
        //}
    }
}
