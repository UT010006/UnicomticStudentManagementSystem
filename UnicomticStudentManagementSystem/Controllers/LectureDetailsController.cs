using StudentManagementSystem.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;


namespace StudentManagementSystem.Controllers
{
    internal class LectureDetailsController
    {
        public void AddLecturer(LecturerDetails lecturer)
        {
            using (IDbConnection connection = DatabaseManagement.GetConnection())
            {
                string query = "INSERT INTO LecturerDetails (LecturerName, Email, Department) VALUES (@LecturerName, @Email, @Department)";
                connection.Execute(query, lecturer);
            }
        }

        public List<LecturerDetails> GetAllLecturers()
        {
            using (IDbConnection connection = DatabaseManagement.GetConnection())
            {
                string query = "SELECT * FROM LecturerDetails";
                return connection.Query<LecturerDetails>(query).ToList();
            }
        }

        public void UpdateLecturer(LecturerDetails lecturer)
        {
            using (IDbConnection connection = DatabaseManagement.GetConnection())
            {
                string query = "UPDATE LecturerDetails SET LecturerName = @LecturerName, Email = @Email, Department = @Department WHERE LecturerId = @LecturerId";
                connection.Execute(query, lecturer);
            }
        }

        public void DeleteLecturer(int id)
        {
            using (IDbConnection connection = DatabaseManagement.GetConnection())
            {
                string query = "DELETE FROM LecturerDetails WHERE LecturerId = @id";
                connection.Execute(query, new { id });
            }
        }
    }
}
