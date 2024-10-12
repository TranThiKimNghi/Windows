namespace lab04
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvSinhvien = new System.Windows.Forms.DataGridView();
            this.grbSinhvien = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNAM = new System.Windows.Forms.RadioButton();
            this.lblGT = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblDTB = new System.Windows.Forms.Label();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblKhoa = new System.Windows.Forms.Label();
            this.lblHT = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.lblTSSVN = new System.Windows.Forms.Label();
            this.lblTSSVNU = new System.Windows.Forms.Label();
            this.txtTSSVN = new System.Windows.Forms.TextBox();
            this.txtTSSVNU = new System.Windows.Forms.TextBox();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).BeginInit();
            this.grbSinhvien.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSinhvien
            // 
            this.dgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FullName,
            this.AverageScore,
            this.gender,
            this.Faculty});
            this.dgvSinhvien.Location = new System.Drawing.Point(375, 67);
            this.dgvSinhvien.Name = "dgvSinhvien";
            this.dgvSinhvien.Size = new System.Drawing.Size(536, 209);
            this.dgvSinhvien.TabIndex = 0;
            this.dgvSinhvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhvien_CellContentClick);
            // 
            // grbSinhvien
            // 
            this.grbSinhvien.Controls.Add(this.rdbNu);
            this.grbSinhvien.Controls.Add(this.rdbNAM);
            this.grbSinhvien.Controls.Add(this.lblGT);
            this.grbSinhvien.Controls.Add(this.cmbKhoa);
            this.grbSinhvien.Controls.Add(this.txtDTB);
            this.grbSinhvien.Controls.Add(this.txtHT);
            this.grbSinhvien.Controls.Add(this.txtMSSV);
            this.grbSinhvien.Controls.Add(this.lblDTB);
            this.grbSinhvien.Controls.Add(this.lblMSSV);
            this.grbSinhvien.Controls.Add(this.lblKhoa);
            this.grbSinhvien.Controls.Add(this.lblHT);
            this.grbSinhvien.Location = new System.Drawing.Point(29, 67);
            this.grbSinhvien.Name = "grbSinhvien";
            this.grbSinhvien.Size = new System.Drawing.Size(340, 249);
            this.grbSinhvien.TabIndex = 1;
            this.grbSinhvien.TabStop = false;
            this.grbSinhvien.Text = "Thông tin sinh viên ";
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(260, 126);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(39, 17);
            this.rdbNu.TabIndex = 12;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNAM
            // 
            this.rdbNAM.AutoSize = true;
            this.rdbNAM.Location = new System.Drawing.Point(144, 124);
            this.rdbNAM.Name = "rdbNAM";
            this.rdbNAM.Size = new System.Drawing.Size(47, 17);
            this.rdbNAM.TabIndex = 11;
            this.rdbNAM.TabStop = true;
            this.rdbNAM.Text = "Nam";
            this.rdbNAM.UseVisualStyleBackColor = true;
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(20, 128);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(50, 13);
            this.lblGT.TabIndex = 10;
            this.lblGT.Text = "Giới tính ";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(144, 165);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(168, 21);
            this.cmbKhoa.TabIndex = 9;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(144, 209);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(133, 20);
            this.txtDTB.TabIndex = 8;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(144, 77);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(133, 20);
            this.txtHT.TabIndex = 7;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(144, 31);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(133, 20);
            this.txtMSSV.TabIndex = 6;
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(19, 215);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(48, 13);
            this.lblDTB.TabIndex = 5;
            this.lblDTB.Text = "Điểm TB";
            // 
            // lblMSSV
            // 
            this.lblMSSV.Location = new System.Drawing.Point(19, 33);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(92, 21);
            this.lblMSSV.TabIndex = 2;
            this.lblMSSV.Text = "Mã số sinh viên ";
            // 
            // lblKhoa
            // 
            this.lblKhoa.AutoSize = true;
            this.lblKhoa.Location = new System.Drawing.Point(19, 172);
            this.lblKhoa.Name = "lblKhoa";
            this.lblKhoa.Size = new System.Drawing.Size(35, 13);
            this.lblKhoa.TabIndex = 4;
            this.lblKhoa.Text = "Khoa ";
            // 
            // lblHT
            // 
            this.lblHT.AutoSize = true;
            this.lblHT.Location = new System.Drawing.Point(19, 83);
            this.lblHT.Name = "lblHT";
            this.lblHT.Size = new System.Drawing.Size(42, 13);
            this.lblHT.TabIndex = 3;
            this.lblHT.Text = "Họ tên ";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(52, 333);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(154, 333);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(253, 333);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(635, 333);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(923, 25);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(77, 22);
            this.toolStripLabel1.Text = "Quản lý khoa";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel2.Text = "Tìm kiếm ";
            // 
            // lblTSSVN
            // 
            this.lblTSSVN.AutoSize = true;
            this.lblTSSVN.Location = new System.Drawing.Point(375, 300);
            this.lblTSSVN.Name = "lblTSSVN";
            this.lblTSSVN.Size = new System.Drawing.Size(74, 13);
            this.lblTSSVN.TabIndex = 8;
            this.lblTSSVN.Text = "Tổng SV Nam";
            // 
            // lblTSSVNU
            // 
            this.lblTSSVNU.AutoSize = true;
            this.lblTSSVNU.Location = new System.Drawing.Point(563, 300);
            this.lblTSSVNU.Name = "lblTSSVNU";
            this.lblTSSVNU.Size = new System.Drawing.Size(66, 13);
            this.lblTSSVNU.TabIndex = 9;
            this.lblTSSVNU.Text = "Tổng SV Nữ";
            // 
            // txtTSSVN
            // 
            this.txtTSSVN.Location = new System.Drawing.Point(457, 293);
            this.txtTSSVN.Name = "txtTSSVN";
            this.txtTSSVN.Size = new System.Drawing.Size(65, 20);
            this.txtTSSVN.TabIndex = 10;
            // 
            // txtTSSVNU
            // 
            this.txtTSSVNU.Location = new System.Drawing.Point(635, 293);
            this.txtTSSVNU.Name = "txtTSSVNU";
            this.txtTSSVNU.Size = new System.Drawing.Size(73, 20);
            this.txtTSSVNU.TabIndex = 11;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "MSSV";
            this.StudentID.Name = "StudentID";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Ho ten ";
            this.FullName.Name = "FullName";
            // 
            // AverageScore
            // 
            this.AverageScore.HeaderText = "Dierm";
            this.AverageScore.Name = "AverageScore";
            // 
            // gender
            // 
            this.gender.HeaderText = " Gioi tinh";
            this.gender.Name = "gender";
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Khoa";
            this.Faculty.Name = "Faculty";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 413);
            this.Controls.Add(this.txtTSSVNU);
            this.Controls.Add(this.txtTSSVN);
            this.Controls.Add(this.lblTSSVNU);
            this.Controls.Add(this.lblTSSVN);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbSinhvien);
            this.Controls.Add(this.dgvSinhvien);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Quan Ly Sinh Vien ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).EndInit();
            this.grbSinhvien.ResumeLayout(false);
            this.grbSinhvien.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSinhvien;
        private System.Windows.Forms.GroupBox grbSinhvien;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHT;
        private System.Windows.Forms.Label lblKhoa;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNAM;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Label lblTSSVN;
        private System.Windows.Forms.Label lblTSSVNU;
        private System.Windows.Forms.TextBox txtTSSVN;
        private System.Windows.Forms.TextBox txtTSSVNU;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
    }
}

