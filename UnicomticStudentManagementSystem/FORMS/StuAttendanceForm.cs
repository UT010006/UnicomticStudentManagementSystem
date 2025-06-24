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
            dataGridViewAttendance.CellClick += dataGridViewAttendance_CellClick;

            cmbStatus.Items.AddRange(new[] { "Present", "Absent" });
            cmbStatus.SelectedIndex = 0;
            LoadData();

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
            if (dataGridViewAttendance.SelectedRows.Count > 0)
            {
                var row = dataGridViewAttendance.SelectedRows[0];
                int stuId = Convert.ToInt32(row.Cells["StuId"].Value);
                int subId = Convert.ToInt32(row.Cells["StuSubjectId"].Value);
                string date = row.Cells["Date"].Value?.ToString() ?? "";

                StuAttendanceController.Delete(stuId, subId, date);
                LoadData();
            }
        }

        private void dataGridViewAttendance_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridViewAttendance.Rows[e.RowIndex];
                txtStuId.Text = row.Cells["StuId"].Value?.ToString() ?? "";
                txtSubjectId.Text = row.Cells["StuSubjectId"].Value?.ToString() ?? "";
                dateTimePickerDate.Value = DateTime.Parse(row.Cells["Date"].Value?.ToString() ?? DateTime.Now.ToString());
                cmbStatus.SelectedItem = row.Cells["Status"].Value?.ToString();
            }
        }
    }
}
