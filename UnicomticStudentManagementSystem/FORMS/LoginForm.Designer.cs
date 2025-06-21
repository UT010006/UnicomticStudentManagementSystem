namespace StudentManagementSystem.FORMS
{
    partial class LoginForm
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
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            button1 = new Button();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblError = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(174, 78);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 108);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(270, 70);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(302, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(270, 108);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(302, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(348, 190);
            button1.Name = "button1";
            button1.Size = new Size(336, 131);
            button1.TabIndex = 4;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(193, 140);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(30, 15);
            lblRole.TabIndex = 5;
            lblRole.Text = "Role";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(309, 137);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(121, 23);
            cmbRole.TabIndex = 6;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Location = new Point(316, 336);
            lblError.Name = "lblError";
            lblError.Size = new Size(169, 15);
            lblError.TabIndex = 7;
            lblError.Text = "Invalid userName or password!";
            lblError.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblError);
            Controls.Add(cmbRole);
            Controls.Add(lblRole);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button button1;
        private Label lblRole;
        private ComboBox cmbRole;
        private Label lblError;
    }
}