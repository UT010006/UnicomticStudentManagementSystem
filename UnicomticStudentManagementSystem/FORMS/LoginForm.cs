using StudentManagementSystem.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem.FORMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Student");
            cmbRole.Items.Add("Staff"); // ✅ added staff
            cmbRole.SelectedIndex = 0;
            lblError.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string? role = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                lblError.Text = "Please fill all fields.";
                lblError.Visible = true;
                return;
            }

            bool result = LoginController.Authenticate(username, password, role);
            if (result)
            {
                this.Hide();
                DashBoardForm dash = new DashBoardForm(); // ✅ Adjust if role-specific dashboard
                dash.Show();
            }
            else
            {
                lblError.Text = "Invalid credentials.";
                lblError.Visible = true;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

        
    

