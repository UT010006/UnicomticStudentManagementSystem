namespace StudentManagementSystem.FORMS
{
    partial class StuTopMarksForm
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
            btnLoadTop = new Button();
            numTopN = new NumericUpDown();
            dgvTopMarks = new DataGridView();
            lblTopN = new Label();
            ((System.ComponentModel.ISupportInitialize)numTopN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopMarks).BeginInit();
            SuspendLayout();
            // 
            // btnLoadTop
            // 
            btnLoadTop.Location = new Point(154, 93);
            btnLoadTop.Name = "btnLoadTop";
            btnLoadTop.Size = new Size(75, 23);
            btnLoadTop.TabIndex = 1;
            btnLoadTop.Text = "Load Top N Marks\n";
            btnLoadTop.UseVisualStyleBackColor = true;
            // 
            // numTopN
            // 
            numTopN.Location = new Point(452, 93);
            numTopN.Name = "numTopN";
            numTopN.Size = new Size(120, 23);
            numTopN.TabIndex = 2;
            numTopN.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // dgvTopMarks
            // 
            dgvTopMarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopMarks.Location = new Point(218, 184);
            dgvTopMarks.Name = "dgvTopMarks";
            dgvTopMarks.Size = new Size(240, 150);
            dgvTopMarks.TabIndex = 3;
            // 
            // lblTopN
            // 
            lblTopN.AutoSize = true;
            lblTopN.Location = new Point(169, 58);
            lblTopN.Name = "lblTopN";
            lblTopN.Size = new Size(41, 30);
            lblTopN.TabIndex = 4;
            lblTopN.Text = "Top N:\n\n";
            // 
            // StuTopMarksForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTopN);
            Controls.Add(dgvTopMarks);
            Controls.Add(numTopN);
            Controls.Add(btnLoadTop);
            Name = "StuTopMarksForm";
            Text = "StuTopMarksForm";
            Load += StuTopMarksForm_Load;
            ((System.ComponentModel.ISupportInitialize)numTopN).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTopMarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLoadTop;
        private NumericUpDown numTopN;
        private DataGridView dgvTopMarks;
        private Label lblTopN;
    }
}