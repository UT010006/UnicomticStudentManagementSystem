using StudentManagementSystem.FORMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    internal class DashBoardController
    {
        public static void OpenStudentDetailsForm()
        {
            try
            {
                var form = new StudentDetailsForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open StudentDetailsForm: " + ex.Message);
            }
        }

        public static void OpenLecturerDetailsForm()
        {
            try
            {
                var form = new LecturerDetailsForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open LecturerDetailsForm: " + ex.Message);
            }
        }

        public static void OpenStuCourseForm()
        {
            try
            {
                var form = new StuCourseForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open StuCourseForm: " + ex.Message);
            }
        }

        public static void OpenStuSubjectForm()
        {
            try
            {
                var form = new StuSubjectForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open StuSubjectForm: " + ex.Message);
            }
        }

        public static void OpenStuExamForm()
        {
            try
            {
                var form = new StuExamForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open StuExamForm: " + ex.Message);
            }
        }

        public static void OpenStuScoreForm()
        {
            try
            {
                var form = new StuScoreForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open StuScoreForm: " + ex.Message);
            }
        }

        public static void OpenStuAttendanceForm()
        {
            try
            {
                var form = new StuAttendanceForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open StuAttendanceForm: " + ex.Message);
            }
        }

        public static void OpenSubTimetableForm()
        {
            try
            {
                var form = new SubTimetableForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open SubTimetableForm: " + ex.Message);
            }
        }

        public static void OpenTopMarksForm()
        {
            try
            {
                var form = new StuTopMarksForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open TopMarksForm: " + ex.Message);
            }
        }
        public static void OpenSubRoomForm()
        {
            try
            {
                var form = new SubRoomForm();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to open SubRoomForm: " + ex.Message);
            }
        }


        public static void Logout(Form currentForm)
        {
            currentForm.Hide();
            var login = new LoginForm();
            login.Show();
        }
    }
}



