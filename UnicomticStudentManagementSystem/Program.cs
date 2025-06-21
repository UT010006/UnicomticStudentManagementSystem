using StudentManagementSystem.FORMS;
using System;
using System.Windows.Forms;

namespace StudentManagementSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {


            // Initialize the SQLite database and create tables if not exist
            DatabaseManagement.InitializeDatabase();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Replace LoginForm with your actual starting form (e.g., MainForm)
            Application.Run(new LoginForm());
        }
    } 
}