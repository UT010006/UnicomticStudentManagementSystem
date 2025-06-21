using StudentManagementSystem.MODELS;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    internal class LecturerDetailsController
    {
        public static List<LecturerDetails> GetAll()
        {
            var list = new List<LecturerDetails>();

            using (var con = DatabaseManagement.GetConnection())
            {
                con.Open();
                string query = "SELECT * FROM LecturerDetails";
                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new LecturerDetails
                        {
                            LectureId = Convert.ToInt32(reader["LectureId"]),
                            LectureName = reader["LectureName"].ToString() ?? "",
                            StuSubjectName = reader["StuSubjectName"].ToString() ?? ""
                        });
                    }
                }
            }

            return list;
        }

        public static void Insert(LecturerDetails lecturer)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                con.Open();
                string query = "INSERT INTO LecturerDetails (LectureName, StuSubjectName) VALUES (@LectureName, @StuSubjectName)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@LectureName", lecturer.LectureName);
                    cmd.Parameters.AddWithValue("@StuSubjectName", lecturer.StuSubjectName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(LecturerDetails lecturer)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                con.Open();
                string query = "UPDATE LecturerDetails SET LectureName = @LectureName, StuSubjectName = @StuSubjectName WHERE LectureId = @LectureId";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@LectureName", lecturer.LectureName);
                    cmd.Parameters.AddWithValue("@StuSubjectName", lecturer.StuSubjectName);
                    cmd.Parameters.AddWithValue("@LectureId", lecturer.LectureId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int id)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                con.Open();
                string query = "DELETE FROM LecturerDetails WHERE LectureId = @LectureId";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@LectureId", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

    

