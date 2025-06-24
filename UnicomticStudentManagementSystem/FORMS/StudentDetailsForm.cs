using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using StudentManagementSystem.Controllers;
using StudentManagementSystem.MODELS;

namespace StudentManagementSystem.FORMS
{
    public partial class StudentDetailsForm : Form
    {
        public StudentDetailsForm()
        {
            InitializeComponent();
        }

        private void StudentDetailsForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadStudents();

            // ✅ Apply role-based restrictions
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnClear.Enabled = false;

                txtStuName.ReadOnly = true;
                cmbCourse.Enabled = false;
                dgvStudents.ReadOnly = true;
            }
        }

        private void LoadCourses()
        {
            cmbCourse.Items.Clear();

            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "SELECT StuCourseId, StuCourseName FROM StudentCourse";

                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        cmbCourse.Items.Add(new ComboBoxItem
                        {
                            Text = reader["StuCourseName"]?.ToString() ?? string.Empty,
                            Value = reader["StuCourseId"]?.ToString() ?? string.Empty
                        });
                    }
                }
            }

            if (cmbCourse.Items.Count > 0)
                cmbCourse.SelectedIndex = 0;
        }

        private void LoadStudents()
        {
            dgvStudents.Rows.Clear();
            dgvStudents.Columns.Clear();

            using (var con = DatabaseManagement.GetConnection())
            {
                string query = @"SELECT s.StuId, s.StuName, c.StuCourseName 
                                 FROM StudentDetails s
                                 JOIN StudentCourse c ON s.StuCourseId = c.StuCourseId";

                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    dgvStudents.Columns.Add("StuId", "ID");
                    dgvStudents.Columns.Add("StuName", "Name");
                    dgvStudents.Columns.Add("StuCourseName", "Course");

                    while (reader.Read())
                    {
                        dgvStudents.Rows.Add(
                            reader["StuId"]?.ToString() ?? "0",
                            reader["StuName"]?.ToString() ?? string.Empty,
                            reader["StuCourseName"]?.ToString() ?? string.Empty
                        );
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You are not allowed to add students.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtStuName.Text) || cmbCourse.SelectedItem is not ComboBoxItem selectedCourse)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "INSERT INTO StudentDetails (StuName, StuCourseId) VALUES (@name, @courseId)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", txtStuName.Text.Trim());
                    cmd.Parameters.AddWithValue("@courseId", selectedCourse.Value);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadStudents();
            ClearForm();
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtStuName.Text = dgvStudents.Rows[e.RowIndex].Cells["StuName"].Value?.ToString() ?? string.Empty;
                string courseName = dgvStudents.Rows[e.RowIndex].Cells["StuCourseName"].Value?.ToString() ?? string.Empty;

                foreach (ComboBoxItem item in cmbCourse.Items)
                {
                    if (item.Text == courseName)
                    {
                        cmbCourse.SelectedItem = item;
                        break;
                    }
                }

                string? stuIdText = dgvStudents.Rows[e.RowIndex].Cells["StuId"].Value?.ToString();
                if (int.TryParse(stuIdText, out int stuId))
                {
                    txtStuName.Tag = stuId;
                }
                else
                {
                    txtStuName.Tag = null;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You are not allowed to update student records.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtStuName.Tag is not int stuId)
            {
                MessageBox.Show("Please select a student to update.");
                return;
            }

            if (cmbCourse.SelectedItem is not ComboBoxItem selectedCourse)
            {
                MessageBox.Show("Please select a course.");
                return;
            }

            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "UPDATE StudentDetails SET StuName=@name, StuCourseId=@courseId WHERE StuId=@id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", txtStuName.Text.Trim());
                    cmd.Parameters.AddWithValue("@courseId", selectedCourse.Value);
                    cmd.Parameters.AddWithValue("@id", stuId);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadStudents();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You are not allowed to delete student records.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtStuName.Tag is not int stuId)
            {
                MessageBox.Show("Please select a student to delete.");
                return;
            }

            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "DELETE FROM StudentDetails WHERE StuId=@id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", stuId);
                    cmd.ExecuteNonQuery();
                }
            }

            LoadStudents();
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtStuName.Clear();
            if (cmbCourse.Items.Count > 0)
                cmbCourse.SelectedIndex = 0;
            txtStuName.Tag = null;
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;

        public override string ToString() => Text;
    }
}
