namespace StudentManagementSystem.FORMS
{
    partial class StuSubjectForm
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
            lblSubjectName = new Label();
            txtSubjectName = new TextBox();
            lblCourse = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            cmbCourse = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            dgvSubjects = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // lblSubjectName
            // 
            lblSubjectName.AutoSize = true;
            lblSubjectName.Location = new Point(108, 29);
            lblSubjectName.Name = "lblSubjectName";
            lblSubjectName.Size = new Size(84, 15);
            lblSubjectName.TabIndex = 0;
            lblSubjectName.Text = "Subject Name:\t";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(274, 21);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(176, 23);
            txtSubjectName.TabIndex = 1;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(140, 66);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(47, 15);
            lblCourse.TabIndex = 2;
            lblCourse.Text = "Course:";
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(274, 63);
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(176, 23);
            cmbCourse.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(140, 104);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(261, 104);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(388, 104);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(528, 104);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear\t";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvSubjects
            // 
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(274, 150);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.Size = new Size(240, 150);
            dgvSubjects.TabIndex = 8;
            // 
            // StuSubjectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvSubjects);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbCourse);
            Controls.Add(lblCourse);
            Controls.Add(txtSubjectName);
            Controls.Add(lblSubjectName);
            Name = "StuSubjectForm";
            Text = "StuSubjectForm";
            Load += StuSubjectForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSubjectName;
        private TextBox txtSubjectName;
        private Label lblCourse;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox cmbCourse;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridView dgvSubjects;
    }
}