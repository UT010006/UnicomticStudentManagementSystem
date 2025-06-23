namespace StudentManagementSystem.FORMS
{
    partial class DashBoardForm
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
            lblWelcome = new Label();
            btnStudents = new Button();
            btnLecturers = new Button();
            btnCourses = new Button();
            btnSubjects = new Button();
            btnExams = new Button();
            btnScore = new Button();
            btnAttendance = new Button();
            btnTimetable = new Button();
            btnTopMarks = new Button();
            btnLogout = new Button();
            btnSubRoom = new Button();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(361, 22);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(114, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome:[UserRole]";
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(132, 84);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(111, 23);
            btnStudents.TabIndex = 1;
            btnStudents.Text = "Student Details\n";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnLecturers
            // 
            btnLecturers.Location = new Point(324, 84);
            btnLecturers.Name = "btnLecturers";
            btnLecturers.Size = new Size(100, 23);
            btnLecturers.TabIndex = 2;
            btnLecturers.Text = "Lecturer Details\n";
            btnLecturers.UseVisualStyleBackColor = true;
            btnLecturers.Click += btnLecturers_Click;
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(502, 84);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(100, 23);
            btnCourses.TabIndex = 3;
            btnCourses.Text = "Course Details\n";
            btnCourses.UseVisualStyleBackColor = true;
            btnCourses.Click += btnCourses_Click;
            // 
            // btnSubjects
            // 
            btnSubjects.Location = new Point(137, 157);
            btnSubjects.Name = "btnSubjects";
            btnSubjects.Size = new Size(106, 23);
            btnSubjects.TabIndex = 4;
            btnSubjects.Text = "Subject Details\n";
            btnSubjects.UseVisualStyleBackColor = true;
            btnSubjects.Click += btnSubjects_Click;
            // 
            // btnExams
            // 
            btnExams.Location = new Point(324, 157);
            btnExams.Name = "btnExams";
            btnExams.Size = new Size(100, 23);
            btnExams.TabIndex = 5;
            btnExams.Text = "Exam Details\n";
            btnExams.UseVisualStyleBackColor = true;
            btnExams.Click += btnExams_Click;
            // 
            // btnScore
            // 
            btnScore.Location = new Point(502, 156);
            btnScore.Name = "btnScore";
            btnScore.Size = new Size(97, 23);
            btnScore.TabIndex = 6;
            btnScore.Text = "Score Details\n";
            btnScore.UseVisualStyleBackColor = true;
            btnScore.Click += btnScores_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Location = new Point(137, 228);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(106, 23);
            btnAttendance.TabIndex = 7;
            btnAttendance.Text = "Attendance\n";
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnTimetable
            // 
            btnTimetable.Location = new Point(324, 228);
            btnTimetable.Name = "btnTimetable";
            btnTimetable.Size = new Size(100, 23);
            btnTimetable.TabIndex = 8;
            btnTimetable.Text = "Timetable";
            btnTimetable.UseVisualStyleBackColor = true;
            btnTimetable.Click += btnTimetable_Click;
            // 
            // btnTopMarks
            // 
            btnTopMarks.Location = new Point(512, 228);
            btnTopMarks.Name = "btnTopMarks";
            btnTopMarks.Size = new Size(75, 23);
            btnTopMarks.TabIndex = 9;
            btnTopMarks.Text = "Top Marks\n";
            btnTopMarks.UseVisualStyleBackColor = true;
            btnTopMarks.Click += btnTopMarks_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(683, 368);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSubRoom
            // 
            btnSubRoom.Location = new Point(324, 288);
            btnSubRoom.Name = "btnSubRoom";
            btnSubRoom.Size = new Size(100, 23);
            btnSubRoom.TabIndex = 11;
            btnSubRoom.Text = "Sub Room";
            btnSubRoom.UseVisualStyleBackColor = true;
            // 
            // DashBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSubRoom);
            Controls.Add(btnLogout);
            Controls.Add(btnTopMarks);
            Controls.Add(btnTimetable);
            Controls.Add(btnAttendance);
            Controls.Add(btnScore);
            Controls.Add(btnExams);
            Controls.Add(btnSubjects);
            Controls.Add(btnCourses);
            Controls.Add(btnLecturers);
            Controls.Add(btnStudents);
            Controls.Add(lblWelcome);
            Name = "DashBoardForm";
            Text = "DashBoardForm";
            Load += DashBoardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnStudents;
        private Button btnLecturers;
        private Button btnCourses;
        private Button btnSubjects;
        private Button btnExams;
        private Button btnScore;
        private Button btnAttendance;
        private Button btnTimetable;
        private Button btnTopMarks;
        private Button btnLogout;
        private Button btnSubRoom;
    }
}