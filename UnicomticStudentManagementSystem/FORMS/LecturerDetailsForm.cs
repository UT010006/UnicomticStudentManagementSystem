using StudentManagementSystem.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using StudentManagementSystem.Controllers;





namespace StudentManagementSystem.FORMS
{
    public partial class LecturerDetailsForm : Form


    {
        private LectureDetailsController controller = new LectureDetailsController();
        public LecturerDetailsForm()
        {
            InitializeComponent();
        }

        private void LecturerDetailsForm_Load(object sender, EventArgs e)
        {
            LoadLecturerData();
        }

        private void LoadLecturerData()
        {
            var lecturers = controller.GetAllLecturers();
            dataGridViewLecturers.DataSource = lecturers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Lecturer name is required.");
                return;
            }

            var lecturer = new LecturerDetails
            {
                LecturerName = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Department = txtDepartment.Text.Trim()
            };
            controller.AddLecturer(lecturer);
            ClearForm();
            LoadLecturerData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewLecturers.CurrentRow == null) return;

            var lecturer = new LecturerDetails
            {
                LecturerId = Convert.ToInt32(txtId.Text),
                LecturerName = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Department = txtDepartment.Text.Trim()
            };
            controller.UpdateLecturer(lecturer);
            ClearForm();
            LoadLecturerData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewLecturers.CurrentRow == null) return;

            int id = Convert.ToInt32(txtId.Text);
            controller.DeleteLecturer(id);
            ClearForm();
            LoadLecturerData();
        }

        private void dataGridViewLecturers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewLecturers.Rows[e.RowIndex];
                txtId.Text = row.Cells["LecturerId"].Value.ToString();
                txtName.Text = row.Cells["LecturerName"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtDepartment.Text = row.Cells["Department"].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtId.Clear();
            txtName.Clear();
            txtEmail.Clear();
            txtDepartment.Clear();
        }
    }
}

        

    

