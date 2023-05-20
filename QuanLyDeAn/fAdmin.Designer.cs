namespace QuanLyDeAn
{
    partial class fAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpUser = new System.Windows.Forms.TabPage();
            this.tcUserPrivileges = new System.Windows.Forms.TabControl();
            this.tpSYS = new System.Windows.Forms.TabPage();
            this.dtgvSYS = new System.Windows.Forms.DataGridView();
            this.tpTAB = new System.Windows.Forms.TabPage();
            this.dtgvTAB = new System.Windows.Forms.DataGridView();
            this.tpCOL = new System.Windows.Forms.TabPage();
            this.dtgvCOL = new System.Windows.Forms.DataGridView();
            this.tpGrant = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRevoke = new System.Windows.Forms.Button();
            this.txbRole = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbColName = new System.Windows.Forms.TextBox();
            this.lbColName = new System.Windows.Forms.Label();
            this.txbNameTable = new System.Windows.Forms.TextBox();
            this.cbGrantOpt = new System.Windows.Forms.CheckBox();
            this.cbPrivileges = new System.Windows.Forms.ComboBox();
            this.btnGrant = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbPassWord = new System.Windows.Forms.TextBox();
            this.txbUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShowUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.dtgvUser = new System.Windows.Forms.DataGridView();
            this.tpRole = new System.Windows.Forms.TabPage();
            this.btnUpdateRole = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDeleteRole = new System.Windows.Forms.Button();
            this.btnAddRole = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbRoleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvRole = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tcAdmin.SuspendLayout();
            this.tpUser.SuspendLayout();
            this.tcUserPrivileges.SuspendLayout();
            this.tpSYS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSYS)).BeginInit();
            this.tpTAB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTAB)).BeginInit();
            this.tpCOL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCOL)).BeginInit();
            this.tpGrant.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).BeginInit();
            this.tpRole.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpUser);
            this.tcAdmin.Controls.Add(this.tpRole);
            this.tcAdmin.Location = new System.Drawing.Point(17, 15);
            this.tcAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(1033, 524);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpUser
            // 
            this.tpUser.Controls.Add(this.tcUserPrivileges);
            this.tpUser.Controls.Add(this.panel2);
            this.tpUser.Controls.Add(this.btnShowUser);
            this.tpUser.Controls.Add(this.btnUpdateUser);
            this.tpUser.Controls.Add(this.btnDeleteUser);
            this.tpUser.Controls.Add(this.btnAddUser);
            this.tpUser.Controls.Add(this.dtgvUser);
            this.tpUser.Location = new System.Drawing.Point(4, 25);
            this.tpUser.Margin = new System.Windows.Forms.Padding(4);
            this.tpUser.Name = "tpUser";
            this.tpUser.Padding = new System.Windows.Forms.Padding(4);
            this.tpUser.Size = new System.Drawing.Size(1025, 495);
            this.tpUser.TabIndex = 0;
            this.tpUser.Text = "User";
            this.tpUser.UseVisualStyleBackColor = true;
            // 
            // tcUserPrivileges
            // 
            this.tcUserPrivileges.Controls.Add(this.tpSYS);
            this.tcUserPrivileges.Controls.Add(this.tpTAB);
            this.tcUserPrivileges.Controls.Add(this.tpCOL);
            this.tcUserPrivileges.Controls.Add(this.tpGrant);
            this.tcUserPrivileges.Location = new System.Drawing.Point(499, 132);
            this.tcUserPrivileges.Name = "tcUserPrivileges";
            this.tcUserPrivileges.SelectedIndex = 0;
            this.tcUserPrivileges.Size = new System.Drawing.Size(530, 363);
            this.tcUserPrivileges.TabIndex = 3;
            this.tcUserPrivileges.Visible = false;
            // 
            // tpSYS
            // 
            this.tpSYS.Controls.Add(this.dtgvSYS);
            this.tpSYS.Location = new System.Drawing.Point(4, 25);
            this.tpSYS.Name = "tpSYS";
            this.tpSYS.Padding = new System.Windows.Forms.Padding(3);
            this.tpSYS.Size = new System.Drawing.Size(522, 334);
            this.tpSYS.TabIndex = 0;
            this.tpSYS.Text = "SYS";
            this.tpSYS.UseVisualStyleBackColor = true;
            // 
            // dtgvSYS
            // 
            this.dtgvSYS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSYS.Location = new System.Drawing.Point(3, 0);
            this.dtgvSYS.Name = "dtgvSYS";
            this.dtgvSYS.RowHeadersWidth = 51;
            this.dtgvSYS.RowTemplate.Height = 24;
            this.dtgvSYS.Size = new System.Drawing.Size(501, 326);
            this.dtgvSYS.TabIndex = 0;
            // 
            // tpTAB
            // 
            this.tpTAB.Controls.Add(this.dtgvTAB);
            this.tpTAB.Location = new System.Drawing.Point(4, 25);
            this.tpTAB.Name = "tpTAB";
            this.tpTAB.Padding = new System.Windows.Forms.Padding(3);
            this.tpTAB.Size = new System.Drawing.Size(522, 334);
            this.tpTAB.TabIndex = 1;
            this.tpTAB.Text = "TAB";
            this.tpTAB.UseVisualStyleBackColor = true;
            // 
            // dtgvTAB
            // 
            this.dtgvTAB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTAB.Location = new System.Drawing.Point(2, 3);
            this.dtgvTAB.Name = "dtgvTAB";
            this.dtgvTAB.RowHeadersWidth = 51;
            this.dtgvTAB.RowTemplate.Height = 24;
            this.dtgvTAB.Size = new System.Drawing.Size(501, 326);
            this.dtgvTAB.TabIndex = 1;
            // 
            // tpCOL
            // 
            this.tpCOL.Controls.Add(this.dtgvCOL);
            this.tpCOL.Location = new System.Drawing.Point(4, 25);
            this.tpCOL.Name = "tpCOL";
            this.tpCOL.Padding = new System.Windows.Forms.Padding(3);
            this.tpCOL.Size = new System.Drawing.Size(522, 334);
            this.tpCOL.TabIndex = 2;
            this.tpCOL.Text = "COL";
            this.tpCOL.UseVisualStyleBackColor = true;
            // 
            // dtgvCOL
            // 
            this.dtgvCOL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCOL.Location = new System.Drawing.Point(2, 3);
            this.dtgvCOL.Name = "dtgvCOL";
            this.dtgvCOL.RowHeadersWidth = 51;
            this.dtgvCOL.RowTemplate.Height = 24;
            this.dtgvCOL.Size = new System.Drawing.Size(501, 326);
            this.dtgvCOL.TabIndex = 1;
            // 
            // tpGrant
            // 
            this.tpGrant.BackColor = System.Drawing.Color.Transparent;
            this.tpGrant.Controls.Add(this.label7);
            this.tpGrant.Controls.Add(this.button2);
            this.tpGrant.Controls.Add(this.button1);
            this.tpGrant.Controls.Add(this.btnRevoke);
            this.tpGrant.Controls.Add(this.txbRole);
            this.tpGrant.Controls.Add(this.label6);
            this.tpGrant.Controls.Add(this.txbColName);
            this.tpGrant.Controls.Add(this.lbColName);
            this.tpGrant.Controls.Add(this.txbNameTable);
            this.tpGrant.Controls.Add(this.cbGrantOpt);
            this.tpGrant.Controls.Add(this.cbPrivileges);
            this.tpGrant.Controls.Add(this.btnGrant);
            this.tpGrant.Controls.Add(this.label5);
            this.tpGrant.Controls.Add(this.label4);
            this.tpGrant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpGrant.Location = new System.Drawing.Point(4, 25);
            this.tpGrant.Name = "tpGrant";
            this.tpGrant.Padding = new System.Windows.Forms.Padding(3);
            this.tpGrant.Size = new System.Drawing.Size(522, 334);
            this.tpGrant.TabIndex = 3;
            this.tpGrant.Text = "Cấp quyền";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Cấp Role cho User:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(406, 198);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 198);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Thu hồi";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRevoke
            // 
            this.btnRevoke.Location = new System.Drawing.Point(298, 102);
            this.btnRevoke.Margin = new System.Windows.Forms.Padding(4);
            this.btnRevoke.Name = "btnRevoke";
            this.btnRevoke.Size = new System.Drawing.Size(100, 28);
            this.btnRevoke.TabIndex = 10;
            this.btnRevoke.Text = "Thu hồi";
            this.btnRevoke.UseVisualStyleBackColor = true;
            this.btnRevoke.Click += new System.EventHandler(this.btnRevoke_Click);
            // 
            // txbRole
            // 
            this.txbRole.Location = new System.Drawing.Point(106, 168);
            this.txbRole.Margin = new System.Windows.Forms.Padding(4);
            this.txbRole.Name = "txbRole";
            this.txbRole.Size = new System.Drawing.Size(400, 22);
            this.txbRole.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tên Role:";
            // 
            // txbColName
            // 
            this.txbColName.Enabled = false;
            this.txbColName.Location = new System.Drawing.Point(106, 72);
            this.txbColName.Margin = new System.Windows.Forms.Padding(4);
            this.txbColName.Name = "txbColName";
            this.txbColName.Size = new System.Drawing.Size(400, 22);
            this.txbColName.TabIndex = 7;
            // 
            // lbColName
            // 
            this.lbColName.AutoSize = true;
            this.lbColName.Enabled = false;
            this.lbColName.Location = new System.Drawing.Point(2, 75);
            this.lbColName.Name = "lbColName";
            this.lbColName.Size = new System.Drawing.Size(60, 17);
            this.lbColName.TabIndex = 6;
            this.lbColName.Text = "Tên cột:";
            // 
            // txbNameTable
            // 
            this.txbNameTable.Location = new System.Drawing.Point(106, 42);
            this.txbNameTable.Margin = new System.Windows.Forms.Padding(4);
            this.txbNameTable.Name = "txbNameTable";
            this.txbNameTable.Size = new System.Drawing.Size(400, 22);
            this.txbNameTable.TabIndex = 5;
            // 
            // cbGrantOpt
            // 
            this.cbGrantOpt.AutoSize = true;
            this.cbGrantOpt.Location = new System.Drawing.Point(290, 14);
            this.cbGrantOpt.Name = "cbGrantOpt";
            this.cbGrantOpt.Size = new System.Drawing.Size(138, 21);
            this.cbGrantOpt.TabIndex = 4;
            this.cbGrantOpt.Text = "With grant option";
            this.cbGrantOpt.UseVisualStyleBackColor = true;
            // 
            // cbPrivileges
            // 
            this.cbPrivileges.FormattingEnabled = true;
            this.cbPrivileges.Items.AddRange(new object[] {
            "SELECT",
            "INSERT",
            "UPDATE",
            "DELETE"});
            this.cbPrivileges.Location = new System.Drawing.Point(106, 12);
            this.cbPrivileges.Name = "cbPrivileges";
            this.cbPrivileges.Size = new System.Drawing.Size(100, 24);
            this.cbPrivileges.TabIndex = 3;
            // 
            // btnGrant
            // 
            this.btnGrant.Location = new System.Drawing.Point(406, 102);
            this.btnGrant.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrant.Name = "btnGrant";
            this.btnGrant.Size = new System.Drawing.Size(100, 28);
            this.btnGrant.TabIndex = 2;
            this.btnGrant.Text = "Cấp quyền";
            this.btnGrant.UseVisualStyleBackColor = true;
            this.btnGrant.Click += new System.EventHandler(this.btnGrant_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên bảng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên quyền:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbPassWord);
            this.panel2.Controls.Add(this.txbUserName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(501, 9);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(513, 81);
            this.panel2.TabIndex = 2;
            // 
            // txbPassWord
            // 
            this.txbPassWord.Location = new System.Drawing.Point(108, 42);
            this.txbPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.txbPassWord.Name = "txbPassWord";
            this.txbPassWord.Size = new System.Drawing.Size(400, 22);
            this.txbPassWord.TabIndex = 3;
            this.txbPassWord.UseSystemPasswordChar = true;
            // 
            // txbUserName
            // 
            this.txbUserName.Location = new System.Drawing.Point(108, 4);
            this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txbUserName.Name = "txbUserName";
            this.txbUserName.Size = new System.Drawing.Size(400, 22);
            this.txbUserName.TabIndex = 2;
            this.txbUserName.TextChanged += new System.EventHandler(this.txbUserName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên user:";
            // 
            // btnShowUser
            // 
            this.btnShowUser.Location = new System.Drawing.Point(508, 97);
            this.btnShowUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowUser.Name = "btnShowUser";
            this.btnShowUser.Size = new System.Drawing.Size(100, 28);
            this.btnShowUser.TabIndex = 1;
            this.btnShowUser.Text = "Chi tiết >>";
            this.btnShowUser.UseVisualStyleBackColor = true;
            this.btnShowUser.Click += new System.EventHandler(this.btnShowUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(801, 97);
            this.btnUpdateUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateUser.TabIndex = 1;
            this.btnUpdateUser.Text = "Cập nhật";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(909, 97);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.Text = "Xóa";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(693, 97);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(100, 28);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Thêm";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // dtgvUser
            // 
            this.dtgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvUser.Location = new System.Drawing.Point(9, 9);
            this.dtgvUser.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvUser.Name = "dtgvUser";
            this.dtgvUser.RowHeadersWidth = 51;
            this.dtgvUser.Size = new System.Drawing.Size(483, 476);
            this.dtgvUser.TabIndex = 0;
            // 
            // tpRole
            // 
            this.tpRole.Controls.Add(this.btnUpdateRole);
            this.tpRole.Controls.Add(this.button4);
            this.tpRole.Controls.Add(this.btnDeleteRole);
            this.tpRole.Controls.Add(this.btnAddRole);
            this.tpRole.Controls.Add(this.panel1);
            this.tpRole.Controls.Add(this.dtgvRole);
            this.tpRole.Location = new System.Drawing.Point(4, 25);
            this.tpRole.Margin = new System.Windows.Forms.Padding(4);
            this.tpRole.Name = "tpRole";
            this.tpRole.Padding = new System.Windows.Forms.Padding(4);
            this.tpRole.Size = new System.Drawing.Size(1025, 495);
            this.tpRole.TabIndex = 1;
            this.tpRole.Text = "Role";
            this.tpRole.UseVisualStyleBackColor = true;
            // 
            // btnUpdateRole
            // 
            this.btnUpdateRole.Location = new System.Drawing.Point(801, 97);
            this.btnUpdateRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateRole.Name = "btnUpdateRole";
            this.btnUpdateRole.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateRole.TabIndex = 2;
            this.btnUpdateRole.Text = "Cập nhật";
            this.btnUpdateRole.UseVisualStyleBackColor = true;
            this.btnUpdateRole.Click += new System.EventHandler(this.btnUpdateRole_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(508, 97);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 28);
            this.button4.TabIndex = 2;
            this.button4.Text = "Chi tiết >>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRole
            // 
            this.btnDeleteRole.Location = new System.Drawing.Point(909, 97);
            this.btnDeleteRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteRole.Name = "btnDeleteRole";
            this.btnDeleteRole.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteRole.TabIndex = 2;
            this.btnDeleteRole.Text = "Xóa";
            this.btnDeleteRole.UseVisualStyleBackColor = true;
            this.btnDeleteRole.Click += new System.EventHandler(this.btnDeleteRole_Click);
            // 
            // btnAddRole
            // 
            this.btnAddRole.Location = new System.Drawing.Point(693, 97);
            this.btnAddRole.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddRole.Name = "btnAddRole";
            this.btnAddRole.Size = new System.Drawing.Size(100, 28);
            this.btnAddRole.TabIndex = 2;
            this.btnAddRole.Text = "Thêm";
            this.btnAddRole.UseVisualStyleBackColor = true;
            this.btnAddRole.Click += new System.EventHandler(this.btnAddRole_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbRoleName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(501, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 81);
            this.panel1.TabIndex = 1;
            // 
            // txbRoleName
            // 
            this.txbRoleName.Location = new System.Drawing.Point(108, 4);
            this.txbRoleName.Margin = new System.Windows.Forms.Padding(4);
            this.txbRoleName.Name = "txbRoleName";
            this.txbRoleName.Size = new System.Drawing.Size(400, 22);
            this.txbRoleName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên Role:";
            // 
            // dtgvRole
            // 
            this.dtgvRole.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvRole.Location = new System.Drawing.Point(9, 9);
            this.dtgvRole.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvRole.Name = "dtgvRole";
            this.dtgvRole.RowHeadersWidth = 51;
            this.dtgvRole.Size = new System.Drawing.Size(483, 476);
            this.dtgvRole.TabIndex = 0;
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tcAdmin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.tcAdmin.ResumeLayout(false);
            this.tpUser.ResumeLayout(false);
            this.tcUserPrivileges.ResumeLayout(false);
            this.tpSYS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSYS)).EndInit();
            this.tpTAB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTAB)).EndInit();
            this.tpCOL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCOL)).EndInit();
            this.tpGrant.ResumeLayout(false);
            this.tpGrant.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvUser)).EndInit();
            this.tpRole.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvRole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpUser;
        private System.Windows.Forms.TabPage tpRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvRole;
        private System.Windows.Forms.TextBox txbRoleName;
        private System.Windows.Forms.DataGridView dtgvUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnShowUser;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Button btnUpdateRole;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDeleteRole;
        private System.Windows.Forms.TabControl tcUserPrivileges;
        private System.Windows.Forms.TabPage tpSYS;
        private System.Windows.Forms.TabPage tpTAB;
        private System.Windows.Forms.TabPage tpCOL;
        private System.Windows.Forms.DataGridView dtgvSYS;
        private System.Windows.Forms.DataGridView dtgvTAB;
        private System.Windows.Forms.DataGridView dtgvCOL;
        private System.Windows.Forms.TabPage tpGrant;
        private System.Windows.Forms.Button btnGrant;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbPrivileges;
        private System.Windows.Forms.TextBox txbColName;
        private System.Windows.Forms.Label lbColName;
        private System.Windows.Forms.TextBox txbNameTable;
        private System.Windows.Forms.CheckBox cbGrantOpt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRevoke;
        private System.Windows.Forms.TextBox txbRole;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}