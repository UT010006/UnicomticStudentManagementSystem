using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.FORMS
{
    public partial class DashBoardForm : Form
    {
        public DashBoardForm()
        {
            InitializeComponent();
        }

        private void DashBoardForm_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "Welcome to Dashboard";
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Controllers.DashBoardController.OpenStudentDetailsForm();
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            Controllers.DashBoardController.OpenLecturerDetailsForm();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            Controllers.DashBoardController.OpenStuCourseForm();
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            Controllers.DashBoardController.OpenStuSubjectForm();
        }

        private void btnExams_Click(object sender, EventArgs e)
        {
            Controllers.DashBoardController.OpenStuExamForm();
        }

        private void btnScores_Click(object sender, EventArgs e)
        {
            Controllers.DashBoardController.OpenStuScoreForm();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            Controllers.DashBoardController.OpenStuAttendanceForm();
        }

        private void btnTimetable_Click(object sender, EventArgs e)
        {
            Controllers.DashBoardController.OpenSubTimetableForm();
        }

        private void btnTopMarks_Click(object sender, EventArgs e)
        {
            Controllers.DashBoardController.OpenTopMarksForm();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Controllers.DashBoardController.Logout(this);
        }
        private void btnSubRoom_Click(object sender, EventArgs e)
        {
            Controllers.DashBoardController.OpenSubRoomForm();
        }

    }
}