﻿using QuanLyDeAn.DAO;
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
        [Obsolete]
        public fNhanVien()
        {
            InitializeComponent();
            LoadData();
        }
        #region method

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
                txbNgaySinh.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never, "", "dd/MM/yyyy"));
                txbDiaChi.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
                txbSDT.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "SODT", true, DataSourceUpdateMode.Never));
                txbVaiTro.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "VAITRO", true, DataSourceUpdateMode.Never));
                txbNQL.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "MANQL", true, DataSourceUpdateMode.Never));
                txbPHG.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "PHG", true, DataSourceUpdateMode.Never));
                // Kiểm tra sự tồn tại của cột "LUONG"
                if (dt.Columns.Contains("LUONG"))
                {
                    txbLuong.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "LUONG", true, DataSourceUpdateMode.Never));
                }
                else
                {
                    txbLuong.Text = string.Empty; // Set giá trị trống cho TextBox "txbLuong"
                }

                // Kiểm tra sự tồn tại của cột "PHUCAP"
                if (dt.Columns.Contains("PHUCAP"))
                {
                    txbPhuCap.DataBindings.Add(new Binding("Text", dtgvDSNhanVien.DataSource, "PHUCAP", true, DataSourceUpdateMode.Never));
                }
                else
                {
                    txbPhuCap.Text = string.Empty; // Set giá trị trống cho TextBox "txbPhuCap"
                }
            }
            else
            {
                // Xử lý khi DataTable trống
                // MessageBox.Show("Không có dữ liệu để gắn kết!");
            }
           
        }
        #endregion

        #region event
        private void fNhanVien_Load(object sender, EventArgs e)
        {
            string role = DataProvider.Instance.role;
            if(role == "NhanVien" || role == "TruongPhong" || role == "QuanLyTrucTiep")
            {
                txbMaNV.ReadOnly = true;
                txbTenNV.ReadOnly = true;
                txbPhai.ReadOnly = true;
                txbVaiTro.ReadOnly = true;
                txbLuong.ReadOnly = true;
                txbPhuCap.ReadOnly = true;
                txbNQL.ReadOnly = true;
                txbPHG.ReadOnly = true;
                btnThemNV.Enabled = false;
                btnXoaNhanVien.Enabled = false;
            }    
            else if(role == "TaiChinh")
            {
                txbMaNV.ReadOnly = true;
                txbTenNV.ReadOnly = true;
                txbPhai.ReadOnly = true;
                txbVaiTro.ReadOnly = true;
                txbNQL.ReadOnly = true;
                txbPHG.ReadOnly = true;
                btnThemNV.Enabled = false;
                btnXoaNhanVien.Enabled = false;
                
            }
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
                else
                {
                    MessageBox.Show("Cập nhật thất bại :((");
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
                if(manv != "" && tennv != "" && phai != "" && ngaysinh != "" && diachi != "" 
                    && sodt != "" && vaitro != "" && manql != "" && phg != "")
                {
                    if (NhanVienDAO.Instance.ThemNhanVien(manv, tennv, phai, ngaysinh, diachi, sodt, luong, phucap, vaitro, manql, phg))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadDSNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại :((");
                        LoadDSNhanVien();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }
                
            }
        }
        #endregion

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txbMaNV.Text = "";
            txbTenNV.Text = "";
            txbPhai.Text = "";
            txbNgaySinh.Text = "";
            txbDiaChi.Text = "";
            txbSDT.Text = "";
            txbVaiTro.Text = "";
            txbNQL.Text = "";
            txbPHG.Text = "";
        }
    }
}
