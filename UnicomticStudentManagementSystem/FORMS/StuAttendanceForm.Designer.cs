namespace StudentManagementSystem.FORMS
{
    partial class StuAttendanceForm
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
            cmbStudent = new ComboBox();
            cmbSubject = new ComboBox();
            dtpDate = new DateTimePicker();
            cmbStatus = new ComboBox();
            btnMark = new Button();
            dgvAttendance = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).BeginInit();
            SuspendLayout();
            // 
            // cmbStudent
            // 
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(225, 37);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(121, 23);
            cmbStudent.TabIndex = 0;
            cmbStudent.Text = "— (Student List)\n";
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(225, 79);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(121, 23);
            cmbSubject.TabIndex = 1;
            cmbSubject.Text = "— (Subject List)\n";
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(201, 121);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 23);
            dtpDate.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(225, 164);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(132, 23);
            cmbStatus.TabIndex = 3;
            cmbStatus.Text = "— (Present/Absent)\n";
            // 
            // btnMark
            // 
            btnMark.Location = new Point(257, 202);
            btnMark.Name = "btnMark";
            btnMark.Size = new Size(75, 23);
            btnMark.TabIndex = 4;
            btnMark.Text = "Mark Attendance\n";
            btnMark.UseVisualStyleBackColor = true;
            // 
            // dgvAttendance
            // 
            dgvAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttendance.Location = new Point(201, 231);
            dgvAttendance.Name = "dgvAttendance";
            dgvAttendance.Size = new Size(240, 150);
            dgvAttendance.TabIndex = 5;
            // 
            // StuAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvAttendance);
            Controls.Add(btnMark);
            Controls.Add(cmbStatus);
            Controls.Add(dtpDate);
            Controls.Add(cmbSubject);
            Controls.Add(cmbStudent);
            Name = "StuAttendanceForm";
            Text = "StuAttendanceForm";
            Load += StuAttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAttendance).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbStudent;
        private ComboBox cmbSubject;
        private DateTimePicker dtpDate;
        private ComboBox cmbStatus;
        private Button btnMark;
        private DataGridView dgvAttendance;
    }
}