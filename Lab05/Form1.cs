using Lab05.BUS;
using Lab05.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Form1 : Form
    {
        private string folderPath; //đường dẫn của tệp Images
        private readonly StudentService studentService = new StudentService();
        private readonly FacultyService facultyService = new FacultyService();
        private QuanLySinhVienDB context = new QuanLySinhVienDB();
        public Form1()
        {
            InitializeComponent();
            // khởi tạo sự kiện mỗi khi chọn vào một dòng trên datagridview
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(dgvStudent_CellContentClick);
            this.menuDK.Click += new EventHandler(btnRegisterMajor_Click);
        }
        private void FillFalcultyCombobox(List<Faculty> listFacultys)
        {
            //listFacultys.Insert(1, new Faculty());
            this.cmbFaculty.DataSource = listFacultys;
            this.cmbFaculty.DisplayMember = "FacultyName"; // hiển thị thuộc tính tên khoa lên màn hình
            this.cmbFaculty.ValueMember = "FacultyID";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                setGridViewStyle(dgvStudent);
                var listFacultys = facultyService.GetAll();
                var listStudents = studentService.GetAll();
                FillFalcultyCombobox(listFacultys);
                BindGrid(listStudents);
                pictureBox.Image = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;
                if (item.Faculty != null)
                {
                    dgvStudent.Rows[index].Cells[2].Value =
                    item.Faculty.FacultyName;
                }
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore + "";
                if (item.MajorID.ToString() != null)
                {
                    dgvStudent.Rows[index].Cells[4].Value = item.Major.Name + "";
                }

                ShowAvatar(item.Avatar);
            }
        }

        // làm đẹp cho datagridview
        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cbChuaDK_CheckedChanged(object sender, EventArgs e)
        {
            var listStudents = new List<Student>();
            if (this.cbChuaDK.Checked)
                listStudents = studentService.GetAllHasNoMajor();
            else
                listStudents = studentService.GetAll();
            BindGrid(listStudents);
        }
        private void ShowAvatar(string ImageName)
        {
            if (string.IsNullOrEmpty(ImageName))
            {
                pictureBox.Image = null;
            }
            else
            {
                string parentDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string imagePath = Path.Combine(parentDirectory, "Images", ImageName);
                pictureBox.Image = Image.FromFile(imagePath);
                pictureBox.Refresh();
            }
        }
        private void btnMore_Click(object sender, EventArgs e)
        {
            // Đường dẫn tương đối đến thư mục "Images" trong solution
            folderPath = Path.Combine(Application.StartupPath, @"..\..\Images");
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("Thư mục ảnh không tồn tại!");
            }
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = folderPath;
            open.Filter = "Image File | *.jpg; *.png; *.gif; *.jpeg";

            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = open.FileName;
            }
        }

        private void btnAdd_Update_Click(object sender, EventArgs e)
        {
            Student s = studentService.FindByID(txtStudentID.Text);

            if (s == null)
            {
                // Thêm mới sinh viên
                s = new Student
                {
                    StudentID = txtStudentID.Text,
                    FullName = txtName.Text,
                    FacultyID = int.Parse(cmbFaculty.SelectedValue.ToString()),
                    AverageScore = float.Parse(txtAverageScore.Text),
                    MajorID = 0,
                    Avatar = pictureBox.ImageLocation
                };
                MessageBox.Show("Thêm thông tin thành công!", "Thông Báo", MessageBoxButtons.OK);
                Form1_Load(sender, e);
            }
            else
            {
                // Cập nhật thông tin sinh viên
                s.FullName = txtName.Text;
                int newFacultyID = int.Parse(cmbFaculty.SelectedValue.ToString());
                if (s.FacultyID != newFacultyID)
                {
                    s.FacultyID = newFacultyID;
                    s.MajorID = 0; // Đặt chuyên ngành về null nếu thay đổi khoa
                }
                s.AverageScore = float.Parse(txtAverageScore.Text);
                s.Avatar = pictureBox.ImageLocation;
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông Báo", MessageBoxButtons.OK);
                Form1_Load(sender, e);
            }

            studentService.InsertUpdate(s);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Xoá thông tin thành công!", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dlg == DialogResult.Yes) 
            { 
                Student sDelete = context.Students.FirstOrDefault(s => s.StudentID == txtStudentID.Text);
                studentService.DeleteStudent(sDelete);
                MessageBox.Show("Xoá thông tin thành công!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvStudent.Rows.Count -1)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];

                txtStudentID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                cmbFaculty.Text = row.Cells[2].Value.ToString();
                txtAverageScore.Text = row.Cells[3].Value.ToString();

                string studentId = row.Cells[0].Value.ToString();
                string imagePath = studentService.fileFath(studentId);
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                }
                else
                {
                    pictureBox.Image = null;
                }
                pictureBox.Refresh();
            }
        }


        private void btnRegisterMajor_Click(object sender, EventArgs e)
        {
            this.Hide();
            register reg = new register();
            reg.ShowDialog();           
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuDK_Click(object sender, EventArgs e)
        {

        }
    }
}
