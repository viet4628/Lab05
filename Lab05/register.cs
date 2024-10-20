using Lab05.BUS;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class register : Form
    {
        QuanLySinhVienDB qlSinhVien = new QuanLySinhVienDB();
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private readonly MajorService majorService = new MajorService();
        string itemID;
        public register()
        {
            InitializeComponent();
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvStudent_CellContentClick);
        }

        private void register_Load(object sender, EventArgs e)
        {
            // load danh sách khoa vào comboBox
            var listFacultys = facultyService.GetAll();
            //Student s = studentService.FindByID(itemID);
            fillFaculty(listFacultys);
            // load danh sách các sinh viên chưa đăng ký chuyên ngành
            var listStudents = studentService.GetAllHasNoMajor();
            BindGrid(listStudents);
            cmbFaculty.SelectedItem = null;
        }

        private void fillFaculty(List<Faculty> listfaculty)
        {
            this.cmbFaculty.DataSource = listfaculty;
            this.cmbFaculty.DisplayMember = "FacultyName";
            this.cmbFaculty.ValueMember = "FacultyID";
        }
        private void fillMajor(List<Major> listMajor)
        {
            this.cmbMajor.DataSource = listMajor;
            this.cmbMajor.DisplayMember = "Name";
            this.cmbMajor.ValueMember = "MajorID";
        }
        private void BindGrid(List<Student> students)
        {
            dgvStudent.Rows.Clear();
            foreach (Student s in students)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = s.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = s.FullName;
                dgvStudent.Rows[index].Cells[2].Value = s.Faculty.FacultyName;
                dgvStudent.Rows[index].Cells[3].Value = s.AverageScore;

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvStudent.Rows.Count - 1)
            {
                DataGridViewRow selectedRow = dgvStudent.Rows[e.RowIndex];
                itemID = selectedRow.Cells[0].Value.ToString();
                string nameFaculty = selectedRow.Cells[2].Value.ToString();
                cmbFaculty.SelectedIndex = cmbFaculty.FindStringExact(nameFaculty);
            }
            else
            {
                MessageBox.Show("Đối tượng không hợp lệ!!!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (itemID != null)
            {
                Student s = studentService.FindByID(itemID);
                s.MajorID = int.Parse(cmbMajor.SelectedValue.ToString());
                studentService.InsertUpdate(s);
                MessageBox.Show("Thêm chuyên ngành thành công!!!", "Thông Báo", MessageBoxButtons.OK);
                cmbFaculty_SelectedIndexChanged(sender, e);
            }
            else
                MessageBox.Show("Đối tượng không hợp lệ!!!", "Thông Báo", MessageBoxButtons.OK);
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty selectedFaculty = cmbFaculty.SelectedItem as Faculty;
            if (selectedFaculty != null)
            {
                var listMajor = majorService.GetAllByFaculty(selectedFaculty.FacultyID);
                fillMajor(listMajor);
                var listStudents = studentService.GetAllHasNoMajor(selectedFaculty.FacultyID);
                BindGrid(listStudents);

                foreach (var row in dgvStudent.Rows)
                {
                    if (row.Equals(cmbFaculty.Equals(selectedFaculty))) 
                    Visible = true;
                }

            }
        }
    }
}
