namespace StudentManagementSystem.FORMS
{
    partial class StuScoreForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStuId = new Label();
            txtStuId = new TextBox();
            lblExamId = new Label();
            txtExamId = new TextBox();
            lblScore = new Label();
            txtScore = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvStuScore = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStuScore).BeginInit();
            SuspendLayout();
            // 
            // lblStuId
            // 
            lblStuId.AutoSize = true;
            lblStuId.Location = new Point(114, 26);
            lblStuId.Name = "lblStuId";
            lblStuId.Size = new Size(65, 15);
            lblStuId.TabIndex = 0;
            lblStuId.Text = "Student ID:";
            // 
            // txtStuId
            // 
            txtStuId.Location = new Point(217, 18);
            txtStuId.Name = "txtStuId";
            txtStuId.Size = new Size(100, 23);
            txtStuId.TabIndex = 1;
            // 
            // lblExamId
            // 
            lblExamId.AutoSize = true;
            lblExamId.Location = new Point(131, 54);
            lblExamId.Name = "lblExamId";
            lblExamId.Size = new Size(53, 15);
            lblExamId.TabIndex = 2;
            lblExamId.Text = "Exam ID:";
            // 
            // txtExamId
            // 
            txtExamId.Location = new Point(217, 51);
            txtExamId.Name = "txtExamId";
            txtExamId.Size = new Size(100, 23);
            txtExamId.TabIndex = 3;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(140, 88);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(39, 15);
            lblScore.TabIndex = 4;
            lblScore.Text = "Score:";
            // 
            // txtScore
            // 
            txtScore.Location = new Point(217, 80);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 23);
            txtScore.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Bisque;
            btnAdd.Location = new Point(140, 144);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Bisque;
            btnUpdate.Location = new Point(275, 144);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Bisque;
            btnDelete.Location = new Point(411, 144);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvStuScore
            // 
            dgvStuScore.BackgroundColor = Color.DeepSkyBlue;
            dgvStuScore.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStuScore.Location = new Point(217, 194);
            dgvStuScore.Name = "dgvStuScore";
            dgvStuScore.Size = new Size(388, 150);
            dgvStuScore.TabIndex = 9;
            dgvStuScore.CellContentClick += dgvStuScore_CellClick;
            dgvStuScore.Click += StuScoreForm_Load;
            // 
            // StuScoreForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvStuScore);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtScore);
            Controls.Add(lblScore);
            Controls.Add(txtExamId);
            Controls.Add(lblExamId);
            Controls.Add(txtStuId);
            Controls.Add(lblStuId);
            Name = "StuScoreForm";
            Text = "StuScoreForm";
            Load += StuScoreForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStuScore).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStuId;
        private TextBox txtStuId;
        private Label lblExamId;
        private TextBox txtExamId;
        private Label lblScore;
        private TextBox txtScore;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dgvStuScore;
    }
}