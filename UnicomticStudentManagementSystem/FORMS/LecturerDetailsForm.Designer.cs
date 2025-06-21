namespace StudentManagementSystem.FORMS
{
    partial class LecturerDetailsForm
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
            lblLectureId = new Label();
            txtLectureId = new TextBox();
            lblLectureName = new Label();
            txtLectureName = new TextBox();
            lblStuSubjectName = new Label();
            txtStuSubjectName = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridViewLecturers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLecturers).BeginInit();
            SuspendLayout();
            // 
            // lblLectureId
            // 
            lblLectureId.AutoSize = true;
            lblLectureId.Location = new Point(106, 24);
            lblLectureId.Name = "lblLectureId";
            lblLectureId.Size = new Size(63, 15);
            lblLectureId.TabIndex = 0;
            lblLectureId.Text = "Lecture ID:";
            // 
            // txtLectureId
            // 
            txtLectureId.Location = new Point(224, 16);
            txtLectureId.Name = "txtLectureId";
            txtLectureId.Size = new Size(100, 23);
            txtLectureId.TabIndex = 1;
            // 
            // lblLectureName
            // 
            lblLectureName.AutoSize = true;
            lblLectureName.Location = new Point(471, 16);
            lblLectureName.Name = "lblLectureName";
            lblLectureName.Size = new Size(84, 15);
            lblLectureName.TabIndex = 2;
            lblLectureName.Text = "Lecture Name:";
            // 
            // txtLectureName
            // 
            txtLectureName.Location = new Point(625, 12);
            txtLectureName.Name = "txtLectureName";
            txtLectureName.Size = new Size(100, 23);
            txtLectureName.TabIndex = 3;
            // 
            // lblStuSubjectName
            // 
            lblStuSubjectName.AutoSize = true;
            lblStuSubjectName.Location = new Point(336, 63);
            lblStuSubjectName.Name = "lblStuSubjectName";
            lblStuSubjectName.Size = new Size(84, 15);
            lblStuSubjectName.TabIndex = 4;
            lblStuSubjectName.Text = "Subject Name:";
            // 
            // txtStuSubjectName
            // 
            txtStuSubjectName.Location = new Point(455, 60);
            txtStuSubjectName.Name = "txtStuSubjectName";
            txtStuSubjectName.Size = new Size(100, 23);
            txtStuSubjectName.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(224, 129);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(412, 129);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(615, 129);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLecturers
            // 
            dataGridViewLecturers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLecturers.Location = new Point(304, 186);
            dataGridViewLecturers.Name = "dataGridViewLecturers";
            dataGridViewLecturers.Size = new Size(240, 150);
            dataGridViewLecturers.TabIndex = 9;
            // 
            // LecturerDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewLecturers);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtStuSubjectName);
            Controls.Add(lblStuSubjectName);
            Controls.Add(txtLectureName);
            Controls.Add(lblLectureName);
            Controls.Add(txtLectureId);
            Controls.Add(lblLectureId);
            Name = "LecturerDetailsForm";
            Text = "LecturerDetailsForm";
            Load += LecturerDetailsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewLecturers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLectureId;
        private TextBox txtLectureId;
        private Label lblLectureName;
        private TextBox txtLectureName;
        private Label lblStuSubjectName;
        private TextBox txtStuSubjectName;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridViewLecturers;
    }
}