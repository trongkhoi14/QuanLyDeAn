using QuanLyDeAn.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDeAn
{
    public partial class fNhanVien : Form
    {
        BindingSource dsNhanVien = new BindingSource();
        public fNhanVien()
        {
            InitializeComponent();
            LoadData();
        }

        [Obsolete]
        void LoadData()
        {
            dtgvDSNhanVien.DataSource = dsNhanVien;
            LoadDSNhanVien();
            AddNhanVienBinding();
        }

        [Obsolete]
        void LoadDSNhanVien()
        {
            dsNhanVien.DataSource = NhanVienDAO.Instance.DanhSachNhanVien();
        }

        void AddNhanVienBinding()
        {
            if (dsNhanVien.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                txbMaNV.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "MANV", true, DataSourceUpdateMode.Never));
                txbTenNV.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "TENNV", true, DataSourceUpdateMode.Never));
                txbPhai.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "PHAI", true, DataSourceUpdateMode.Never));
                txbNgaySinh.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
                txbDiaChi.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
                txbSDT.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "SODT", true, DataSourceUpdateMode.Never));
                txbLuong.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "LUONG", true, DataSourceUpdateMode.Never));
                txbPhuCap.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "PHUCAP", true, DataSourceUpdateMode.Never));
                txbVaiTro.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "VAITRO", true, DataSourceUpdateMode.Never));
                txbNQL.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "MANQL", true, DataSourceUpdateMode.Never));
                txbPHG.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "PHG", true, DataSourceUpdateMode.Never));
            }
            else
            {
                // Xử lý khi DataTable trống
                // MessageBox.Show("Không có dữ liệu để gắn kết!");
            }
           
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {

        }

        [Obsolete]
        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel)
                == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Xóa thành công!");
                LoadDSNhanVien();
            }
        }

        [Obsolete]
        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn cập nhật thông tin nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel)
               == System.Windows.Forms.DialogResult.OK)
            {
                string manv = txbMaNV.Text;
                string tennv = txbTenNV.Text;
                string phai = txbPhai.Text;
                string ngaysinh = txbNgaySinh.Text;
                string diachi = txbDiaChi.Text;
                string sodt = txbSDT.Text;
                string luong = txbLuong.Text;
                string phucap = txbPhuCap.Text;
                string vaitro = txbVaiTro.Text;
                string manql = txbNQL.Text;
                string phg = txbPHG.Text;
                if(NhanVienDAO.Instance.CapNhatNhanVien(manv, tennv, phai, ngaysinh, diachi, sodt, luong, phucap, vaitro, manql, phg))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    LoadDSNhanVien();
                }    
               
            }
        }

        [Obsolete]
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel)
               == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show("Thêm thành công!");
                LoadDSNhanVien();
            }
        }
    }
}
