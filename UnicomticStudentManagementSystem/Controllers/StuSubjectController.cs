using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    internal class StuSubjectController
    {
        public static List<StuSubject> GetAll()
        {
            var list = new List<StuSubject>();

            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "SELECT * FROM StuSubject";
                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new StuSubject
                        {
                            StuSubjectId = Convert.ToInt32(reader["StuSubjectId"]),
                            StuSubjectName = reader["StuSubjectName"].ToString(),
                            StuCourseId = Convert.ToInt32(reader["StuCourseId"])
                        });
                    }
                }
            }

            return list;
        }

        public static void Insert(StuSubject subject)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "INSERT INTO StuSubject (StuSubjectName, StuCourseId) VALUES (@name, @courseId)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", subject.StuSubjectName);
                    cmd.Parameters.AddWithValue("@courseId", subject.StuCourseId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(StuSubject subject)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "UPDATE StuSubject SET StuSubjectName=@name, StuCourseId=@courseId WHERE StuSubjectId=@id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", subject.StuSubjectName);
                    cmd.Parameters.AddWithValue("@courseId", subject.StuCourseId);
                    cmd.Parameters.AddWithValue("@id", subject.StuSubjectId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "DELETE FROM StuSubject WHERE StuSubjectId=@id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
