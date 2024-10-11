using Lab04.Model;
using Lab04.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04
{
    public partial class frmStudentManagement : Form
    {
        private List<SinhVienVeiwModel> students;
        private List<KhoaForComboBoxViewModel> facultiesForComboBox;
        private StudentContextDB db;

        public frmStudentManagement()
        {
            InitializeComponent();

            db = new StudentContextDB();

            LoadStudents();
            LoadFacultiesForComboBox();
        }

        private void LoadStudents()
        {
            students = db.Students.Select(sv => new SinhVienVeiwModel
            {
                MaSV = sv.StudentID,
                HoTen = sv.FullName,
                TenKhoa = sv.Faculty.FacultyName,
                DiemTB = (sv.AverageScore ?? 0).ToString(),
            }).ToList();
        }

        private void LoadFacultiesForComboBox()
        {
            facultiesForComboBox = db.Faculties.Select(c => new KhoaForComboBoxViewModel
            {
                MaKhoa = c.FacultyID,
                TenKhoa = c.FacultyName,
            }).ToList();
        }

        private void frmStudentManagement_Load(object sender, EventArgs e)
        {
            BindGrid(students);
            FillFacultyComboBox(facultiesForComboBox);
        }

        private void BindGrid(List<SinhVienVeiwModel> students)
        {
            dgvSinhVien.DataSource = students;
        }

        private void FillFacultyComboBox(List<KhoaForComboBoxViewModel> faculties)
        {
            cmbKhoa.DataSource = faculties;
            cmbKhoa.ValueMember = "MaKhoa";
            cmbKhoa.DisplayMember = "TenKhoa";
        }

        private bool KiemTraRangBuoc()
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text) || txtMaSV.Text.Length != 10)
            {
                MessageBox.Show("Mã sinh viên phải có 10 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSV.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }
            float DiemTB;
            if (!float.TryParse(txtDiemTB.Text, out DiemTB) || DiemTB < 0 || DiemTB > 10) 
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10 và không phải là kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiemTB.Focus();
                return false;
            }
            return true;
        }

        private void Reset()
        {
            txtMaSV.Clear();
            txtHoTen.Clear();
            cmbKhoa.SelectedIndex = 0;
            txtDiemTB.Clear();
            dgvSinhVien.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraRangBuoc()) return;
            string maSV = txtMaSV.Text;
            var timSV = db.Students.Find(maSV);

            if(timSV != null)
            {
                MessageBox.Show("Sinh viên đã tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var student = new Student
            {
                StudentID = txtMaSV.Text,
                FullName = txtHoTen.Text,
                FacultyID = (cmbKhoa.SelectedItem as KhoaForComboBoxViewModel).MaKhoa,
                AverageScore = double.Parse(txtDiemTB.Text),
            };
            db.Students.Add(student);
            db.SaveChanges();
            RefreshData();
            MessageBox.Show("Thêm sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Reset();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KiemTraRangBuoc()) return;

            string maSV = txtMaSV.Text;
            var student = db.Students.Find(maSV);

            if (student == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn sửa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                student.FullName = txtHoTen.Text;
                student.FacultyID = (cmbKhoa.SelectedItem as KhoaForComboBoxViewModel).MaKhoa;
                student.AverageScore = double.Parse(txtDiemTB.Text);
                db.SaveChanges();
                RefreshData();
                MessageBox.Show("Sửa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;
            var student = db.Students.Find(maSV);

            if (student == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn xóa?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                db.Students.Remove(student);
                db.SaveChanges();
                RefreshData();
                MessageBox.Show("Xóa sinh viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtHoTen.Text = row.Cells[1].Value.ToString();
                cmbKhoa.Text = row.Cells[2].Value.ToString();
                txtDiemTB.Text = row.Cells[3].Value.ToString();
            }
        }

        private void RefreshData()
        {
            LoadStudents();
            BindGrid(students);
        }
    }
}
