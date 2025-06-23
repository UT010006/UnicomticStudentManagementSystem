using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    internal class LoginController
    {
        public static bool Authenticate(string username, string password, string role)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "SELECT COUNT(*) FROM UserDetails WHERE UserName = @uname AND UserPassword = @pass AND UserRole = @role";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@uname", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    long count = (long)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }
    }
}
