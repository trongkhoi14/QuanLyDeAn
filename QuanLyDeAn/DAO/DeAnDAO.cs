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
                string role = DataProvider.Instance.role;
                string query = "";
                if (role == "TruongDeAn")
                {
                    query = "SELECT * FROM MYADMIN.VIEW_CS6_DEAN ORDER BY MADA ASC";
                }
                else
                {
                    query = "SELECT * FROM MYADMIN.VIEW_CS1_DEAN ORDER BY MADA ASC";
                }
                return DataProvider.Instance.ExecuteQuery(query);
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
                string role = DataProvider.Instance.role;
                string query = "";
                int result = 0;
                if(role == "TruongDeAn")
                {
                    query = string.Format("INSERT INTO MYADMIN.VIEW_CS6_DEAN " +
                    "VALUES ('{0}', '{1}', TO_DATE('{2}','dd/mm/yyyy'), '{3}')", mada, tenda, ngaybd, phong);
                    try
                    {
                        result = DataProvider.Instance.ExecuteNonQuery(query);
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                    if (result > 0)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
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
                string role = DataProvider.Instance.role;
                string query = "";
                int result = 0;
                if (role == "TruongDeAn")
                {
                    query = string.Format("DELETE FROM MYADMIN.VIEW_CS6_DEAN WHERE MADA = '{0}'", mada);
                    try
                    {
                        result = DataProvider.Instance.ExecuteNonQuery(query);
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                    if (result > 0)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
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
                string role = DataProvider.Instance.role;
                string query = "";
                int result = 0;
                if (role == "TruongDeAn")
                {
                    query = string.Format("UPDATE MYADMIN.VIEW_CS6_DEAN " +
                    "SET TENDA = '{0}', " +
                    "NGAYBD = TO_DATE('{1}','dd/mm/yyyy'), " +
                    "PHONG = '{2}' WHERE MADA = '{3}'", tenda, ngaybd, phong, mada);
                    try
                    {
                        result = DataProvider.Instance.ExecuteNonQuery(query);
                    }
                    catch (Exception)
                    {
                        return false;
                    }

                    if (result > 0)
                    {
                        return true;
                    }
                    return false;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
