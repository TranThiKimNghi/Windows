using lab07.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace lab07
{
    public partial class frmSinhVien : Form
    {

        private Model1 _context = new Model1();

        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {

            List<Lop> listLop = _context.Lops.ToList();
            List<Sinhvien> listSinhvien = _context.Sinhviens.ToList();
            FillFalcultyCombobox(listLop);
            BindGrid(listSinhvien);

        }
        private void FillFalcultyCombobox(List<Lop> listLop)
        {
            this.cmbLop.DataSource = listLop;
            this.cmbLop.DisplayMember = "TenLop";
            this.cmbLop.ValueMember = "MaLop";
        }
        private void BindGrid(List<Sinhvien> listSinhvien)
        {
            dgvSinhvien.Rows.Clear();
            foreach (var item in listSinhvien)
            {
                int index = dgvSinhvien.Rows.Add();
                dgvSinhvien.Rows[index].Cells[0].Value = item.MaSV;
                dgvSinhvien.Rows[index].Cells[1].Value = item.HotenSV;
                dgvSinhvien.Rows[index].Cells[2].Value = item.ngaySinh;
                dgvSinhvien.Rows[index].Cells[3].Value = item.Lop.TenLop;


            }
        }


        private bool CheckIdSinhVien(string idNewStudent)
        {
            int length = dgvSinhvien.Rows.Count;
            for (int i = 0; i < length; i++)
            {
                if (dgvSinhvien.Rows[i].Cells[0].Value != null)
                {
                    if (dgvSinhvien.Rows[i].Cells[0].Value.ToString() == idNewStudent)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhvien.SelectedRows.Count > 0)
            {
                string selectedStudentID = dgvSinhvien.SelectedRows[0].Cells[0].Value.ToString();
                Sinhvien deleteSv = _context.Sinhviens.FirstOrDefault(s => s.MaSV == selectedStudentID);

                if (deleteSv != null)
                {
                    DialogResult confirmResult = MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {deleteSv.HotenSV}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (confirmResult == DialogResult.Yes)
                    {

                        _context.Sinhviens.Remove(deleteSv);

                        try
                        {
                            _context.SaveChanges();

                            loaddgvSinhVien();

                            MessageBox.Show($"Xóa sinh viên {deleteSv.HotenSV} thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Có lỗi xảy ra khi xóa sinh viên: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                _context.SaveChanges();
                MessageBox.Show("Lưu thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgvSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi lưu: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btKhong_Click(object sender, EventArgs e)
        {

            try
            {
                var entries = _context.ChangeTracker.Entries().Where(entryState => entryState.State != EntityState.Unchanged).ToList();

                foreach (var entry in entries)
                {
                    switch (entry.State)
                    {
                        case EntityState.Modified:
                            entry.CurrentValues.SetValues(entry.OriginalValues);
                            entry.State = EntityState.Unchanged;
                            break;
                        case EntityState.Added:
                            entry.State = EntityState.Detached;
                            break;
                        case EntityState.Deleted:
                            entry.State = EntityState.Unchanged;
                            break;
                    }
                }

                MessageBox.Show("Bỏ thay đổi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loaddgvSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi bỏ thay đổi: {ex.Message}", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void btSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhvien.SelectedRows.Count > 0)
            {
                if (CheckDataInput())
                {

                    string selectedStudentID = dgvSinhvien.SelectedRows[0].Cells[0].Value.ToString();
                    Sinhvien updateSv = _context.Sinhviens.FirstOrDefault(s => s.MaSV == selectedStudentID);
                    if (updateSv != null)
                    {
                        DialogResult confirmResult = MessageBox.Show($"Bạn có chắc muốn sửa thông tin của sinh viên {updateSv.HotenSV}?", "Xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmResult == DialogResult.Yes)
                        {
                            updateSv.HotenSV = txtHotenSV.Text;
                            updateSv.ngaySinh = dtNgaysinh.Value;
                            updateSv.MaLop = cmbLop.SelectedValue.ToString();

                            _context.Sinhviens.Add(updateSv); ;
                            loaddgvSinhVien();
                            loadForm();

                            MessageBox.Show($"Chỉnh sửa dữ liệu sinh viên {updateSv.HotenSV} thành công!",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
        
        private void btThem_Click(object sender, EventArgs e)
        {
            if (CheckDataInput())
            {
                if (!CheckIdSinhVien(txtMaSV.Text))
                {
                    Sinhvien sv  = new Sinhvien();
                    sv.MaSV = txtMaSV.Text;
                    sv.HotenSV = txtHotenSV.Text;
                    sv.ngaySinh = dtNgaysinh.Value;
                    sv.MaLop = cmbLop.SelectedValue.ToString();

                    _context.Sinhviens.Add(sv);
                    loaddgvSinhVien();
                    loadForm();
                    MessageBox.Show($"Thêm sinh viên {sv.HotenSV} vào danh sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Sinh viên có mã số {txtMaSV.Text} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void loadForm()
        {
            txtMaSV.Clear();
            txtHotenSV.Clear();
        }
        private void loaddgvSinhVien()
        {
            List<Sinhvien> newListStudent = _context.Sinhviens.ToList();
            BindGrid(newListStudent);
        }
        private bool CheckDataInput()
        {
            if (txtMaSV.Text == "" || txtHotenSV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đúng thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtMaSV.TextLength < 5)
            {
                MessageBox.Show("Mã số sinh viên nhập chưa đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return true;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTK.Text.Trim();

            if (!string.IsNullOrEmpty(keyword))
            {
                var searchResult = _context.Sinhviens
                    .Where(s => s.HotenSV.ToLower().Contains(keyword.ToLower()))
                    .ToList();

                if (searchResult.Count > 0)
                {
                    BindGrid(searchResult);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSinhvien.Rows.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập từ khóa để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvSinhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSinhvien.Rows[e.RowIndex];

                txtMaSV.Text = row.Cells[0].Value.ToString();
                txtHotenSV.Text = row.Cells[1].Value.ToString();
                dtNgaysinh.Value = Convert.ToDateTime(row.Cells[2].Value);
                cmbLop.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình không?", "Thoát", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
    





