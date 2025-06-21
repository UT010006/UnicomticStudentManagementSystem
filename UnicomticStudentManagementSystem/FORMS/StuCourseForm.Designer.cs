namespace StudentManagementSystem.FORMS
{
    partial class StuCourseForm
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
            lblCourseName = new Label();
            txtCourseName = new TextBox();
            dgvCourses = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCourses).BeginInit();
            SuspendLayout();
            // 
            // lblCourseName
            // 
            lblCourseName.AutoSize = true;
            lblCourseName.Location = new Point(114, 33);
            lblCourseName.Name = "lblCourseName";
            lblCourseName.Size = new Size(82, 15);
            lblCourseName.TabIndex = 0;
            lblCourseName.Text = "Course Name:\n";
            // 
            // txtCourseName
            // 
            txtCourseName.Location = new Point(202, 30);
            txtCourseName.Name = "txtCourseName";
            txtCourseName.Size = new Size(132, 23);
            txtCourseName.TabIndex = 1;
            // 
            // dgvCourses
            // 
            dgvCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCourses.Location = new Point(256, 197);
            dgvCourses.Name = "dgvCourses";
            dgvCourses.Size = new Size(240, 150);
            dgvCourses.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(136, 115);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(259, 115);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(374, 115);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete\n";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(494, 115);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // StuCourseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dgvCourses);
            Controls.Add(txtCourseName);
            Controls.Add(lblCourseName);
            Name = "StuCourseForm";
            Text = "StuCourseForm";
            Load += StuCourseForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCourses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCourseName;
        private TextBox txtCourseName;
        private DataGridView dgvCourses;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
    }
}