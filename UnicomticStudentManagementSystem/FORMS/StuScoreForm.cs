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
    public partial class StuScoreForm : Form
    {
        public StuScoreForm()
        {
            InitializeComponent();
        }

        private void StuScoreForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            dgvStuScore.DataSource = null;
            dgvStuScore.DataSource = StuScoreController.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var score = new StuScore
            {
                StuId = int.Parse(txtStuId.Text),
                ExamId = int.Parse(txtExamId.Text),
                Score = int.Parse(txtScore.Text)
            };

            StuScoreController.Insert(score);
            RefreshData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var score = new StuScore
            {
                StuId = int.Parse(txtStuId.Text),
                ExamId = int.Parse(txtExamId.Text),
                Score = int.Parse(txtScore.Text)
            };

            StuScoreController.Update(score);
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int stuId = int.Parse(txtStuId.Text);
            int examId = int.Parse(txtExamId.Text);

            StuScoreController.Delete(stuId, examId);
            RefreshData();
        }

        private void dgvStuScore_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtStuId.Text = dgvStuScore.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtExamId.Text = dgvStuScore.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtScore.Text = dgvStuScore.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
    }
}

        
    

