using lab04.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab04
{
    public partial class Form1 : Form
    {
        StudentContextDB db;
        public Form1()
        {
            InitializeComponent();
            db = new StudentContextDB();    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                StudentContextDB context = new StudentContextDB();
                List<Faculty> listFalcultys = context.Faculties.ToList(); //lấy các khoa
                List<Student> listStudent = context.Students.ToList(); //lấy sinh viên
                FillFalcultyCombobox(listFalcultys);
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FillFalcultyCombobox(List<Faculty> listFalcultys)
        {
            this.cmbKhoa.DataSource = listFalcultys;
            this.cmbKhoa.DisplayMember = "FacultyName";
            this.cmbKhoa.ValueMember = "FacultyID";
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvSinhvien.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvSinhvien.Rows.Add();
                dgvSinhvien.Rows[index].Cells[0].Value = item.StudentID;
                dgvSinhvien.Rows[index].Cells[1].Value = item.FullName;
                dgvSinhvien.Rows[index].Cells[2].Value = item.AverageScore;
                dgvSinhvien.Rows[index].Cells[3].Value = item.Gender;
                dgvSinhvien.Rows[index].Cells[4].Value = item.Faculty.FacultyName;s
                
            }
        }
    

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> studentList = db.Students.ToList();

                if (studentList.Any(s => s.StudentID == txtMSSV.Text))
                {
                    MessageBox.Show("Mã SV đã tồn tại. Vui lòng nhập mã khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newStudent = new Student
                {
                    StudentID = txtMSSV.Text,
                    FullName = txtHT.Text,
                    Gender = rdbNAM.Checked ? "Male" : "Female",
                    FacultyID = int.Parse(cmbKhoa.SelectedValue.ToString()),
                    AverageScore = double.Parse(txtDTB.Text)
                };

                db.Students.Add(newStudent);
                db.SaveChanges();

                LoadData(db.Students.ToList());

                CountMaleFemaleStudents();

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm dữ liệu: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CountMaleFemaleStudents()
        {
            throw new NotImplementedException();
        }

        private void LoadData(List<Student> students)
        {
            throw new NotImplementedException();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void dgvSinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhvien.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells[0].Value.ToString();
                txtHT.Text = row.Cells[1].Value.ToString();
                string gender = row.Cells[2].Value.ToString();
                if (gender == "Nam")
                {
                    rdbNAM.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                cmbKhoa.Text = row.Cells[4].Value.ToString();
                txtDTB.Text = row.Cells[3].Value.ToString();

                txtMSSV.Enabled = false;
                btnThem.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMSSV.Text))
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa.");
                return;
            }
            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    List<Student> studentlist = db.Students.ToList();
                    var student = studentlist.FirstOrDefault(s => s.StudentID == txtMSSV.Text);

                    if (student != null)
                    {
                        db.Students.Remove(student);
                        db.SaveChanges();

                       LoadData(db.Students.ToList());
                        CountMaleFemaleStudents();

                        MessageBox.Show("Sinh viên được xoá thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sinh viên không tồn tại!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            txtMSSV.Enabled = true;
            btnThem.Enabled = true;
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                List<Student> studentList = db.Students.ToList();

                var student = studentList.FirstOrDefault(s => s.StudentID == txtMSSV.Text);

                if (student != null)
                {                 
                    if(studentList.Any(s => s.StudentID == txtMSSV.Text && s.StudentID != student.StudentID))
                    {
                        MessageBox.Show("Mã Sv đã tồn tại.Vui lòng nhập một mã khác.!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
   
                    string selectedGender = rdbNAM.Checked ? "Nam" : "Nữ";
                    // Update student info
                    student.FullName = txtHT.Text;
                    student.Gender = selectedGender;
                    student.FacultyID = int.Parse(cmbKhoa.SelectedValue.ToString());
                    student.AverageScore = double.Parse(txtDTB.Text);

                    db.SaveChanges();


                    LoadData(db.Students.ToList());
                    CountMaleFemaleStudents();

                    MessageBox.Show("Chỉnh sửa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        

        txtMSSV.Enabled = true;
            btnThem.Enabled = true;
        }
    }
    
}
