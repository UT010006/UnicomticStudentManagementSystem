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
            LoadCourses();
            LoadSubjects();

            // ✅ Role-Based Access
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
            {
                cmbCourse.Items.Add(new KeyValuePair<int, string>(course.StuCourseId, course.StuCourseName));
            }

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You cannot add subjects.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        private void dgvSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvSubjects.Rows[e.RowIndex];

                txtSubjectName.Text = row.Cells["StuSubjectName"].Value?.ToString() ?? string.Empty;
                txtSubjectName.Tag = row.Cells["StuSubjectId"].Value;

                string courseName = row.Cells["CourseName"].Value?.ToString() ?? string.Empty;

                for (int i = 0; i < cmbCourse.Items.Count; i++)
                {
                    if (cmbCourse.Items[i] is KeyValuePair<int, string> coursePair && coursePair.Value == courseName)
                    {
                        cmbCourse.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You cannot update subjects.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSubjectName.Tag == null || !int.TryParse(txtSubjectName.Tag.ToString(), out int subjectId))
            {
                MessageBox.Show("Invalid or missing subject ID.");
                return;
            }

            if (cmbCourse.SelectedItem is not KeyValuePair<int, string> selectedCourse)
            {
                MessageBox.Show("Please select a valid course.");
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
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You cannot delete subjects.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtSubjectName.Tag == null || !int.TryParse(txtSubjectName.Tag.ToString(), out int id))
            {
                MessageBox.Show("Invalid subject ID.");
                return;
            }

            StuSubjectController.Delete(id);
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
    }
}
