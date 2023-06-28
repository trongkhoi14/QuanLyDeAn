using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeAn.DAO
{
    public class PhanCongDAO
    {
        private static PhanCongDAO instance;

        public static PhanCongDAO Instance
        {
            get { if (instance == null) instance = new PhanCongDAO(); return instance; }
            set => instance = value;
        }

        private PhanCongDAO() { }

        [Obsolete]
        public DataTable DanhSachPhanCong()
        {
            try
            {
                string role = DataProvider.Instance.role;
                string query = "";
                if (role == "NhanVien" || role == "NhanSu" || role == "TruongDeAn")
                {
                    query = "SELECT * FROM MYADMIN.VIEW_CS1_PHANCONG ORDER BY MANV ASC";
                }
                else if(role == "QuanLyTrucTiep")
                {
                    query = "SELECT * FROM MYADMIN.VIEW_CS2_PHANCONG ORDER BY MANV ASC";
                }
                else if(role == "TruongPhong")
                {
                    query = "SELECT * FROM MYADMIN.VIEW_CS3_PHANCONG ORDER BY MANV ASC";
                }
                else if(role == "TaiChinh")
                {
                    query = "SELECT * FROM MYADMIN.VIEW_CS4_PHANCONG ORDER BY MANV ASC";
                }
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        [Obsolete]
        public bool CapNhatPhanCong(string manv, string mada, string thoigian)
        {
            string role = DataProvider.Instance.role;
            string query = "";
            int result = 0;
            if (role == "TruongPhong")
            {
                query = string.Format("UPDATE MYADMIN.VIEW_CS3_PHANCONG " +
                    "SET THOIGIAN = TO_DATE('{0}','dd/mm/yyyy') " +
                    "WHERE MANV = '{1}' AND MADA = '{2}'", thoigian, manv, mada);
                result = DataProvider.Instance.ExecuteNonQuery(query);
                if (result > 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        [Obsolete]
        public bool ThemPhanCong(string manv, string mada, string thoigian)
        {
            string role = DataProvider.Instance.role;
            string query = "";
            int result = 0;
            if (role == "TruongPhong")
            {

                query = string.Format("INSERT INTO MYADMIN.VIEW_CS3_PHANCONG (MANV, MADA, THOIGIAN) " +
                    "VALUES ('{0}', '{1}', TO_DATE('{2}','dd/mm/yyyy'))", manv, mada, thoigian);
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
        public bool XoaPhanCong(string manv, string mada)
        {
            string role = DataProvider.Instance.role;
            string query = "";
            int result = 0;
            if (role == "TruongPhong")
            {

                query = string.Format("DELETE FROM MYADMIN.VIEW_CS3_PHANCONG " +
                    "WHERE MANV = '{0}' AND MADA = '{1}'", manv, mada);
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
    }
}
