using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    public partial class loginform : System.Windows.Forms.Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            String Username=USERNAMEbox.Text;
            string UserPassword=USERIDbox.Text;
            if (Username =="Admin" && UserPassword == "1234") 
            {
                MessageBox.Show("Login Siccessfully!");
                DashBoardForm dashboard = new DashBoardForm();
                dashboard.Show();
                this.Hide();

            }
            else 
            {
                MessageBox.Show("Invalid UserName or Pssword");
            }

        }

        private void IDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void USERIDlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
