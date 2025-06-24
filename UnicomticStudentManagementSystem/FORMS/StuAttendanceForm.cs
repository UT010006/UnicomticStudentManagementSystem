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
    public partial class StuAttendanceForm : Form
    {
        public StuAttendanceForm()
        {
            InitializeComponent();
        }

        private void StuAttendanceForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();
            cmbStatus.Items.Add("Present");
            cmbStatus.Items.Add("Absent");
            cmbStatus.SelectedIndex = 0; // Default to "Present"

            LoadData();

            // ✅ Disable edit controls if role is Student or Lecturer
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = false;

                txtStuId.ReadOnly = true;
                txtSubjectId.ReadOnly = true;
                cmbStatus.Enabled = false;
                dateTimePickerDate.Enabled = false;

                dataGridViewAttendance.ReadOnly = true;
            }
        }

        private void LoadData()
        {
            dataGridViewAttendance.DataSource = StuAttendanceController.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You are not allowed to add attendance.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var attendance = new StuAttendance
            {
                StuId = int.Parse(txtStuId.Text),
                StuSubjectId = int.Parse(txtSubjectId.Text),
                Date = dateTimePickerDate.Value.ToString("yyyy-MM-dd"),
                Status = cmbStatus.SelectedItem?.ToString() ?? "Absent"
            };

            StuAttendanceController.Insert(attendance);
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You are not allowed to delete attendance.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridViewAttendance.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewAttendance.SelectedRows[0];

                int stuId = selectedRow.Cells["StuId"].Value is int id ? id : 0;
                int subjectId = selectedRow.Cells["StuSubjectId"].Value is int sid ? sid : 0;
                string date = selectedRow.Cells["Date"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(date))
                {
                    StuAttendanceController.Delete(stuId, subjectId, date);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Invalid date value selected.");
                }
            }
        }
    }
}
