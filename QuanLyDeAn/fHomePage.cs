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
    public partial class fHomePage : Form
    {
        public fHomePage()
        {
            InitializeComponent();
            getRole();
        }
        void getRole()
        {
            //DataProvider.Instance.role = DataProvider.Instance.ExecuteQuery();
            MessageBox.Show(DataProvider.Instance.role);
            
            //string role = DataProvider.Instance.role;
            //switch (role)
            //{
            //    case "TruongPhong":
            //        adminToolStripMenuItem.Enabled = false;
            //        break;
            //    case "QuanLyTrucTiep":
            //        adminToolStripMenuItem.Enabled = false;
            //        break;
            //    case "NhanVien":
            //        adminToolStripMenuItem.Enabled = false;
            //        break;
            //    case "admin":
            //        adminToolStripMenuItem.Enabled = true;
            //        nhânViênToolStripMenuItem.Enabled = false;
            //        phòngBanToolStripMenuItem.Enabled = false;
            //        đềÁnToolStripMenuItem.Enabled = false;
            //        phânCôngToolStripMenuItem.Enabled = false;
            //        break;
            //    default:
                    
            //        adminToolStripMenuItem.Enabled = false;
            //        nhânViênToolStripMenuItem.Enabled = false;
            //        phòngBanToolStripMenuItem.Enabled = false;
            //        đềÁnToolStripMenuItem.Enabled = false;
            //        phânCôngToolStripMenuItem.Enabled = false;
            //        break;
            //}
        }
  
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            try
            {
                f.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn không có quyền truy cập.");
            }

            this.Show();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fNhanVien f = new fNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đềÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDean f = new fDean();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
