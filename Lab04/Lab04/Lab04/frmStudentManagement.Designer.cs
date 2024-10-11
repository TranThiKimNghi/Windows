namespace Lab04
{
    partial class frmStudentManagement
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
            this.dgvSinhVien = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTinSV = new System.Windows.Forms.GroupBox();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtDiemTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).BeginInit();
            this.grbThongTinSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSinhVien
            // 
            this.dgvSinhVien.AllowUserToAddRows = false;
            this.dgvSinhVien.AllowUserToDeleteRows = false;
            this.dgvSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhVien.Location = new System.Drawing.Point(494, 102);
            this.dgvSinhVien.Name = "dgvSinhVien";
            this.dgvSinhVien.ReadOnly = true;
            this.dgvSinhVien.RowHeadersWidth = 51;
            this.dgvSinhVien.RowTemplate.Height = 24;
            this.dgvSinhVien.Size = new System.Drawing.Size(731, 401);
            this.dgvSinhVien.TabIndex = 0;
            this.dgvSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhVien_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(340, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý thông tin sinh viên";
            // 
            // grbThongTinSV
            // 
            this.grbThongTinSV.Controls.Add(this.cmbKhoa);
            this.grbThongTinSV.Controls.Add(this.txtDiemTB);
            this.grbThongTinSV.Controls.Add(this.label4);
            this.grbThongTinSV.Controls.Add(this.txtHoTen);
            this.grbThongTinSV.Controls.Add(this.label5);
            this.grbThongTinSV.Controls.Add(this.label3);
            this.grbThongTinSV.Controls.Add(this.txtMaSV);
            this.grbThongTinSV.Controls.Add(this.label2);
            this.grbThongTinSV.Location = new System.Drawing.Point(26, 102);
            this.grbThongTinSV.Name = "grbThongTinSV";
            this.grbThongTinSV.Size = new System.Drawing.Size(444, 356);
            this.grbThongTinSV.TabIndex = 2;
            this.grbThongTinSV.TabStop = false;
            this.grbThongTinSV.Text = "Thông tin sinh viên";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(133, 200);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(261, 30);
            this.cmbKhoa.TabIndex = 3;
            // 
            // txtDiemTB
            // 
            this.txtDiemTB.Location = new System.Drawing.Point(133, 267);
            this.txtDiemTB.Name = "txtDiemTB";
            this.txtDiemTB.Size = new System.Drawing.Size(213, 30);
            this.txtDiemTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Điểm TB:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(133, 133);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(261, 30);
            this.txtHoTen.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Khoa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Họ tên:";
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(133, 66);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(213, 30);
            this.txtMaSV.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(149, 464);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 36);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(258, 464);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(103, 36);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(367, 464);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 36);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1084, 509);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(141, 36);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 555);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbThongTinSV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSinhVien);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.frmStudentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhVien)).EndInit();
            this.grbThongTinSV.ResumeLayout(false);
            this.grbThongTinSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhVien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTinSV;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtDiemTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

