namespace QuanLyDeAn
{
    partial class fDepartment
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
            this.components = new System.ComponentModel.Container();
            this.dtgvDepartment = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbDepartmentHeadID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbDepartmentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbDepartmentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepartment)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvDepartment
            // 
            this.dtgvDepartment.AllowUserToAddRows = false;
            this.dtgvDepartment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDepartment.Location = new System.Drawing.Point(24, 26);
            this.dtgvDepartment.Name = "dtgvDepartment";
            this.dtgvDepartment.RowHeadersWidth = 51;
            this.dtgvDepartment.RowTemplate.Height = 24;
            this.dtgvDepartment.Size = new System.Drawing.Size(482, 501);
            this.dtgvDepartment.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDeleteDepartment);
            this.panel2.Controls.Add(this.btnUpdateDepartment);
            this.panel2.Controls.Add(this.btnAddDepartment);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(542, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(497, 501);
            this.panel2.TabIndex = 2;
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new System.Drawing.Point(388, 198);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(104, 23);
            this.btnDeleteDepartment.TabIndex = 7;
            this.btnDeleteDepartment.Text = "Xóa";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.btnDeleteDepartment_Click);
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.Location = new System.Drawing.Point(261, 198);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(104, 23);
            this.btnUpdateDepartment.TabIndex = 6;
            this.btnUpdateDepartment.Text = "Cập nhật";
            this.btnUpdateDepartment.UseVisualStyleBackColor = true;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(132, 198);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(104, 23);
            this.btnAddDepartment.TabIndex = 5;
            this.btnAddDepartment.Text = "Thêm";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbDepartmentHeadID);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 127);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(491, 56);
            this.panel4.TabIndex = 4;
            // 
            // txbDepartmentHeadID
            // 
            this.txbDepartmentHeadID.Location = new System.Drawing.Point(129, 18);
            this.txbDepartmentHeadID.Name = "txbDepartmentHeadID";
            this.txbDepartmentHeadID.Size = new System.Drawing.Size(360, 22);
            this.txbDepartmentHeadID.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trưởng phòng ban:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbDepartmentName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(491, 56);
            this.panel3.TabIndex = 3;
            // 
            // txbDepartmentName
            // 
            this.txbDepartmentName.Location = new System.Drawing.Point(129, 18);
            this.txbDepartmentName.Name = "txbDepartmentName";
            this.txbDepartmentName.Size = new System.Drawing.Size(360, 22);
            this.txbDepartmentName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên phòng ban:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbDepartmentID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 56);
            this.panel1.TabIndex = 2;
            // 
            // txbDepartmentID
            // 
            this.txbDepartmentID.Location = new System.Drawing.Point(129, 18);
            this.txbDepartmentID.Name = "txbDepartmentID";
            this.txbDepartmentID.Size = new System.Drawing.Size(360, 22);
            this.txbDepartmentID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phòng ban:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dtgvDepartment);
            this.Name = "fDepartment";
            this.Text = "fPHONGBAN";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDepartment)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvDepartment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbDepartmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbDepartmentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbDepartmentHeadID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Button btnDeleteDepartment;
    }
}