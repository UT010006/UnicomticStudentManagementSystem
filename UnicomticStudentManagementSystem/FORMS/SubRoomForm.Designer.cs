namespace StudentManagementSystem.FORMS
{
    partial class SubRoomForm
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
            lblRoomName = new Label();
            txtRoomName = new TextBox();
            lblRoomType = new Label();
            cmbRoomType = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridViewRooms = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).BeginInit();
            SuspendLayout();
            // 
            // lblRoomName
            // 
            lblRoomName.AutoSize = true;
            lblRoomName.Location = new Point(116, 28);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(77, 15);
            lblRoomName.TabIndex = 0;
            lblRoomName.Text = "Room Name:";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(218, 20);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(123, 23);
            txtRoomName.TabIndex = 1;
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Location = new Point(127, 58);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(69, 15);
            lblRoomType.TabIndex = 2;
            lblRoomType.Text = "Room Type:";
            // 
            // cmbRoomType
            // 
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Location = new Point(220, 50);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(121, 23);
            cmbRoomType.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(116, 114);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(266, 114);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(425, 114);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewRooms
            // 
            dataGridViewRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRooms.Location = new Point(88, 181);
            dataGridViewRooms.Name = "dataGridViewRooms";
            dataGridViewRooms.Size = new Size(466, 150);
            dataGridViewRooms.TabIndex = 7;
            dataGridViewRooms.Click += dataGridViewRooms_SelectionChanged;
            // 
            // SubRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewRooms);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmbRoomType);
            Controls.Add(lblRoomType);
            Controls.Add(txtRoomName);
            Controls.Add(lblRoomName);
            Name = "SubRoomForm";
            Text = "SubRoomForm";
            Load += SubRoomForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomName;
        private TextBox txtRoomName;
        private Label lblRoomType;
        private ComboBox cmbRoomType;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridViewRooms;
    }
}