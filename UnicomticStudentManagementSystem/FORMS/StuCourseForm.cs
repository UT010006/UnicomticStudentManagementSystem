using StudentManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.MODELS;

namespace StudentManagementSystem.FORMS
{
    public partial class StuCourseForm : Form
    {
        public StuCourseForm()
        {
            InitializeComponent();
        }

        private void StuCourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();

            // ✅ Apply role-based restrictions
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;

                txtCourseName.ReadOnly = true;
                dgvCourses.ReadOnly = true;
            }
        }

        private void LoadCourses()
        {
            dgvCourses.Rows.Clear();
            dgvCourses.Columns.Clear();
            dgvCourses.Columns.Add("StuCourseId", "ID");
            dgvCourses.Columns.Add("StuCourseName", "Course Name");

            foreach (var course in StuCourseController.GetAll())
            {
                dgvCourses.Rows.Add(course.StuCourseId, course.StuCourseName);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You cannot add courses.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Please enter course name.");
                return;
            }

            var course = new StudentCourse
            {
                StuCourseName = txtCourseName.Text.Trim()
            };

            StuCourseController.Insert(course);
            LoadCourses();
            ClearForm();
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCourseName.Text = dgvCourses.Rows[e.RowIndex].Cells["StuCourseName"].Value.ToString();
                txtCourseName.Tag = dgvCourses.Rows[e.RowIndex].Cells["StuCourseId"].Value;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You cannot update courses.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCourseName.Tag == null)
            {
                MessageBox.Show("Please select a course to update.");
                return;
            }

            var course = new StudentCourse
            {
                StuCourseId = Convert.ToInt32(txtCourseName.Tag),
                StuCourseName = txtCourseName.Text.Trim()
            };

            StuCourseController.Update(course);
            LoadCourses();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You cannot delete courses.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtCourseName.Tag == null)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            int id = Convert.ToInt32(txtCourseName.Tag);
            StuCourseController.Delete(id);
            LoadCourses();
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtCourseName.Clear();
            txtCourseName.Tag = null;
        }
    }
}
