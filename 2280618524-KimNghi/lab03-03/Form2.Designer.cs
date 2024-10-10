namespace lab03_03
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grbSV = new System.Windows.Forms.GroupBox();
            this.lblMSV = new System.Windows.Forms.Label();
            this.lblTSV = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblDTB = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.txtTenSV = new System.Windows.Forms.TextBox();
            this.txtDTB = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // grbSV
            // 
            this.grbSV.Controls.Add(this.radioButton2);
            this.grbSV.Controls.Add(this.radioButton1);
            this.grbSV.Controls.Add(this.txtDTB);
            this.grbSV.Controls.Add(this.txtTenSV);
            this.grbSV.Controls.Add(this.txtMaSV);
            this.grbSV.Controls.Add(this.cmbKhoa);
            this.grbSV.Controls.Add(this.lblDTB);
            this.grbSV.Controls.Add(this.lblK);
            this.grbSV.Controls.Add(this.lblGT);
            this.grbSV.Controls.Add(this.lblTSV);
            this.grbSV.Controls.Add(this.lblMSV);
            this.grbSV.Location = new System.Drawing.Point(37, 27);
            this.grbSV.Name = "grbSV";
            this.grbSV.Size = new System.Drawing.Size(450, 338);
            this.grbSV.TabIndex = 1;
            this.grbSV.TabStop = false;
            this.grbSV.Text = "Thông tin sinh viên";
            this.grbSV.Enter += new System.EventHandler(this.grbSV_Enter);
            // 
            // lblMSV
            // 
            this.lblMSV.AutoSize = true;
            this.lblMSV.Location = new System.Drawing.Point(36, 54);
            this.lblMSV.Name = "lblMSV";
            this.lblMSV.Size = new System.Drawing.Size(81, 16);
            this.lblMSV.TabIndex = 0;
            this.lblMSV.Text = "Mã sinh viên";
            // 
            // lblTSV
            // 
            this.lblTSV.AutoSize = true;
            this.lblTSV.Location = new System.Drawing.Point(36, 109);
            this.lblTSV.Name = "lblTSV";
            this.lblTSV.Size = new System.Drawing.Size(86, 16);
            this.lblTSV.TabIndex = 1;
            this.lblTSV.Text = "Tên sinh viên";
            // 
            // lblGT
            // 
            this.lblGT.AutoSize = true;
            this.lblGT.Location = new System.Drawing.Point(36, 166);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(54, 16);
            this.lblGT.TabIndex = 2;
            this.lblGT.Text = "Giới tính";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Location = new System.Drawing.Point(36, 220);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(38, 16);
            this.lblK.TabIndex = 3;
            this.lblK.Text = "Khoa";
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(36, 284);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(101, 16);
            this.lblDTB.TabIndex = 4;
            this.lblDTB.Text = "Điểm trung bình ";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Items.AddRange(new object[] {
            "Quản trị kinh doanh",
            "Công nghệ thông tin",
            "Công nghệ ô tô",
            "Ngôn ngữ Anh"});
            this.cmbKhoa.Location = new System.Drawing.Point(182, 212);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(234, 24);
            this.cmbKhoa.TabIndex = 5;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(182, 54);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(234, 22);
            this.txtMaSV.TabIndex = 6;
            // 
            // txtTenSV
            // 
            this.txtTenSV.Location = new System.Drawing.Point(182, 103);
            this.txtTenSV.Name = "txtTenSV";
            this.txtTenSV.Size = new System.Drawing.Size(234, 22);
            this.txtTenSV.TabIndex = 7;
            // 
            // txtDTB
            // 
            this.txtDTB.Location = new System.Drawing.Point(182, 278);
            this.txtDTB.Name = "txtDTB";
            this.txtDTB.Size = new System.Drawing.Size(234, 22);
            this.txtDTB.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(193, 164);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 20);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nam";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(332, 162);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 20);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Nữ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(37, 388);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(113, 38);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm ";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(219, 388);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(101, 38);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "Cập nhật ";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(374, 388);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 38);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbSV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.grbSV.ResumeLayout(false);
            this.grbSV.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox grbSV;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtDTB;
        private System.Windows.Forms.TextBox txtTenSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblTSV;
        private System.Windows.Forms.Label lblMSV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
    }
}