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
            string query = "SELECT * FROM MYADMIN.VIEW_CS1_PHONGBAN";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
