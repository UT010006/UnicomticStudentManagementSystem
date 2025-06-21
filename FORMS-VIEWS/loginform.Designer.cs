namespace StudentManagementSystem
{
    partial class loginform
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
            this.USERIDlabel = new System.Windows.Forms.Label();
            this.USERNAMElabel = new System.Windows.Forms.Label();
            this.USERIDbox = new System.Windows.Forms.TextBox();
            this.USERNAMEbox = new System.Windows.Forms.TextBox();
            this.LOGIN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // USERIDlabel
            // 
            this.USERIDlabel.AutoSize = true;
            this.USERIDlabel.Location = new System.Drawing.Point(356, 143);
            this.USERIDlabel.Name = "USERIDlabel";
            this.USERIDlabel.Size = new System.Drawing.Size(48, 13);
            this.USERIDlabel.TabIndex = 0;
            this.USERIDlabel.Text = "USERID";
            this.USERIDlabel.Click += new System.EventHandler(this.USERIDlabel_Click);
            // 
            // USERNAMElabel
            // 
            this.USERNAMElabel.AutoSize = true;
            this.USERNAMElabel.Location = new System.Drawing.Point(346, 75);
            this.USERNAMElabel.Name = "USERNAMElabel";
            this.USERNAMElabel.Size = new System.Drawing.Size(68, 13);
            this.USERNAMElabel.TabIndex = 1;
            this.USERNAMElabel.Text = "USERNAME";
            this.USERNAMElabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // USERIDbox
            // 
            this.USERIDbox.Location = new System.Drawing.Point(225, 183);
            this.USERIDbox.Name = "USERIDbox";
            this.USERIDbox.Size = new System.Drawing.Size(291, 20);
            this.USERIDbox.TabIndex = 5;
            this.USERIDbox.TextChanged += new System.EventHandler(this.IDbox_TextChanged);
            // 
            // USERNAMEbox
            // 
            this.USERNAMEbox.Location = new System.Drawing.Point(225, 107);
            this.USERNAMEbox.Name = "USERNAMEbox";
            this.USERNAMEbox.Size = new System.Drawing.Size(291, 20);
            this.USERNAMEbox.TabIndex = 6;
            // 
            // LOGIN
            // 
            this.LOGIN.Location = new System.Drawing.Point(349, 281);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(122, 23);
            this.LOGIN.TabIndex = 7;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.UseVisualStyleBackColor = true;
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.USERNAMEbox);
            this.Controls.Add(this.USERIDbox);
            this.Controls.Add(this.USERNAMElabel);
            this.Controls.Add(this.USERIDlabel);
            this.Name = "loginform";
            this.Text = "LOGINVIEW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label USERIDlabel;
        private System.Windows.Forms.Label USERNAMElabel;
        private System.Windows.Forms.TextBox USERIDbox;
        private System.Windows.Forms.TextBox USERNAMEbox;
        private System.Windows.Forms.Button LOGIN;
    }
}

