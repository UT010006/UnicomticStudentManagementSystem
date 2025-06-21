using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    
        public class TopMark
        {
            public string StuName { get; set; } = string.Empty;
            public string ExamName { get; set; } = string.Empty;
            public int Score { get; set; }
        }

        public static class StuTopMarksController
        {
            public static List<TopMark> GetTopMarks(int topN = 5)
            {
                var list = new List<TopMark>();

                using (var con = DatabaseManagement.GetConnection())
                {
                    

                    string query = $@"
                    SELECT s.StuName, e.ExamName, sc.Score
                    FROM StuScore sc
                    JOIN StudentDetails s ON s.StuId = sc.StuId
                    JOIN StuExam e ON e.ExamId = sc.ExamId
                    ORDER BY sc.Score DESC
                    LIMIT @limit";

                    using (var cmd = new SQLiteCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@limit", topN);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(new TopMark
                                {
                                    StuName = reader["StuName"]?.ToString() ?? string.Empty,
                                    ExamName = reader["ExamName"]?.ToString() ?? string.Empty,
                                    Score = Convert.ToInt32(reader["Score"])
                                });
                            }
                        }
                    }
                }

                return list;
            }
        }
    }



