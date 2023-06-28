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
                        query = "SELECT * FROM MYADMIN.VIEW_CS1_NHANVIEN ORDER BY MANV ASC";
                        break;
                    case "QuanLyTrucTiep":
                        query = "SELECT * FROM MYADMIN.VIEW_CS2_NHANVIEN ORDER BY MANV ASC";
                        break;
                    case "TruongPhong":
                        query = "SELECT * FROM MYADMIN.VIEW_CS3_NHANVIEN ORDER BY MANV ASC";
                        break;
                    case "TaiChinh":
                        query = "SELECT * FROM MYADMIN.VIEW_CS4_NHANVIEN ORDER BY MANV ASC";
                        break;
                    case "NhanSu":
                        query = "SELECT * FROM MYADMIN.VIEW_CS5_NHANVIEN ORDER BY MANV ASC";
                        break;
                    case "TruongDeAn":
                        query = "SELECT * FROM MYADMIN.VIEW_CS1_NHANVIEN ORDER BY MANV ASC";
                        break;
                    default:
                        query = "SELECT * FROM MYADMIN.VIEW_CS1_NHANVIEN ORDER BY MANV ASC";
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
            if(role == "NhanVien" || role == "TruongPhong" || role == "QuanLyTrucTiep" || role == "TruongDeAn")
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
                else //Cập nhật lương và phụ cấp cho người khác
                {
                    query = string.Format("UPDATE MYADMIN.VIEW_CS4_NHANVIEN " +
                        "SET LUONG = '{0}', PHUCAP = '{1}' WHERE MANV = '{2}'", luong, phucap, manv);
                    resultUpdate = DataProvider.Instance.ExecuteNonQuery(query);
                }
            }   
            else if(role == "NhanSu")
            {
                query = string.Format("UPDATE MYADMIN.VIEW_CS5_NHANVIEN " +
                    "SET TENNV = '{0}', " +
                    "PHAI = '{1}', " +
                    "NGAYSINH = TO_DATE('{2}', 'dd/mm/yyyy'), " +
                    "DIACHI = '{3}', " +
                    "SODT = '{4}', " +
                    "VAITRO = '{5}', " +
                    "MANQL = '{6}', " +
                    "PHG = '{7}' " +
                    "WHERE MANV = '{8}'", tennv, phai, ngaysinh, diachi, sodt, vaitro, manql, phg, manv);
                resultUpdate = DataProvider.Instance.ExecuteNonQuery(query);
            }
            //
            if (resultUpdate > 0)
            {
                return true;
            }    
            return false;
        }

        [Obsolete]
        public bool ThemNhanVien(string manv, string tennv, string phai, string ngaysinh,
                                    string diachi, string sodt, string luong, string phucap,
                                    string vaitro, string manql, string phg)
        {
            string role = DataProvider.Instance.role;
            string query = "";
            int resultUpdate = 0;
            if (role == "NhanSu")
            {
                //Kiểm tra nhân viên đã tồn tại chưa
                DataTable nv = DataProvider.Instance.ExecuteQuery($"SELECT * FROM MYADMIN.VIEW_CS5_NHANVIEN WHERE MANV = '{manv}'");
                if (nv.Rows.Count > 0)
                {
                    return false;
                }
                else
                {
                    query = string.Format("INSERT INTO MYADMIN.VIEW_CS5_NHANVIEN " +
                        "VALUES ('{0}', '{1}', '{2}', TO_DATE('{3}','dd/mm/yyyy'), " +
                        "'{4}', '{5}', '{6}', '{7}', '{8}')", manv, tennv, phai, ngaysinh, diachi, sodt, vaitro, manql, phg);

                    resultUpdate = DataProvider.Instance.ExecuteNonQuery(query);
                    if(resultUpdate > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
