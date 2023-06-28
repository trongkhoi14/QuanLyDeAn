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
    public partial class fPhongBan : Form
    {
        BindingSource dsPhongBan = new BindingSource();
        [Obsolete]
        public fPhongBan()
        {
            InitializeComponent();
            LoadData();

        }
        #region method
        [Obsolete]
        void LoadData()
        {
            dtgvDSPhongBan.DataSource = dsPhongBan;
            LoadDSPhongBan();
            AddPhongBanBinding();
        }

        [Obsolete]
        void LoadDSPhongBan()
        {
            dsPhongBan.DataSource = PhongBanDAO.Instance.DanhSachPhongBan();
        }
        void AddPhongBanBinding()
        {
            if (dsPhongBan.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                txbMaPB.DataBindings.Add(new Binding("Text", dtgvDSPhongBan.DataSource, "MAPB", true, DataSourceUpdateMode.Never));
                txbTenPB.DataBindings.Add(new Binding("Text", dtgvDSPhongBan.DataSource, "TENPB", true, DataSourceUpdateMode.Never));
                txbTRPHG.DataBindings.Add(new Binding("Text", dtgvDSPhongBan.DataSource, "TRPHG", true, DataSourceUpdateMode.Never));
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
        private void fPhongBan_Load(object sender, EventArgs e)
        {
            string role = DataProvider.Instance.role;
            btnCapNhatPB.Enabled = true;
            btnThemPB.Enabled = true;
            //if (role == "NhanSu")
            //{
            //    btnCapNhatPB.Enabled = true;
            //    btnThemPB.Enabled = true;

            //}
        }
        [Obsolete]
        private void btnThemPB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thêm phòng ban?", "Thông báo", MessageBoxButtons.OKCancel)
               == System.Windows.Forms.DialogResult.OK)
            {
                string mapb = txbMaPB.Text;
                string tenpb = txbTenPB.Text;
                string truongpb = txbTRPHG.Text;
                if(mapb != "" && tenpb != "" && truongpb != "")
                {
                    if(PhongBanDAO.Instance.ThemPhongBan(mapb, tenpb, truongpb))
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
        [Obsolete]
        private void btnCapNhatPB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn cập nhật phòng ban?", "Thông báo", MessageBoxButtons.OKCancel)
               == System.Windows.Forms.DialogResult.OK)
            {
                string mapb = txbMaPB.Text;
                string tenpb = txbTenPB.Text;
                string truongpb = txbTRPHG.Text;
                if (mapb != "" && tenpb != "" && truongpb != "")
                {
                    if (PhongBanDAO.Instance.CapNhatPhongBan(mapb, tenpb, truongpb))
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

        #endregion

        
    }
}
