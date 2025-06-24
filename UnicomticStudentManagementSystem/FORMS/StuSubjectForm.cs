using StudentManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.MODELS;

namespace StudentManagementSystem.FORMS
{
    public partial class StuSubjectForm : Form
    {
        public StuSubjectForm()
        {
            InitializeComponent();
        }

        


        private void StuSubjectForm_Load(object sender, EventArgs e)
        {
            dgvSubjects.CellClick += dgvSubjects_CellClick; // ✅ Important
            LoadCourses();
            LoadSubjects();

            // ✅ Role-based Access
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                txtSubjectName.ReadOnly = true;
                cmbCourse.Enabled = false;
                dgvSubjects.ReadOnly = true;
            }
        }

        private void LoadCourses()
        {
            cmbCourse.Items.Clear();
            var courses = StuCourseController.GetAll();

            foreach (var course in courses)
                cmbCourse.Items.Add(new KeyValuePair<int, string>(course.StuCourseId, course.StuCourseName));

            cmbCourse.DisplayMember = "Value";
            cmbCourse.ValueMember = "Key";

            if (cmbCourse.Items.Count > 0)
                cmbCourse.SelectedIndex = 0;
        }

        private void LoadSubjects()
        {
            dgvSubjects.Rows.Clear();
            dgvSubjects.Columns.Clear();

            dgvSubjects.Columns.Add("StuSubjectId", "Subject ID");
            dgvSubjects.Columns.Add("StuSubjectName", "Subject Name");
            dgvSubjects.Columns.Add("CourseName", "Course");

            var subjects = StuSubjectController.GetAll();
            foreach (var sub in subjects)
            {
                string courseName = StuCourseController.GetCourseNameById(sub.StuCourseId) ?? "Unknown";
                dgvSubjects.Rows.Add(sub.StuSubjectId, sub.StuSubjectName, courseName);
            }
        }

        private void dgvSubjects_CellClick(object? sender, DataGridViewCellEventArgs e) // ✅ Fix CS8622
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSubjects.Rows[e.RowIndex];
                txtSubjectName.Text = row.Cells["StuSubjectName"].Value?.ToString() ?? "";
                txtSubjectName.Tag = row.Cells["StuSubjectId"].Value;

                string courseName = row.Cells["CourseName"].Value?.ToString() ?? "";

                for (int i = 0; i < cmbCourse.Items.Count; i++)
                {
                    if (cmbCourse.Items[i] is KeyValuePair<int, string> course && course.Value == courseName)
                    {
                        cmbCourse.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CanModify()) return;

            if (string.IsNullOrWhiteSpace(txtSubjectName.Text) || cmbCourse.SelectedItem == null)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (cmbCourse.SelectedItem is not KeyValuePair<int, string> selectedCourse)
            {
                MessageBox.Show("Invalid course selected.");
                return;
            }

            var subject = new StuSubject
            {
                StuSubjectName = txtSubjectName.Text.Trim(),
                StuCourseId = selectedCourse.Key
            };

            StuSubjectController.Insert(subject);
            LoadSubjects();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CanModify()) return;

            if (txtSubjectName.Tag == null || !int.TryParse(txtSubjectName.Tag.ToString(), out int subjectId))
            {
                MessageBox.Show("Please select a subject to update.");
                return;
            }

            if (cmbCourse.SelectedItem is not KeyValuePair<int, string> selectedCourse)
            {
                MessageBox.Show("Invalid course selected.");
                return;
            }

            var subject = new StuSubject
            {
                StuSubjectId = subjectId,
                StuSubjectName = txtSubjectName.Text.Trim(),
                StuCourseId = selectedCourse.Key
            };

            StuSubjectController.Update(subject);
            LoadSubjects();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!CanModify()) return;

            if (txtSubjectName.Tag == null || !int.TryParse(txtSubjectName.Tag.ToString(), out int subjectId))
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }

            StuSubjectController.Delete(subjectId);
            LoadSubjects();
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtSubjectName.Clear();
            txtSubjectName.Tag = null;
            if (cmbCourse.Items.Count > 0)
                cmbCourse.SelectedIndex = 0;
        }

        private bool CanModify()
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You cannot perform this action.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
