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
            lblStuId = new Label();
            txtStuId = new TextBox();
            lblSubjectId = new Label();
            txtSubjectId = new TextBox();
            lblDate = new Label();
            dateTimePickerDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridViewAttendance = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // lblStuId
            // 
            lblStuId.AutoSize = true;
            lblStuId.Location = new Point(112, 19);
            lblStuId.Name = "lblStuId";
            lblStuId.Size = new Size(62, 15);
            lblStuId.TabIndex = 0;
            lblStuId.Text = "Student ID\n";
            // 
            // txtStuId
            // 
            txtStuId.Location = new Point(214, 16);
            txtStuId.Name = "txtStuId";
            txtStuId.Size = new Size(100, 23);
            txtStuId.TabIndex = 1;
            // 
            // lblSubjectId
            // 
            lblSubjectId.AutoSize = true;
            lblSubjectId.Location = new Point(114, 49);
            lblSubjectId.Name = "lblSubjectId";
            lblSubjectId.Size = new Size(60, 15);
            lblSubjectId.TabIndex = 2;
            lblSubjectId.Text = "Subject ID\n";
            // 
            // txtSubjectId
            // 
            txtSubjectId.Location = new Point(214, 45);
            txtSubjectId.Name = "txtSubjectId";
            txtSubjectId.Size = new Size(100, 23);
            txtSubjectId.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(133, 91);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(31, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date";
            // 
            // dateTimePickerDate
            // 
            dateTimePickerDate.Location = new Point(214, 85);
            dateTimePickerDate.Name = "dateTimePickerDate";
            dateTimePickerDate.Size = new Size(200, 23);
            dateTimePickerDate.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(136, 134);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(214, 131);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(539, 65);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(539, 126);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Location = new Point(151, 196);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.Size = new Size(442, 214);
            dataGridViewAttendance.TabIndex = 10;
            // 
            // StuAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(dateTimePickerDate);
            Controls.Add(lblDate);
            Controls.Add(txtSubjectId);
            Controls.Add(lblSubjectId);
            Controls.Add(txtStuId);
            Controls.Add(lblStuId);
            Name = "StuAttendanceForm";
            Text = "StuAttendanceForm";
            Load += StuAttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStuId;
        private TextBox txtStuId;
        private Label lblSubjectId;
        private TextBox txtSubjectId;
        private Label lblDate;
        private DateTimePicker dateTimePickerDate;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridViewAttendance;
    }
}