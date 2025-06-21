using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StudentManagementSystem.Controllers
{
    public class StuCourseController
    {
        public static List<StudentCourse> GetAll()
        {
            var list = new List<StudentCourse>();

            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "SELECT * FROM StudentCourse";
                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new StudentCourse
                        {
                            StuCourseId = Convert.ToInt32(reader["StuCourseId"]),
                            StuCourseName = reader["StuCourseName"].ToString() ?? string.Empty
                        });
                    }
                }
            }

            return list;
        }

        // Insert new course
        public static void Insert(StudentCourse course)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "INSERT INTO StudentCourse (StuCourseName) VALUES (@name)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", course.StuCourseName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Update course
        public static void Update(StudentCourse course)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "UPDATE StudentCourse SET StuCourseName = @name WHERE StuCourseId = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", course.StuCourseName);
                    cmd.Parameters.AddWithValue("@id", course.StuCourseId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete course
        public static void Delete(int id)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "DELETE FROM StudentCourse WHERE StuCourseId = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ✅ Get course name by ID (for use in StuSubjectForm)
        public static string? GetCourseNameById(int courseId)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "SELECT StuCourseName FROM StudentCourse WHERE StuCourseId = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", courseId);
                    var result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }
    }
}
