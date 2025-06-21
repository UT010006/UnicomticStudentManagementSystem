using StudentManagementSystem;

namespace UnicomticStudentManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                DatabaseManagement.Initialize();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database  initialization failed:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.Run(new loginform());
            Application.Run(new Form1());
        }
    }
}