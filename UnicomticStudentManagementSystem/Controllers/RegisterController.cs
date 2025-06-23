using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    internal class RegisterController
    {
        public static bool RegisterUser(string username, string password, string role)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string checkQuery = "SELECT COUNT(*) FROM UserDetails WHERE UserName = @uname AND UserRole = @role";
                using (var checkCmd = new SQLiteCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@uname", username);
                    checkCmd.Parameters.AddWithValue("@role", role);

                    long exists = (long)checkCmd.ExecuteScalar();
                    if (exists > 0)
                        return false; // user with same name+role already exists
                }

                string insertQuery = "INSERT INTO UserDetails (UserName, UserPassword, UserRole) VALUES (@uname, @pass, @role)";
                using (var insertCmd = new SQLiteCommand(insertQuery, con))
                {
                    insertCmd.Parameters.AddWithValue("@uname", username);
                    insertCmd.Parameters.AddWithValue("@pass", password);
                    insertCmd.Parameters.AddWithValue("@role", role);
                    insertCmd.ExecuteNonQuery();
                }
                return true;
            }
        }
    }
}

    

