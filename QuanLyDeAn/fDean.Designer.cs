
namespace QuanLyDeAn
{
    partial class fDean
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNgayBD = new System.Windows.Forms.TextBox();
            this.txtMaDA = new System.Windows.Forms.TextBox();
            this.txtTenDA = new System.Windows.Forms.TextBox();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.btnDeleteDA = new System.Windows.Forms.Button();
            this.btnUpdateDA = new System.Windows.Forms.Button();
            this.btnAddDeAn = new System.Windows.Forms.Button();
            this.dtgvDSDeAn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDeAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Danh sách đề án";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(800, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Phòng ban chủ trì";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(800, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(800, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên đề án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(800, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã đề án";
            // 
            // txtNgayBD
            // 
            this.txtNgayBD.Location = new System.Drawing.Point(974, 243);
            this.txtNgayBD.Name = "txtNgayBD";
            this.txtNgayBD.Size = new System.Drawing.Size(201, 26);
            this.txtNgayBD.TabIndex = 26;
            // 
            // txtMaDA
            // 
            this.txtMaDA.Location = new System.Drawing.Point(974, 111);
            this.txtMaDA.Name = "txtMaDA";
            this.txtMaDA.Size = new System.Drawing.Size(201, 26);
            this.txtMaDA.TabIndex = 24;
            // 
            // txtTenDA
            // 
            this.txtTenDA.Location = new System.Drawing.Point(974, 171);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.Size = new System.Drawing.Size(201, 26);
            this.txtTenDA.TabIndex = 25;
            // 
            // txtPhong
            // 
            this.txtPhong.Location = new System.Drawing.Point(974, 311);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(201, 26);
            this.txtPhong.TabIndex = 27;
            // 
            // btnDeleteDA
            // 
            this.btnDeleteDA.Location = new System.Drawing.Point(936, 417);
            this.btnDeleteDA.Name = "btnDeleteDA";
            this.btnDeleteDA.Size = new System.Drawing.Size(101, 41);
            this.btnDeleteDA.TabIndex = 29;
            this.btnDeleteDA.Text = "Xóa";
            this.btnDeleteDA.UseVisualStyleBackColor = true;
            this.btnDeleteDA.Click += new System.EventHandler(this.BtnDeleteDA_Click);
            // 
            // btnUpdateDA
            // 
            this.btnUpdateDA.Location = new System.Drawing.Point(1068, 417);
            this.btnUpdateDA.Name = "btnUpdateDA";
            this.btnUpdateDA.Size = new System.Drawing.Size(107, 41);
            this.btnUpdateDA.TabIndex = 30;
            this.btnUpdateDA.Text = "Cập nhật";
            this.btnUpdateDA.UseVisualStyleBackColor = true;
            this.btnUpdateDA.Click += new System.EventHandler(this.BtnUpdateDA_Click);
            // 
            // btnAddDeAn
            // 
            this.btnAddDeAn.Location = new System.Drawing.Point(804, 417);
            this.btnAddDeAn.Name = "btnAddDeAn";
            this.btnAddDeAn.Size = new System.Drawing.Size(95, 41);
            this.btnAddDeAn.TabIndex = 28;
            this.btnAddDeAn.Text = "Thêm";
            this.btnAddDeAn.UseVisualStyleBackColor = true;
            this.btnAddDeAn.Click += new System.EventHandler(this.BtnAddDeAn_Click);
            // 
            // dtgvDSDeAn
            // 
            this.dtgvDSDeAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSDeAn.Location = new System.Drawing.Point(46, 89);
            this.dtgvDSDeAn.Name = "dtgvDSDeAn";
            this.dtgvDSDeAn.ReadOnly = true;
            this.dtgvDSDeAn.RowHeadersWidth = 62;
            this.dtgvDSDeAn.RowTemplate.Height = 28;
            this.dtgvDSDeAn.Size = new System.Drawing.Size(681, 537);
            this.dtgvDSDeAn.TabIndex = 36;
            // 
            // fDean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 676);
            this.Controls.Add(this.dtgvDSDeAn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNgayBD);
            this.Controls.Add(this.txtMaDA);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.btnDeleteDA);
            this.Controls.Add(this.btnUpdateDA);
            this.Controls.Add(this.btnAddDeAn);
            this.Name = "fDean";
            this.Text = "fDean";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSDeAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNgayBD;
        private System.Windows.Forms.TextBox txtMaDA;
        private System.Windows.Forms.TextBox txtTenDA;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Button btnDeleteDA;
        private System.Windows.Forms.Button btnUpdateDA;
        private System.Windows.Forms.Button btnAddDeAn;
        private System.Windows.Forms.DataGridView dtgvDSDeAn;
    }
}