using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    internal  class StuExamController
    {
        public static List<StuExam> GetAll()
        {
            var list = new List<StuExam>();

            using (var con = DatabaseManagement.GetConnection())
            {
               
                string query = "SELECT * FROM StuExam";
                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new StuExam
                        {
                            ExamId = Convert.ToInt32(reader["ExamId"]),
                            ExamName = reader["ExamName"].ToString() ?? "",
                            StuSubjectId = Convert.ToInt32(reader["StuSubjectId"])
                        });
                    }
                }
            }

            return list;
        }

        public static void Insert(StuExam exam)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                
                string query = "INSERT INTO StuExam (ExamName, StuSubjectId) VALUES (@name, @subjectId)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.StuSubjectId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(StuExam exam)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
               
                string query = "UPDATE StuExam SET ExamName = @name, StuSubjectId = @subjectId WHERE ExamId = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.StuSubjectId);
                    cmd.Parameters.AddWithValue("@id", exam.ExamId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int examId)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                
                string query = "DELETE FROM StuExam WHERE ExamId = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", examId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

    

