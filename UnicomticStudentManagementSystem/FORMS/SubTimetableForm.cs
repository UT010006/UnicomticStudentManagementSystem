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

            // ✅ Apply access control like StudentDetailsForm
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
            using (var con = DatabaseManagement.GetConnection())
            {
                var subjects = con.Query("SELECT StuSubjectId, StuSubjectName FROM StuSubject").ToList();
                cmbSubject.DataSource = subjects;
                cmbSubject.DisplayMember = "StuSubjectName";
                cmbSubject.ValueMember = "StuSubjectId";
            }
        }

        private void LoadRooms()
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                var rooms = con.Query("SELECT RoomId, RoomName FROM SubRoom").ToList();
                cmbRoom.DataSource = rooms;
                cmbRoom.DisplayMember = "RoomName";
                cmbRoom.ValueMember = "RoomId";
            }
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
                SubTimeslot = txtTimeslot.Text,
                RoomId = Convert.ToInt32(cmbRoom.SelectedValue)
            };

            if (SubTimetableController.Insert(timetable))
            {
                MessageBox.Show("Timetable Added Successfully");
                txtTimeslot.Clear();
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

            if (dataGridViewSubTimetable.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridViewSubTimetable.SelectedRows[0].Cells["TimetableId"].Value);
                if (SubTimetableController.Delete(id))
                {
                    MessageBox.Show("Deleted Successfully");
                    LoadTimetables();
                }
                else
                {
                    MessageBox.Show("Delete failed.");
                }
            }
            else
            {
                MessageBox.Show("Please select a timetable to delete.");
            }
        }
    }
}
