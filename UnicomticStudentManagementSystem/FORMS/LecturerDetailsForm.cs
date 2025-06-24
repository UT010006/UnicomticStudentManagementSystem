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
            dataGridViewLecturers.CellClick += dataGridViewLecturers_CellClick; // ✅ Wire up the event
            LoadLecturerData();

            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;

                txtName.ReadOnly = true;
                txtEmail.ReadOnly = true;
                txtDepartment.ReadOnly = true;
                dataGridViewLecturers.ReadOnly = true;
            }
        }

        private void LoadLecturerData()
        {
            var lecturers = controller.GetAllLecturers();
            dataGridViewLecturers.DataSource = lecturers;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (IsAccessDenied()) return;

            var lecturer = new LecturerDetails
            {
                LecturerName = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Department = txtDepartment.Text.Trim()
            };

            controller.AddLecturer(lecturer);
            LoadLecturerData();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (IsAccessDenied()) return;

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please select a lecturer to update.");
                return;
            }

            var lecturer = new LecturerDetails
            {
                LecturerId = Convert.ToInt32(txtId.Text),
                LecturerName = txtName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Department = txtDepartment.Text.Trim()
            };

            controller.UpdateLecturer(lecturer);
            LoadLecturerData();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsAccessDenied()) return;

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Please select a lecturer to delete.");
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            controller.DeleteLecturer(id);
            LoadLecturerData();
            ClearForm();
        }

        private void dataGridViewLecturers_CellClick(object? sender, DataGridViewCellEventArgs e) // ✅ CS8622-safe
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewLecturers.Rows[e.RowIndex];
                txtId.Text = row.Cells["LecturerId"].Value?.ToString() ?? "";
                txtName.Text = row.Cells["LecturerName"].Value?.ToString() ?? "";
                txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
                txtDepartment.Text = row.Cells["Department"].Value?.ToString() ?? "";
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

        private bool IsAccessDenied()
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You are not allowed to perform this action.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return true;
            }
            return false;
        }
    }
}
