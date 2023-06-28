using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeAn.DAO
{
    public class PhongBanDAO
    {
        private static PhongBanDAO instance;

        public static PhongBanDAO Instance
        {
            get { if (instance == null) instance = new PhongBanDAO(); return instance; }
            set => instance = value;
        }

        private PhongBanDAO() { }

        [Obsolete]
        public DataTable DanhSachPhongBan()
        {
            try
            {
                string role = DataProvider.Instance.role;
                string query = "";
                if(role == "NhanSu")
                {
                    query = "SELECT * FROM MYADMIN.VIEW_CS5_PHONGBAN ORDER BY MAPB ASC";
                }
                else
                {
                    query = "SELECT * FROM MYADMIN.VIEW_CS1_PHONGBAN ORDER BY MAPB ASC";
                }
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return new DataTable();
            } 
        }

        [Obsolete]
        public bool CapNhatPhongBan(string mapb, string tenpb, string truongpb)
        {
            string role = DataProvider.Instance.role;
            string query = "";
            int result = 0;
            if (role == "NhanSu")
            {
                query = string.Format("UPDATE MYADMIN.VIEW_CS5_PHONGBAN " +
                    "SET TENPB = '{0}', TRPHG = '{1}' WHERE MAPB = '{2}'", tenpb, truongpb, mapb);
                result = DataProvider.Instance.ExecuteNonQuery(query);
                if(result > 0)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        [Obsolete]
        public bool ThemPhongBan(string mapb, string tenpb, string truongpb)
        {
            string role = DataProvider.Instance.role;
            string query = "";
            int result = 0;
            if (role == "NhanSu")
            {
                
                query = string.Format("INSERT INTO MYADMIN.VIEW_CS5_PHONGBAN " +
                    "VALUES ('{0}', '{1}', '{2}')", mapb, tenpb, truongpb);
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
