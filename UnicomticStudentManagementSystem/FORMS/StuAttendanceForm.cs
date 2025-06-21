using StudentManagementSystem.Controllers;
using StudentManagementSystem.MODELS;
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

namespace StudentManagementSystem.FORMS
{
    public partial class StuAttendanceForm : Form
    {
        public StuAttendanceForm()
        {
            InitializeComponent();
        }

        private void StuAttendanceForm_Load(object sender, EventArgs e)
        { }
    }
}
    

//LoadStudents();
//LoadSubjects();
//LoadAttendance();
//cmbStatus.Items.AddRange(new string[] { "Present", "Absent" });
//cmbStatus.SelectedIndex = 0;
//        }

//        private void LoadStudents()
//{
//    cmbStudent.Items.Clear();
//    using (var con = DatabaseManagement.GetConnection())
//    {
//        string query = "SELECT StuId, StuName FROM StudentDetails";
//        using (var cmd = new SQLiteCommand(query, con))
//        using (var reader = cmd.ExecuteReader())
//        {
//            while (reader.Read())
//            {
//                cmbStudent.Items.Add(new ComboBoxItem
//                {
//                    Text = reader["StuName"].ToString(),
//                    Value = reader["StuId"].ToString()
//                });
//            }
//        }
//    }
//}

//private void LoadSubjects()
//{
//    cmbSubject.Items.Clear();
//    using (var con = DatabaseManagement.GetConnection())
//    {
//        string query = "SELECT StuSubjectId, StuSubjectName FROM StuSubject";
//        using (var cmd = new SQLiteCommand(query, con))
//        using (var reader = cmd.ExecuteReader())
//        {
//            while (reader.Read())
//            {
//                cmbSubject.Items.Add(new ComboBoxItem
//                {
//                    Text = reader["StuSubjectName"].ToString(),
//                    Value = reader["StuSubjectId"].ToString()
//                });
//            }
//        }
//    }
//}

//private void LoadAttendance()
//{
//    dgvAttendance.Rows.Clear();
//    dgvAttendance.Columns.Clear();

//    dgvAttendance.Columns.Add("StuId", "Student ID");
//    dgvAttendance.Columns.Add("StuSubjectId", "Subject ID");
//    dgvAttendance.Columns.Add("Date", "Date");
//    dgvAttendance.Columns.Add("Status", "Status");

//    var list = StuAttendanceController.GetAll();
//    foreach (var att in list)
//    {
//        dgvAttendance.Rows.Add(att.StuId, att.StuSubjectId, att.Date, att.Status);
//    }
//}

//private void btnMark_Click(object sender, EventArgs e)
//{
//    if (cmbStudent.SelectedItem == null || cmbSubject.SelectedItem == null || cmbStatus.SelectedItem == null)
//    {
//        MessageBox.Show("Please fill all fields.");
//        return;
//    }

//    var student = (ComboBoxItem)cmbStudent.SelectedItem;
//    var subject = (ComboBoxItem)cmbSubject.SelectedItem;

//    var attendance = new StuAttendance
//    {
//        StuId = int.Parse(student.Value),
//        StuSubjectId = int.Parse(subject.Value),
//        Date = dtpDate.Value.ToString("yyyy-MM-dd"),
//        Status = cmbStatus.SelectedItem.ToString()
//    };

//    StuAttendanceController.Insert(attendance);
//    LoadAttendance();
//}
//    }

//    public class ComboBoxItem
//{
//    public string Text { get; set; } = string.Empty;
//    public string Value { get; set; } = string.Empty;
//    public override string ToString() => Text;
//}
//}


        
    

