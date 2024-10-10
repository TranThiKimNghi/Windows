using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lab03_03
{
    public partial class Form2 : Form
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string Khoa { get; set; }
        public string Gioitinh { get; set; }
        public double DTB { get; set; }
        public Form2()
        {
            InitializeComponent();
        }
        
        
       
        private void grbSV_Enter(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MaSV = txtMaSV.Text.Trim();
            TenSV = txtTenSV.Text.Trim();
            Khoa = cmbKhoa.SelectedItem.ToString();

            if (string.IsNullOrEmpty(MaSV) || string.IsNullOrEmpty(TenSV) || string.IsNullOrEmpty(txtDTB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if ( MaSV.Length != 10)
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (TenSV.Length < 3 || TenSV.Length > 100 )
            {
                MessageBox.Show("Tên sinh viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!double.TryParse(txtDTB.Text, out double diemTB) || diemTB < 0 || diemTB > 10)
            {
                MessageBox.Show("Điểm trung bình không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DTB = diemTB;

            if (radioButton1.Checked)
            {
                Gioitinh = "Nam";
            }
            else if (radioButton2.Checked)
            {
                Gioitinh = "Nữ";
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
                cmbKhoa.SelectedItem = "Công nghệ thông tin"; 
            
                radioButton2.Checked = true;

            }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
    }
    }


