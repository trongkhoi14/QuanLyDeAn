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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = txbPassWord.Text;

            if(Login(username, password))
            {
                fHomePage f = new fHomePage();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }   
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }                
           
        }

        bool Login(string username, string password)
        {
            return AccountDAO.Instance.Login(username, password);
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) 
                != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
