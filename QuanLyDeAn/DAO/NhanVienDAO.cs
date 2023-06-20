using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDeAn.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            set => instance = value;
        }

        private NhanVienDAO() { }

        public DataTable DanhSachNhanVien()
        {
            
            try
            {
                return DataProvider.Instance.ExecuteQuery("SELECT * FROM MYADMIN.VIEW_CS1_NHANVIEN");
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

    }
}
