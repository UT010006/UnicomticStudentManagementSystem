using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using StudentManagementSystem.Controllers;

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
            // Load roles into the ComboBox
            cmbRole.Items.Clear();
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Lecturer");
            cmbRole.Items.Add("Student");

            // Select first role by default
            cmbRole.SelectedIndex = 0;

            // Hide error label on load
            lblError.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string? role = cmbRole.SelectedItem?.ToString(); // nullable string to avoid warning

            // Validate inputs
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                lblError.Text = "Please fill all fields.";
                lblError.Visible = true;
                return;
            }

            try
            {
                using (var con = DatabaseManagement.GetConnection())
                {
                    string query = "SELECT * FROM UserDetails WHERE UserName=@uname AND UserPassword=@pass AND UserRole=@role";
                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@uname", username);
                        cmd.Parameters.AddWithValue("@pass", password);
                        cmd.Parameters.AddWithValue("@role", role);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Successful login
                                this.Hide();
                                DashBoardForm dash = new DashBoardForm(); // optionally pass user data
                                dash.Show();
                            }
                            else
                            {
                                lblError.Text = "Invalid credentials.";
                                lblError.Visible = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database:\n" + ex.Message, "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}