using System;
using System.Collections.Generic;
using System.Data.SQLite;
using StudentManagementSystem.MODELS;

namespace StudentManagementSystem.Controllers
{
    public static class StudentDetailsController
    {
        public static List<StudentDetails> GetAll()
        {
            var list = new List<StudentDetails>();

            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "SELECT * FROM StudentDetails";
                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new StudentDetails
                        {
                            StuId = Convert.ToInt32(reader["StuId"]),
                            StuName = reader["StuName"]?.ToString() ?? string.Empty,
                            StuCourseId = Convert.ToInt32(reader["StuCourseId"])
                        });
                    }
                }
            }

            return list;
        }

        public static void Insert(StudentDetails student)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "INSERT INTO StudentDetails (StuName, StuCourseId) VALUES (@name, @courseId)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", student.StuName);
                    cmd.Parameters.AddWithValue("@courseId", student.StuCourseId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(StudentDetails student)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "UPDATE StudentDetails SET StuName=@name, StuCourseId=@courseId WHERE StuId=@id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", student.StuName);
                    cmd.Parameters.AddWithValue("@courseId", student.StuCourseId);
                    cmd.Parameters.AddWithValue("@id", student.StuId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "DELETE FROM StudentDetails WHERE StuId=@id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
