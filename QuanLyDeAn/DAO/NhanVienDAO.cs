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

        [Obsolete]
        public DataTable DanhSachNhanVien()
        {
            
            try
            {
                string role = DataProvider.Instance.role;
                string query = "";
                switch (role)
                {
                    case "NhanVien":
                        query = "SELECT * FROM MYADMIN.VIEW_CS1_NHANVIEN";
                        break;
                    case "TruongPhong":
                        query = "SELECT * FROM MYADMIN.VIEW_CS3_NHANVIEN";
                        break;
                    default:
                        query = "SELECT * FROM MYADMIN.NHANVIEN";
                        break;
                }
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }

        public bool CapNhatNhanVien(string manv, string tennv, string phai, string ngaysinh, 
                                    string diachi, string sodt, string luong, string phucap, 
                                    string vaitro, string manql, string phg)
        {

            return true;
        }

    }
}
