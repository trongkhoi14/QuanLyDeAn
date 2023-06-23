using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeAn.DAO
{
    public class DeAnDAO
    {
        private static DeAnDAO instance;
        private object mada;

        public static DeAnDAO Instance
        {
            get { if (instance == null) instance = new DeAnDAO(); return instance; }
            set => instance = value;
        }

        private DeAnDAO() { }

        [Obsolete]
        public DataTable DanhSachDeAn()
        {

            try
            {
                return DataProvider.Instance.ExecuteQuery("SELECT * FROM MYADMIN.VIEW_CS1_DEAN ORDER BY MADA ASC");
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        [Obsolete]
        public bool AddDeAn(string mada, string tenda, string ngaybd, string phong)
        {
            try
            {
                string query = string.Format("SELECT * FROM MYADMIN.DeAn WHERE MADA = '{0}'", mada);
                DataTable result = DataProvider.Instance.ExecuteQuery(query);
                if (result.Rows.Count > 0)
                {
                    return false;
                }
                string query1 = string.Format("SELECT * FROM MYADMIN.DeAn WHERE TENDA = '{0}'", tenda);
                DataTable result1 = DataProvider.Instance.ExecuteQuery(query1);
                if (result1.Rows.Count > 0)
                {   
                    return false;
                }
                DataProvider.Instance.ExecuteOracleProcedure("INSERT_DEAN", new OracleParameter("p_MADA", mada), new OracleParameter("p_TENDA", tenda), new OracleParameter("p_NGAYBD", DateTime.Parse(ngaybd)), new OracleParameter("p_PHONG", phong));
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        [Obsolete]
        public bool DeleteDeAn(string mada)
        {
            try
            {
                string query = string.Format("SELECT * FROM MYADMIN.DeAn WHERE MADA = '{0}'", mada);
                DataTable result = DataProvider.Instance.ExecuteQuery(query);
                if (result.Rows.Count == 0)
                {
                    return false;
                }
                DataProvider.Instance.ExecuteOracleProcedure("DELETE_DEAN", new OracleParameter("p_MADA", mada));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        [Obsolete]
        public bool UpdateDeAn(string mada, string tenda, string ngaybd, string phong)
        {
            try
            {
                string query = string.Format("SELECT * FROM MYADMIN.DeAn WHERE MADA = '{0}'", mada);
                DataTable result = DataProvider.Instance.ExecuteQuery(query);
                if (result.Rows.Count == 0)
                {
                    return false;
                }
                DataProvider.Instance.ExecuteOracleProcedure("UPDATE_DEAN", new OracleParameter("p_MADA", mada), new OracleParameter("p_TENDA", tenda), new OracleParameter("p_NGAYBD", DateTime.Parse(ngaybd)), new OracleParameter("p_PHONG", phong));
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
