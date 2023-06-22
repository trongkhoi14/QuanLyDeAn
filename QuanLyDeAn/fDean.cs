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
    public partial class fDean : Form
    {
        BindingSource dsDeAn = new BindingSource();
        public fDean()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            dtgvDSDeAn.DataSource = dsDeAn;
            LoadDSDeAn();
            AddDeAnBinding();
        }
        void LoadDSDeAn()
        {
            dsDeAn.DataSource = DeAnDAO.Instance.DanhSachDeAn();
        }

        void AddDeAnBinding()
        {
            if (dsDeAn.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                txbMaDA.DataBindings.Add(new Binding("Text", dtgvDSDeAn.DataSource, "MADA", true, DataSourceUpdateMode.Never));
                txbTenDA.DataBindings.Add(new Binding("Text", dtgvDSDeAn.DataSource, "TENDA", true, DataSourceUpdateMode.Never));
                txbNgayBD.DataBindings.Add(new Binding("Text", dtgvDSDeAn.DataSource, "NGAYBD", true, DataSourceUpdateMode.Never));
                txbPhong.DataBindings.Add(new Binding("Text", dtgvDSDeAn.DataSource, "PHONG", true, DataSourceUpdateMode.Never));

            }
            else
            {
                // Xử lý khi DataTable trống
                // MessageBox.Show("Không có dữ liệu để gắn kết!");
            }
        }

        private void btnThemDA_Click(object sender, EventArgs e)
        {
            string mada = txbMaDA.Text;
            string tenda = txbTenDA.Text;
            string ngaybd = txbNgayBD.Text;
            string phong = txbPhong.Text;
            if (mada == "" || tenda == "" || ngaybd == "" || phong == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi muốn thêm đề án mới!");
            }
            else
            {
                if (DeAnDAO.Instance.AddDeAn(mada, tenda, ngaybd, phong))
                {
                    MessageBox.Show("Thêm đề án thành công!");
                    LoadDSDeAn();
                }
                else
                {
                    MessageBox.Show("Đề án đã tồn tại!");
                }
            }
        }

        private void btnCapNhatDA_Click(object sender, EventArgs e)
        {
            string mada = txbMaDA.Text;
            string tenda = txbTenDA.Text;
            string ngaybd = txbNgayBD.Text;
            string phong = txbPhong.Text;
            if ((mada == "" && tenda == "") || (mada == "" && ngaybd == "") || (mada == "" && phong == "") || (phong == "" && tenda == "" && ngaybd == ""))
            {
                MessageBox.Show("Vui lòng điền mã đề án và ít nhất một thông tin khác khi muốn cập nhật đề án!");
            }
            else
            {
                if (DeAnDAO.Instance.UpdateDeAn(mada, tenda, ngaybd, phong))
                {
                    MessageBox.Show("Cập nhật đề án thành công!");
                    LoadDSDeAn();
                }
                else
                {
                    MessageBox.Show("Đề án không tồn tại!");
                }
            }
        }

        private void btnXoaDA_Click(object sender, EventArgs e)
        {
            string mada = txbMaDA.Text;
            if (mada == "")
            {
                MessageBox.Show("Vui lòng điền mã đề án khi muốn xóa đề án!");
            }
            else
            {
                if (DeAnDAO.Instance.DeleteDeAn(mada))
                {
                    MessageBox.Show("Xóa đề án thành công!");
                    LoadDSDeAn();
                }
                else
                {
                    MessageBox.Show("Đề án không tồn tại!");
                }
            }
        }
    }
}
