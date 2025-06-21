using StudentManagementSystem.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManagementSystem.Controllers;

namespace StudentManagementSystem.FORMS
{
    public partial class LecturerDetailsForm : Form
    {
        public LecturerDetailsForm()
        {
            InitializeComponent();
        }

        private void LecturerDetailsForm_Load(object sender, EventArgs e)
        {
            LoadLecturers();
        }

        private void LoadLecturers()
        {
            var lecturers = LecturerDetailsController.GetAll();
            dataGridViewLecturers.DataSource = null;
            dataGridViewLecturers.DataSource = lecturers;
        }

        private void ClearFields()
        {
            txtLectureId.Text = "";
            txtLectureName.Text = "";
            txtStuSubjectName.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLectureName.Text) || string.IsNullOrWhiteSpace(txtStuSubjectName.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            var lecturer = new LecturerDetails
            {
                LectureName = txtLectureName.Text.Trim(),
                StuSubjectName = txtStuSubjectName.Text.Trim()
            };

            LecturerDetailsController.Insert(lecturer);
            LoadLecturers();
            ClearFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLectureId.Text, out int id))
            {
                var lecturer = new LecturerDetails
                {
                    LectureId = id,
                    LectureName = txtLectureName.Text.Trim(),
                    StuSubjectName = txtStuSubjectName.Text.Trim()
                };

                LecturerDetailsController.Update(lecturer);
                LoadLecturers();
                ClearFields();
            }
            else
            {
                MessageBox.Show("Select a lecturer to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLectureId.Text, out int id))
            {
                var confirm = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    LecturerDetailsController.Delete(id);
                    LoadLecturers();
                    ClearFields();
                }
            }
            else
            {
                MessageBox.Show("Select a lecturer to delete.");
            }
        }

        private void dataGridViewLecturers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtLectureId.Text = dataGridViewLecturers.Rows[e.RowIndex].Cells["LectureId"].Value.ToString();
                txtLectureName.Text = dataGridViewLecturers.Rows[e.RowIndex].Cells["LectureName"].Value.ToString();
                txtStuSubjectName.Text = dataGridViewLecturers.Rows[e.RowIndex].Cells["StuSubjectName"].Value.ToString();
            }
        }
    }
}

        
    

