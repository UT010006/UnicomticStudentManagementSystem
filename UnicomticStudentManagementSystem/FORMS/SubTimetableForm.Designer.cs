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
            label1 = new Label();
            txtSubjectId = new TextBox();
            label2 = new Label();
            txtTimeslot = new TextBox();
            label3 = new Label();
            txtRoomId = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            dataGridViewSubTimetable = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubTimetable).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 24);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 0;
            label1.Text = "Subject ID:\n";
            // 
            // txtSubjectId
            // 
            txtSubjectId.Location = new Point(228, 16);
            txtSubjectId.Name = "txtSubjectId";
            txtSubjectId.Size = new Size(100, 23);
            txtSubjectId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(142, 60);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Time Slot:\n";
            // 
            // txtTimeslot
            // 
            txtTimeslot.Location = new Point(228, 52);
            txtTimeslot.Name = "txtTimeslot";
            txtTimeslot.Size = new Size(100, 23);
            txtTimeslot.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(142, 95);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 4;
            label3.Text = "Room ID:\n";
            // 
            // txtRoomId
            // 
            txtRoomId.Location = new Point(228, 87);
            txtRoomId.Name = "txtRoomId";
            txtRoomId.Size = new Size(100, 23);
            txtRoomId.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(194, 152);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(76, 23);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Timetable\n";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(312, 152);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete Selected\n";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewSubTimetable
            // 
            dataGridViewSubTimetable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSubTimetable.Location = new Point(472, 12);
            dataGridViewSubTimetable.Name = "dataGridViewSubTimetable";
            dataGridViewSubTimetable.Size = new Size(240, 150);
            dataGridViewSubTimetable.TabIndex = 8;
            dataGridViewSubTimetable.Click += SubTimetableForm_Load;
            // 
            // SubTimetableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewSubTimetable);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtRoomId);
            Controls.Add(label3);
            Controls.Add(txtTimeslot);
            Controls.Add(label2);
            Controls.Add(txtSubjectId);
            Controls.Add(label1);
            Name = "SubTimetableForm";
            Text = "SubTimetableForm";
            Load += SubTimetableForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSubTimetable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSubjectId;
        private Label label2;
        private TextBox txtTimeslot;
        private Label label3;
        private TextBox txtRoomId;
        private Button btnAdd;
        private Button btnDelete;
        private DataGridView dataGridViewSubTimetable;
    }
}