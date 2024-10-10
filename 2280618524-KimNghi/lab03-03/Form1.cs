using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 formSinhVien = new Form2();

           
            if (formSinhVien.ShowDialog() == DialogResult.OK)
            {
                
                foreach (DataGridViewRow row in dgvSinhVien.Rows)
                {
                    if (row.Cells["Column2"].Value?.ToString() == formSinhVien.MaSV)
                    {
                        MessageBox.Show("Mã số sinh viên đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

               
                string maSoSV = formSinhVien.MaSV;
                string tenSinhVien = formSinhVien.TenSV;
                string gioitinh = formSinhVien.Gioitinh;
                double diemTB = formSinhVien.DTB;
                string khoa = formSinhVien.Khoa;
            
                dgvSinhVien.Rows.Add(dgvSinhVien.Rows.Count + 1, maSoSV, tenSinhVien, gioitinh, diemTB, khoa);
                UpdateStudentCount();
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

          
            if (result == DialogResult.Yes)
            {
               
                Application.Exit();
            }
            else
            {
                this.Close();   
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            toolStripTextBox1.Text = "0";
            toolStripTextBox2.Text = "0";
        }
        private void UpdateStudentCount() 
        {
            int countMale = 0;
            int countFemale = 0;

            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.Cells["Column4"].Value?.ToString() == "Nam")
                    countMale++;
                else if (row.Cells["Column4"].Value?.ToString() == "Nữ")
                    countFemale++;
            }

            toolStripLabel1.Text = $"Tổng số SV Nam: {countMale}";
            toolStripLabel1.Text = $"Tổng số SV Nữ: {countFemale}";
        }

private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            string searchText = toolStripTextBox3.Text.ToLower();
            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                row.Visible = row.Cells["Column3"].Value.ToString().ToLower().Contains(searchText);
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int xuatSacCount = 0;
            int gioiCount = 0;
            int khaCount = 0;
            int trungBinhCount = 0;
            int yeuCount = 0;
            int kemCount = 0;
            string Thongke = toolStripTextBox4.Text.ToLower();

            foreach (DataGridViewRow row in dgvSinhVien.Rows)
            {
                if (row.Cells["Column5"].Value != null && double.TryParse(row.Cells["Column5"].Value.ToString(), out double diemTB))
                {
                    if (diemTB >= 9.0)
                        xuatSacCount++;
                    else if (diemTB >= 8.0)
                        gioiCount++;
                    else if (diemTB >= 7.0)
                        khaCount++;
                    else if (diemTB >= 5.0)
                        trungBinhCount++;
                    else if (diemTB >= 4.0)
                        yeuCount++;
                    else
                        kemCount++;
                }
            }

            string message = $"Số lượng sinh viên:\n" +
                             $"- Xuất sắc: {xuatSacCount}\n" +
                             $"- Giỏi: {gioiCount}\n" +
                             $"- Khá: {khaCount}\n" +
                             $"- Trung bình: {trungBinhCount}\n" +
                             $"- Yếu: {yeuCount}\n" +
                             $"- Kém: {kemCount}";

            MessageBox.Show(message, "Thống kê xếp loại sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}


