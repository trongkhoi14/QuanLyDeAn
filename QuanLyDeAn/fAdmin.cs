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
    public partial class fAdmin : Form
    {
        BindingSource listUser = new BindingSource();
        BindingSource listRole = new BindingSource();

        public fAdmin()
        {  
            InitializeComponent();
            LoadData();
            
        }
        
        void LoadData()
        {
            dtgvUser.DataSource = listUser;
            LoadListUser();
            AddUserBinding();

            dtgvRole.DataSource = listRole;
            LoadListRole();
            AddRoleBinding();
        }

        void LoadListUser()
        {
            txbPassWord.Text = "";
            listUser.DataSource = AccountDAO.Instance.GetListUser();
        }    

        void AddUserBinding()
        {
            //Kiểm tra nếu DataTable không rỗng
            if (listUser.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                txbUserName.DataBindings.Add(new Binding("Text", dtgvUser.DataSource, "USERNAME", true, DataSourceUpdateMode.Never));
            }
            else
            {
                // Xử lý khi DataTable trống
                //MessageBox.Show("Không có dữ liệu để gắn kết!");
            }


        }

        void LoadListRole()
        {
            listRole.DataSource = RoleDAO.Instance.GetListRole();
        }

        void AddRoleBinding()
        {
            // Kiểm tra nếu DataTable không rỗng
            if (listRole.DataSource is DataTable dt && dt.Rows.Count > 0)
            {
                txbRoleName.DataBindings.Add(new Binding("Text", dtgvRole.DataSource, "ROLE", true, DataSourceUpdateMode.Never));
            }
            else
            {
                // Xử lý khi DataTable trống
                // MessageBox.Show("Không có dữ liệu để gắn kết!");
            }
            
        }

        void LoadPrivileges()
        {
            string userName = txbUserName.Text;
            dtgvSYS.DataSource = AccountDAO.Instance.GetSYSPrivileges(userName);
            dtgvCOL.DataSource = AccountDAO.Instance.GetCOLPrivileges(userName);
            dtgvTAB.DataSource = AccountDAO.Instance.GetTABPrivileges(userName);
            dtgvROLEUSER.DataSource = RoleDAO.Instance.GetRole(userName);
        }

        // Event
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if(userName == "" || passWord == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi khởi tạo tài khoản!");
            }    
            else
            {
                if (AccountDAO.Instance.CreateUser(userName, passWord))
                {
                    MessageBox.Show("Thêm tài khoản thành công!");
                    LoadListUser();
                }                                               
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại!");
                }
            }
                   
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa user này?", "Thông báo", MessageBoxButtons.OKCancel)
              == System.Windows.Forms.DialogResult.OK)
            {
                string userName = txbUserName.Text;
                if (userName == "MYADMIN")
                {
                    MessageBox.Show("Không thể xóa tài khoản này!");
                }
                else
                {
                    if (AccountDAO.Instance.DeleteUser(userName))
                    {
                        MessageBox.Show("Xóa thành công!");
                        LoadListUser();

                    }
                    else
                    {
                        MessageBox.Show("Tài khoản không tồn tại!");
                    }
                }
            }
           
           
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (userName == "" || passWord == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi cập nhật tài khoản!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateUser(userName, passWord))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                    LoadListUser();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại");
                }
            }
            
        }

        private void btnShowUser_Click(object sender, EventArgs e)
        {
            if(tcUserPrivileges.Visible == false)
            {
                LoadPrivileges();
                tcUserPrivileges.Visible = true;
            }
            else
            {
                tcUserPrivileges.Visible = false;
            }
        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {
            if (tcUserPrivileges.Visible == true)
            {
                LoadPrivileges();
            }    
                
        }

        private void btnAddRole_Click(object sender, EventArgs e)
        {
            string roleName = txbRoleName.Text;
            if (roleName == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi khởi tạo vai trò!");
            }
            else
            {
                if (RoleDAO.Instance.CreateRole(roleName))
                {
                    MessageBox.Show("Thêm vai trò thành công!");
                    LoadListRole();
                }
                else
                {
                    MessageBox.Show("Vai trò đã tồn tại!");
                }
            }
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn xóa role này?", "Thông báo", MessageBoxButtons.OKCancel)
             == System.Windows.Forms.DialogResult.OK)
            {
                string roleName = txbRoleName.Text;
                if (roleName == "")
                {
                    MessageBox.Show("Vui lòng nhập tên vai trò muốn xóa!");
                }
                else
                {
                    if (RoleDAO.Instance.DeleteRole(roleName))
                    {
                        MessageBox.Show("Xóa vai trò thành công!");
                        LoadListRole();
                    }
                    else
                    {
                        MessageBox.Show("Vai trò không tồn tại!");
                    }
                }
            }    
               
        }

        private void btnGrant_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string privilegesName = "";
            if (cbPrivileges.SelectedItem != null)
            {
                privilegesName = cbPrivileges.SelectedItem.ToString();
            }
            string tableName = txbNameTable.Text;
            bool grantWithOption = cbGrantOpt.Checked;
            if(privilegesName == "" || tableName == "" || username == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi cấp quyền!");
            }    
            else
            {
                if(AccountDAO.Instance.GrantPrivileges(username, privilegesName, tableName, grantWithOption))
                {
                    LoadPrivileges();
                    MessageBox.Show("Cấp quyền thành công!");
                }
                else
                {
                    MessageBox.Show("Cấp quyền thất bại!");
                }
            }

        }

        private void btnRevoke_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string privilegesName = "";
            if (cbPrivileges.SelectedItem != null)
            {
                privilegesName = cbPrivileges.SelectedItem.ToString();
            }

            string tableName = txbNameTable.Text;
            bool grantWithOption = cbGrantOpt.Checked;
            if (privilegesName == "" || tableName == "" || username == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi thu hồi quyền!");
            }
            else
            {
                if (AccountDAO.Instance.RevokePrivileges(username, privilegesName, tableName, grantWithOption))
                {
                    LoadPrivileges();
                    MessageBox.Show("Thu hồi quyền thành công!");
                }
                else
                {
                    MessageBox.Show("Thu hồi quyền thất bại!");
                }
            }
        }
        //--------------------------------------------------------------------
        void LoadPrivilegesRole()
        {
            string rolename = txbRoleName.Text;
            dtgvSYSROLE.DataSource = RoleDAO.Instance.GetSYSPrivilegesRole(rolename);
            dtgvTABROLE.DataSource = RoleDAO.Instance.GetTABPrivilegesRole(rolename);
            dtgvCOLROLE.DataSource = RoleDAO.Instance.GetCOLPrivilegesRole(rolename);
            dtgvROLEROLE.DataSource = RoleDAO.Instance.GetRole(rolename);
        }
        private void btnShowRole_Click(object sender, EventArgs e)
        {
            if (tcRolePrivileges.Visible == false)
            {
                LoadPrivilegesRole();
                tcRolePrivileges.Visible = true;
            }
            else
            {
                tcRolePrivileges.Visible = false;
            }
        }
        private void txbRoleName_TextChanged(object sender, EventArgs e)
        {
            if (tcRolePrivileges.Visible == true)
            {
                LoadPrivilegesRole();
            }

        }
        private void btnGrantRoleUser_Click(object sender, EventArgs e)
        {
            string rolename = txbRoleNameCap.Text;
            string username = txbUserName.Text;
            if (rolename == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi cấp quyền!");
            }
            else
            {
                if (RoleDAO.Instance.GrantRoleToUser(rolename, username))
                {
                    LoadPrivileges();
                    MessageBox.Show("Cấp role thành công!");
                }
                else
                {
                    MessageBox.Show("Cấp role thất bại!");
                }
            }

        }
        private void btnGrantRoleRole_Click(object sender, EventArgs e)
        {
            string rolename = txbRoleName.Text;
            string rolenamecap = txbRoleNameCapRole.Text;
            if (rolenamecap == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi cấp quyền!");
            }
            else
            {
                if (RoleDAO.Instance.GrantRoleToRole(rolenamecap, rolename))
                {
                    LoadPrivilegesRole();
                    MessageBox.Show("Cấp role thành công!");
                }
                else
                {
                    MessageBox.Show("Cấp role thất bại!");
                }
            }

        }
        private void btnRevokeRoleUser_Click(object sender, EventArgs e)
        {
            string rolename = txbRoleNameCap.Text;
            string username = txbUserName.Text;
            if (rolename == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi thu hồi quyền!");
            }
            else
            {
                if (RoleDAO.Instance.RevokeRoleFromUser(rolename, username))
                {
                    LoadPrivileges();
                    MessageBox.Show("Thu hồi role thành công!");
                }
                else
                {
                    MessageBox.Show("Thu hồi role thất bại!");
                }
            }
        }
        private void btnRevokeRoleRole_Click(object sender, EventArgs e)
        {
            string rolename = txbRoleName.Text;
            string rolenamecap = txbRoleNameCapRole.Text;
            if (rolenamecap == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi thu hồi quyền!");
            }
            else
            {
                if (RoleDAO.Instance.RevokeRoleFromRole(rolenamecap, rolename))
                {
                    LoadPrivilegesRole();
                    MessageBox.Show("Thu hồi role thành công!");
                }
                else
                {
                    MessageBox.Show("Thu hồi role thất bại!");
                }
            }
        }
        private void btnGrantRole_Click(object sender, EventArgs e)
        {
            string rolename = txbRoleName.Text;
            string privilegesName = "";
            if (cbPrivilegesRole.SelectedItem != null)
            {
                privilegesName = cbPrivilegesRole.SelectedItem.ToString();
            }
            string tableName = txbNameTableRole.Text;
            if (privilegesName == "" || tableName == "" || rolename == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi cấp quyền!");
            }
            else
            {
                if (RoleDAO.Instance.GrantPrivilegesRole(rolename, privilegesName, tableName))
                {
                    LoadPrivilegesRole();
                    MessageBox.Show("Cấp quyền thành công!");
                }
                else
                {
                    MessageBox.Show("Cấp quyền thất bại!");
                }
            }

        }
        private void btnRevokeRole_Click(object sender, EventArgs e)
        {
            string rolename = txbRoleName.Text;
            string privilegesName = "";
            if (cbPrivilegesRole.SelectedItem != null)
            {
                privilegesName = cbPrivilegesRole.SelectedItem.ToString();
            }
            string tableName = txbNameTableRole.Text;
            if (privilegesName == "" || tableName == "" || rolename == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khi thu hồi quyền!");
            }
            else
            {
                if (RoleDAO.Instance.RevokePrivilegesRole(rolename, privilegesName, tableName))
                {
                    LoadPrivilegesRole();
                    MessageBox.Show("Thu hồi quyền thành công!");
                }
                else
                {
                    MessageBox.Show("Thu hồi quyền thất bại!");
                }
            }
        }
    }
}
