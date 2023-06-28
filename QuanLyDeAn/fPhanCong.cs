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
    public partial class fPhanCong : Form
    {
        BindingSource dsPhanCong = new BindingSource();

        [Obsolete]
        public fPhanCong()
        {
            InitializeComponent();
            LoadData();
        }
        #region method
        [Obsolete]
        void LoadData()
        {
            dtgvDSPhanCong.DataSource = dsPhanCong;
            LoadDSPhongBan();
            AddPhongBanBinding();
        }

        [Obsolete]
        void LoadDSPhongBan()
        {
            dsPhanCong.DataSource = PhanCongDAO.Instance.DanhSachPhanCong();
        }
        void AddPhongBanBinding()
        {
            if (dsPhanCong.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                txbMaNV.DataBindings.Add(new Binding("Text", dtgvDSPhanCong.DataSource, "MANV", true, DataSourceUpdateMode.Never));
                txbMaDA.DataBindings.Add(new Binding("Text", dtgvDSPhanCong.DataSource, "MADA", true, DataSourceUpdateMode.Never));
                txbThoiGian.DataBindings.Add(new Binding("Text", dtgvDSPhanCong.DataSource, "THOIGIAN", true, DataSourceUpdateMode.Never, "", "dd/MM/yyyy"));
            }
            else
            {
                // Xử lý khi DataTable trống
                // MessageBox.Show("Không có dữ liệu để gắn kết!");
            }
        }

        #endregion

        #region event
        [Obsolete]
        private void btnXoaPC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa phân công?", "Thông báo", MessageBoxButtons.OKCancel)
               == System.Windows.Forms.DialogResult.OK)
            {
                string manv = txbMaNV.Text;
                string mada = txbMaDA.Text;
                string thoigian = txbThoiGian.Text;
                if (manv != "" && mada != "" && thoigian != "")
                {
                    if (PhanCongDAO.Instance.XoaPhanCong(manv, mada))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadDSPhongBan();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại :((");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }

            }
        }
        [Obsolete]
        private void btnCapNhatPC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn cập nhật phân công?", "Thông báo", MessageBoxButtons.OKCancel)
               == System.Windows.Forms.DialogResult.OK)
            {
                string manv = txbMaNV.Text;
                string mada = txbMaDA.Text;
                string thoigian = txbThoiGian.Text;
                if (manv != "" && mada != "" && thoigian != "")
                {
                    if (PhanCongDAO.Instance.CapNhatPhanCong(manv, mada, thoigian))
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        LoadDSPhongBan();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại :((");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }

            }
        }
        [Obsolete]
        private void btnThemPC_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm phân công?", "Thông báo", MessageBoxButtons.OKCancel)
                == System.Windows.Forms.DialogResult.OK)
            {
                string manv = txbMaNV.Text;
                string mada = txbMaDA.Text;
                string thoigian = txbThoiGian.Text;
                if (manv != "" && mada != "" && thoigian != "")
                {
                    if (PhanCongDAO.Instance.ThemPhanCong(manv, mada, thoigian))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadDSPhongBan();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại :((");
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                }

            }
        }
        #endregion
    }
}
