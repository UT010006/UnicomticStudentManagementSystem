using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    internal class StuScoreController
    {
        public static List<StuScore> GetAll()
        {
            var list = new List<StuScore>();

            using (var con = DatabaseManagement.GetConnection())
            {
                
                string query = "SELECT * FROM StuScore";
                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new StuScore
                        {
                            StuId = Convert.ToInt32(reader["StuId"]),
                            ExamId = Convert.ToInt32(reader["ExamId"]),
                            Score = Convert.ToInt32(reader["Score"])
                        });
                    }
                }
            }

            return list;
        }

        public static void Insert(StuScore score)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                
                string query = "INSERT INTO StuScore (StuId, ExamId, Score) VALUES (@StuId, @ExamId, @Score)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StuId", score.StuId);
                    cmd.Parameters.AddWithValue("@ExamId", score.ExamId);
                    cmd.Parameters.AddWithValue("@Score", score.Score);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Update(StuScore score)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                
                string query = "UPDATE StuScore SET Score = @Score WHERE StuId = @StuId AND ExamId = @ExamId";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Score", score.Score);
                    cmd.Parameters.AddWithValue("@StuId", score.StuId);
                    cmd.Parameters.AddWithValue("@ExamId", score.ExamId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int stuId, int examId)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                
                string query = "DELETE FROM StuScore WHERE StuId = @StuId AND ExamId = @ExamId";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StuId", stuId);
                    cmd.Parameters.AddWithValue("@ExamId", examId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

    

