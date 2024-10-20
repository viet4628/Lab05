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
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {
            List<Faculty> faculties = qlSinhVien.Faculties.ToList();
            List<Major> majors = qlSinhVien.Majors.ToList();
            fillFaculty(faculties);
            fillMajor(majors);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
