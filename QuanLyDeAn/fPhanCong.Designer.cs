namespace QuanLyDeAn
{
    partial class fPhanCong
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
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaDA = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbThoiGian = new System.Windows.Forms.TextBox();
            this.dtgvDSNhanVien = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCapNhatPC = new System.Windows.Forms.Button();
            this.btnXoaPC = new System.Windows.Forms.Button();
            this.btnThemPC = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNhanVien)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(109, 10);
            this.txbMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(430, 22);
            this.txbMaNV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã đề án:";
            // 
            // txbMaDA
            // 
            this.txbMaDA.Location = new System.Drawing.Point(109, 10);
            this.txbMaDA.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaDA.Name = "txbMaDA";
            this.txbMaDA.Size = new System.Drawing.Size(430, 22);
            this.txbMaDA.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mã nhân viên:";
            // 
            // txbThoiGian
            // 
            this.txbThoiGian.Location = new System.Drawing.Point(109, 10);
            this.txbThoiGian.Margin = new System.Windows.Forms.Padding(4);
            this.txbThoiGian.Name = "txbThoiGian";
            this.txbThoiGian.Size = new System.Drawing.Size(430, 22);
            this.txbThoiGian.TabIndex = 3;
            // 
            // dtgvDSNhanVien
            // 
            this.dtgvDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSNhanVien.Location = new System.Drawing.Point(3, 3);
            this.dtgvDSNhanVien.Name = "dtgvDSNhanVien";
            this.dtgvDSNhanVien.RowHeadersWidth = 51;
            this.dtgvDSNhanVien.RowTemplate.Height = 24;
            this.dtgvDSNhanVien.Size = new System.Drawing.Size(479, 524);
            this.dtgvDSNhanVien.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txbMaNV);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(546, 46);
            this.panel3.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCapNhatPC);
            this.panel1.Controls.Add(this.btnXoaPC);
            this.panel1.Controls.Add(this.btnThemPC);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgvDSNhanVien);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 530);
            this.panel1.TabIndex = 1;
            // 
            // btnCapNhatPC
            // 
            this.btnCapNhatPC.Location = new System.Drawing.Point(822, 167);
            this.btnCapNhatPC.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapNhatPC.Name = "btnCapNhatPC";
            this.btnCapNhatPC.Size = new System.Drawing.Size(100, 28);
            this.btnCapNhatPC.TabIndex = 2;
            this.btnCapNhatPC.Text = "Cập nhật";
            this.btnCapNhatPC.UseVisualStyleBackColor = true;
            // 
            // btnXoaPC
            // 
            this.btnXoaPC.Location = new System.Drawing.Point(930, 167);
            this.btnXoaPC.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoaPC.Name = "btnXoaPC";
            this.btnXoaPC.Size = new System.Drawing.Size(100, 28);
            this.btnXoaPC.TabIndex = 3;
            this.btnXoaPC.Text = "Xóa";
            this.btnXoaPC.UseVisualStyleBackColor = true;
            // 
            // btnThemPC
            // 
            this.btnThemPC.Location = new System.Drawing.Point(714, 167);
            this.btnThemPC.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemPC.Name = "btnThemPC";
            this.btnThemPC.Size = new System.Drawing.Size(100, 28);
            this.btnThemPC.TabIndex = 4;
            this.btnThemPC.Text = "Thêm";
            this.btnThemPC.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(488, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 157);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.txbThoiGian);
            this.panel5.Location = new System.Drawing.Point(3, 107);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(546, 46);
            this.panel5.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txbMaDA);
            this.panel4.Location = new System.Drawing.Point(3, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(546, 46);
            this.panel4.TabIndex = 5;
            // 
            // fPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.Name = "fPhanCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân công";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNhanVien)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaDA;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbThoiGian;
        private System.Windows.Forms.DataGridView dtgvDSNhanVien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCapNhatPC;
        private System.Windows.Forms.Button btnXoaPC;
        private System.Windows.Forms.Button btnThemPC;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
    }
}