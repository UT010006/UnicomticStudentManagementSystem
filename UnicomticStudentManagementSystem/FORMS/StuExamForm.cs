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

namespace StudentManagementSystem.FORMS
{
    public partial class StuExamForm : Form
    {
        public StuExamForm()
        {
            InitializeComponent();
        }

        private void StuExamForm_Load(object sender, EventArgs e)
        {
            LoadData();
            txtExamId.ReadOnly = true;
        }

        private void LoadData()
        {
            var exams = StuExamController.GetAll();
            dataGridView1.DataSource = exams;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var exam = new StuExam
            {
                ExamName = txtExamName.Text.Trim(),
                StuSubjectId = int.Parse(txtSubjectId.Text)
            };

            StuExamController.Insert(exam);
            LoadData();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExamId.Text)) return;

            var exam = new StuExam
            {
                ExamId = int.Parse(txtExamId.Text),
                ExamName = txtExamName.Text.Trim(),
                StuSubjectId = int.Parse(txtSubjectId.Text)
            };

            StuExamController.Update(exam);
            LoadData();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExamId.Text)) return;

            int examId = int.Parse(txtExamId.Text);
            StuExamController.Delete(examId);
            LoadData();
            ClearForm();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                txtExamId.Text = row.Cells["ExamId"].Value.ToString();
                txtExamName.Text = row.Cells["ExamName"].Value.ToString();
                txtSubjectId.Text = row.Cells["StuSubjectId"].Value.ToString();
            }
        }

        private void ClearForm()
        {
            txtExamId.Clear();
            txtExamName.Clear();
            txtSubjectId.Clear();
        }
    }
}

        
    

