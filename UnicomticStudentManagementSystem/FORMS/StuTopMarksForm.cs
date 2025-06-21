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
    public partial class StuTopMarksForm : Form
    {
        public StuTopMarksForm()
        {
            InitializeComponent();
        }

        private void StuTopMarksForm_Load(object sender, EventArgs e)
        {
            LoadTopMarks();
        }

        private void btnLoadTop_Click(object sender, EventArgs e)
        {
            LoadTopMarks();
        }

        private void LoadTopMarks()
        {
            dgvTopMarks.Rows.Clear();
            dgvTopMarks.Columns.Clear();

            dgvTopMarks.Columns.Add("StuName", "Student Name");
            dgvTopMarks.Columns.Add("ExamName", "Exam Name");
            dgvTopMarks.Columns.Add("Score", "Score");

            int topN = (int)numTopN.Value;
            var topMarks = StuTopMarksController.GetTopMarks(topN);

            foreach (var item in topMarks)
            {
                dgvTopMarks.Rows.Add(item.StuName, item.ExamName, item.Score);
            }
        }
    }
}

        
    

