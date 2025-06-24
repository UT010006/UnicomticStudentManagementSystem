namespace StudentManagementSystem.FORMS
{
    partial class SubTimetableForm
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
            cmbSubject = new ComboBox();
            lblSubject = new Label();
            lblTimeslot = new Label();
            cmbRoom = new ComboBox();
            txtTimeslot = new TextBox();
            lblRoom = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridViewSubTimetable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubTimetable).BeginInit();
            SuspendLayout();
            // 
            // cmbSubject
            // 
            cmbSubject.FormattingEnabled = true;
            cmbSubject.Location = new Point(201, 23);
            cmbSubject.Name = "cmbSubject";
            cmbSubject.Size = new Size(121, 23);
            cmbSubject.TabIndex = 0;
            cmbSubject.Text = "Select subject\n";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(117, 26);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(46, 15);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "Subject";
            // 
            // lblTimeslot
            // 
            lblTimeslot.AutoSize = true;
            lblTimeslot.Location = new Point(117, 60);
            lblTimeslot.Name = "lblTimeslot";
            lblTimeslot.Size = new Size(59, 15);
            lblTimeslot.TabIndex = 2;
            lblTimeslot.Text = "Time Slot:\n";
            // 
            // cmbRoom
            // 
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(201, 86);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(121, 23);
            cmbRoom.TabIndex = 3;
            // 
            // txtTimeslot
            // 
            txtTimeslot.Location = new Point(201, 52);
            txtTimeslot.Name = "txtTimeslot";
            txtTimeslot.Size = new Size(121, 23);
            txtTimeslot.TabIndex = 4;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Location = new Point(125, 94);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(42, 15);
            lblRoom.TabIndex = 5;
            lblRoom.Text = "Room:\n";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Bisque;
            btnAdd.Location = new Point(498, 26);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Bisque;
            btnDelete.Location = new Point(498, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewSubTimetable
            // 
            dataGridViewSubTimetable.BackgroundColor = Color.DeepSkyBlue;
            dataGridViewSubTimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubTimetable.Location = new Point(179, 180);
            dataGridViewSubTimetable.Name = "dataGridViewSubTimetable";
            dataGridViewSubTimetable.Size = new Size(417, 150);
            dataGridViewSubTimetable.TabIndex = 8;
            dataGridViewSubTimetable.Click += SubTimetableForm_Load;
            // 
            // SubTimetableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cyan;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewSubTimetable);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblRoom);
            Controls.Add(txtTimeslot);
            Controls.Add(cmbRoom);
            Controls.Add(lblTimeslot);
            Controls.Add(lblSubject);
            Controls.Add(cmbSubject);
            Name = "SubTimetableForm";
            Text = "SubTimetableForm";
            Load += SubTimetableForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubTimetable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSubject;
        private Label lblSubject;
        private Label lblTimeslot;
        private ComboBox cmbRoom;
        private TextBox txtTimeslot;
        private Label lblRoom;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridViewSubTimetable;
    }
}