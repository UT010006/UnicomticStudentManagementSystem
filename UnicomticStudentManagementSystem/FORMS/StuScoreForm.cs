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
    public partial class StuScoreForm : Form
    {
        public StuScoreForm()
        {
            InitializeComponent();
        }

        private void StuScoreForm_Load(object sender, EventArgs e)
        {
            dgvStuScore.CellClick += dgvStuScore_CellClick; // ✅ Event handler attached
            RefreshData();

            // ✅ Apply role-based restriction
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                txtStuId.ReadOnly = true;
                txtExamId.ReadOnly = true;
                txtScore.ReadOnly = true;

                dgvStuScore.ReadOnly = true;
            }
        }

        private void RefreshData()
        {
            dgvStuScore.DataSource = null;
            dgvStuScore.DataSource = StuScoreController.GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CanModify()) return;

            if (!int.TryParse(txtStuId.Text, out int stuId) || !int.TryParse(txtExamId.Text, out int examId) || !int.TryParse(txtScore.Text, out int scoreVal))
            {
                MessageBox.Show("Please enter valid numeric values.");
                return;
            }

            var score = new StuScore
            {
                StuId = stuId,
                ExamId = examId,
                Score = scoreVal
            };

            StuScoreController.Insert(score);
            RefreshData();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!CanModify()) return;

            if (!int.TryParse(txtStuId.Text, out int stuId) || !int.TryParse(txtExamId.Text, out int examId) || !int.TryParse(txtScore.Text, out int scoreVal))
            {
                MessageBox.Show("Please enter valid numeric values.");
                return;
            }

            var score = new StuScore
            {
                StuId = stuId,
                ExamId = examId,
                Score = scoreVal
            };

            StuScoreController.Update(score);
            RefreshData();
            ClearForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!CanModify()) return;

            if (!int.TryParse(txtStuId.Text, out int stuId) || !int.TryParse(txtExamId.Text, out int examId))
            {
                MessageBox.Show("Please enter valid Student ID and Exam ID.");
                return;
            }

            StuScoreController.Delete(stuId, examId);
            RefreshData();
            ClearForm();
        }

        private void dgvStuScore_CellClick(object? sender, DataGridViewCellEventArgs e) // ✅ Safe signature
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvStuScore.Rows[e.RowIndex];

                txtStuId.Text = row.Cells[0].Value?.ToString() ?? "";
                txtExamId.Text = row.Cells[1].Value?.ToString() ?? "";
                txtScore.Text = row.Cells[2].Value?.ToString() ?? "";
            }
        }

        private void ClearForm()
        {
            txtStuId.Clear();
            txtExamId.Clear();
            txtScore.Clear();
        }

        private bool CanModify()
        {
            if (SessionManager.LoggedInRole == "Student" || SessionManager.LoggedInRole == "Lecturer")
            {
                MessageBox.Show("Access denied. You are not allowed to perform this action.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
