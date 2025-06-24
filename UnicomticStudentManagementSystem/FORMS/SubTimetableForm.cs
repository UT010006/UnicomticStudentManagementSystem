using Dapper;
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
    public partial class SubTimetableForm : Form
    {
        public SubTimetableForm()
        {
            InitializeComponent();
        }

        private void SubTimetableForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadRooms();
            LoadTimetables();

            // 🧠 Wire CellClick
            dataGridViewSubTimetable.CellClick += dataGridViewSubTimetable_CellClick;

            // ✅ Role-based restriction
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                cmbSubject.Enabled = false;
                cmbRoom.Enabled = false;
                txtTimeslot.ReadOnly = true;
                dataGridViewSubTimetable.ReadOnly = true;
            }
        }

        private void LoadSubjects()
        {
            using var con = DatabaseManagement.GetConnection();
            var subjects = con.Query("SELECT StuSubjectId, StuSubjectName FROM StuSubject").ToList();
            cmbSubject.DataSource = subjects;
            cmbSubject.DisplayMember = "StuSubjectName";
            cmbSubject.ValueMember = "StuSubjectId";
            cmbSubject.SelectedIndex = -1;
        }

        private void LoadRooms()
        {
            using var con = DatabaseManagement.GetConnection();
            var rooms = con.Query("SELECT RoomId, RoomName FROM SubRoom").ToList();
            cmbRoom.DataSource = rooms;
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomId";
            cmbRoom.SelectedIndex = -1;
        }

        private void LoadTimetables()
        {
            dataGridViewSubTimetable.DataSource = SubTimetableController.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You are not allowed to add timetables.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbSubject.SelectedIndex == -1 || cmbRoom.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtTimeslot.Text))
            {
                MessageBox.Show("Please fill all fields!");
                return;
            }

            var timetable = new SubTimetable
            {
                StuSubjectId = Convert.ToInt32(cmbSubject.SelectedValue),
                SubTimeslot = txtTimeslot.Text.Trim(),
                RoomId = Convert.ToInt32(cmbRoom.SelectedValue)
            };

            if (SubTimetableController.Insert(timetable))
            {
                MessageBox.Show("Timetable Added Successfully");
                ClearForm();
                LoadTimetables();
            }
            else
            {
                MessageBox.Show("Failed to add timetable.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You are not allowed to delete timetables.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtTimeslot.Tag == null || !int.TryParse(txtTimeslot.Tag.ToString(), out int id))
            {
                MessageBox.Show("Please select a timetable to delete.");
                return;
            }

            if (SubTimetableController.Delete(id))
            {
                MessageBox.Show("Deleted Successfully");
                ClearForm();
                LoadTimetables();
            }
            else
            {
                MessageBox.Show("Delete failed.");
            }
        }

        private void dataGridViewSubTimetable_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewSubTimetable.Rows[e.RowIndex];

                txtTimeslot.Text = row.Cells["SubTimeslot"].Value?.ToString() ?? string.Empty;
                txtTimeslot.Tag = row.Cells["TimetableId"].Value?.ToString() ?? string.Empty;

                string subjectName = row.Cells["SubjectName"].Value?.ToString() ?? string.Empty;
                for (int i = 0; i < cmbSubject.Items.Count; i++)
                {
                    var item = cmbSubject.Items[i];
                    if (item != null)
                    {
                        var prop = TypeDescriptor.GetProperties(item)["StuSubjectName"];
                        if (prop != null && prop.GetValue(item)?.ToString() == subjectName)
                        {
                            cmbSubject.SelectedIndex = i;
                            break;
                        }
                    }
                }

                string roomName = row.Cells["RoomName"].Value?.ToString() ?? string.Empty;
                for (int i = 0; i < cmbRoom.Items.Count; i++)
                {
                    var item = cmbRoom.Items[i];
                    if (item != null)
                    {
                        var prop = TypeDescriptor.GetProperties(item)["RoomName"];
                        if (prop != null && prop.GetValue(item)?.ToString() == roomName)
                        {
                            cmbRoom.SelectedIndex = i;
                            break;
                        }
                    }
                }
            }
        }

        private void ClearForm()
        {
            txtTimeslot.Clear();
            txtTimeslot.Tag = null;
            cmbSubject.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
        }
    }
}
