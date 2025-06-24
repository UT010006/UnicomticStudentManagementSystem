namespace StudentManagementSystem.FORMS
{
    partial class StuExamForm
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
            lblExamId = new Label();
            txtExamId = new TextBox();
            lblExamName = new Label();
            txtExamName = new TextBox();
            lblSubjectId = new Label();
            txtSubjectId = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblExamId
            // 
            lblExamId.AutoSize = true;
            lblExamId.Location = new Point(145, 49);
            lblExamId.Name = "lblExamId";
            lblExamId.Size = new Size(50, 15);
            lblExamId.TabIndex = 0;
            lblExamId.Text = "Exam ID";
            // 
            // txtExamId
            // 
            txtExamId.Location = new Point(249, 46);
            txtExamId.Name = "txtExamId";
            txtExamId.Size = new Size(100, 23);
            txtExamId.TabIndex = 1;
            // 
            // lblExamName
            // 
            lblExamName.AutoSize = true;
            lblExamName.Location = new Point(145, 82);
            lblExamName.Name = "lblExamName";
            lblExamName.Size = new Size(71, 15);
            lblExamName.TabIndex = 2;
            lblExamName.Text = "Exam Name";
            // 
            // txtExamName
            // 
            txtExamName.Location = new Point(249, 79);
            txtExamName.Name = "txtExamName";
            txtExamName.Size = new Size(100, 23);
            txtExamName.TabIndex = 3;
            // 
            // lblSubjectId
            // 
            lblSubjectId.AutoSize = true;
            lblSubjectId.Location = new Point(145, 118);
            lblSubjectId.Name = "lblSubjectId";
            lblSubjectId.Size = new Size(60, 15);
            lblSubjectId.TabIndex = 4;
            lblSubjectId.Text = "Subject ID";
            // 
            // txtSubjectId
            // 
            txtSubjectId.Location = new Point(249, 110);
            txtSubjectId.Name = "txtSubjectId";
            txtSubjectId.Size = new Size(100, 23);
            txtSubjectId.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(422, 45);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(422, 74);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(422, 103);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(219, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 9;
            // 
            // StuExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(txtSubjectId);
            Controls.Add(lblSubjectId);
            Controls.Add(txtExamName);
            Controls.Add(lblExamName);
            Controls.Add(txtExamId);
            Controls.Add(lblExamId);
            Name = "StuExamForm";
            Text = "StuExamForm";
            Load += StuExamForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExamId;
        private TextBox txtExamId;
        private Label lblExamName;
        private TextBox txtExamName;
        private Label lblSubjectId;
        private TextBox txtSubjectId;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}