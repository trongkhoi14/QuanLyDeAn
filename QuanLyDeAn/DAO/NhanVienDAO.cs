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
                    case "QuanLyTrucTiep":
                        query = "SELECT * FROM MYADMIN.VIEW_CS2_NHANVIEN";
                        break;
                    case "TruongPhong":
                        query = "SELECT * FROM MYADMIN.VIEW_CS3_NHANVIEN";
                        break;
                    case "TaiChinh":
                        query = "SELECT * FROM MYADMIN.VIEW_CS4_NHANVIEN";
                        break;

                    default:
                        query = "SELECT * FROM MYADMIN.VIEW_CS1_NHANVIEN";
                        break;
                }
                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return new DataTable();
            }
        }
        [Obsolete]
        public bool CapNhatNhanVien(string manv, string tennv, string phai, string ngaysinh, 
                                    string diachi, string sodt, string luong, string phucap, 
                                    string vaitro, string manql, string phg)
        {
            string role = DataProvider.Instance.role;
            string query = "";
            int resultUpdate = 0;
            if(role == "NhanVien" || role == "TruongPhong" || role == "QuanLyTrucTiep")
            {
                query = string.Format("UPDATE MYADMIN.VIEW_CS1_NHANVIEN SET DIACHI = '{0}', NGAYSINH = TO_DATE('{1}', 'dd/mm/yyyy'), SODT = '{2}'", diachi, ngaysinh, sodt);
                // Nếu dòng dữ liệu là của họ thì họ được cập nhật
                if (DataProvider.Instance.username == manv)
                {
                    try
                    {
                        resultUpdate = DataProvider.Instance.ExecuteNonQuery(query);
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }  
            else if(role == "TaiChinh")
            {
                
                // Cập nhật dữ liệu cá nhân
                if (DataProvider.Instance.username == manv)
                {
                    try
                    {
                        query = string.Format("UPDATE MYADMIN.VIEW_CS1_NHANVIEN SET DIACHI = '{0}', NGAYSINH = TO_DATE('{1}', 'dd/mm/yyyy'), SODT = '{2}'", diachi, ngaysinh, sodt);
                        resultUpdate = DataProvider.Instance.ExecuteNonQuery(query);
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }   
            else if(role == "NhanSu")
            {

            }
            //
            if (resultUpdate > 0)
            {
                return true;
            }    
            return false;
        }

    }
}
