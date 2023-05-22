using System;
using System.Collections;
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
                                                        FROM MYADMIN.PHONGBAN");
        }

        public bool CreateDepartment(string departmentID, string departmentName, string departmentHeadID)
        {
            // Tìm xem tồn tại ID phòng ban hay chưa, nếu đã có thì truy vấn trả về số dòng > 0 
            string query1 = string.Format("SELECT * FROM MYADMIN.PHONGBAN WHERE MAPB = '{0}'", departmentID);
            DataTable result1 = DataProvider.Instance.ExecuteQuery(query1);

            // Tìm xem tồn tại tên phòng ban hay chưa, nếu đã có thì truy vấn trả về số dòng > 0 
            string query2 = string.Format("SELECT * FROM MYADMIN.PHONGBAN WHERE TENPB = '{0}'", departmentName);
            DataTable result2 = DataProvider.Instance.ExecuteQuery(query2);

            if (result1.Rows.Count > 0 || result2.Rows.Count > 0)
            {
                return false;
            }

            DataProvider.Instance.ExecuteOracleProcedure("MYADMIN.sp_addDepartment", new OracleParameter("departmentID", departmentID), new OracleParameter("departmentName", departmentName), new OracleParameter("departmentHeadID", departmentHeadID));
            return true;
        }

        public bool DeleteDepartment(string departmentID)
        {
            // Tìm xem tồn tại phòng ban này không, nếu không (số dòng trả về = 0) thì không thể xóa phòng ban
            string query = string.Format("SELECT * FROM MYADMIN.PHONGBAN WHERE MAPB = '{0}'", departmentID);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            // Tìm xem tồn tại nhân viên thuộc phòng ban này không, nếu không (số dòng trả về > 0) thì không thể xóa phòng ban
            string query1 = string.Format("SELECT * FROM MYADMIN.NHANVIEN WHERE PHG = '{0}'", departmentID);
            DataTable result1 = DataProvider.Instance.ExecuteQuery(query1);

            if (result.Rows.Count <= 0 || result1.Rows.Count > 0)
            {
                return false;
            }
            DataProvider.Instance.ExecuteOracleProcedure("MYADMIN.sp_deleteDepartment", new OracleParameter("departmentID", departmentID));
            return true;
        }

        public bool UpdateDepartment(string departmentID, string departmentName, string departmentHeadID)
        {
            // Tìm xem tồn tại phòng ban này không, nếu không (số dòng trả về = 0) thì không thể cập nhật phòng ban
            string query = string.Format("SELECT * FROM MYADMIN.PHONGBAN WHERE MAPB = '{0}'", departmentID);
            DataTable result = DataProvider.Instance.ExecuteQuery(query);

            // Tìm xem tồn tại nhân viên bổ nhiệm trưởng phòng này không, nếu không (số dòng trả về = 0) thì không thể cập nhật phòng ban
            string query1 = string.Format("SELECT * FROM MYADMIN.NHANVIEN WHERE MANV = '{0}'", departmentHeadID);
            DataTable result1 = DataProvider.Instance.ExecuteQuery(query1);

            if (result.Rows.Count <= 0 || result1.Rows.Count <= 0)
            {
                return false;
            }
            DataProvider.Instance.ExecuteOracleProcedure("MYADMIN.sp_updateDepartment", new OracleParameter("departmentID", departmentID), new OracleParameter("departmentName", departmentName), new OracleParameter("departmentHeadID", departmentHeadID));
            return true;
        }
    }
}
