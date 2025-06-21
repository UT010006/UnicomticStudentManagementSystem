using StudentManagementSystem.MODELS;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    internal class StuAttendanceController
    {
        public static void Insert(StuAttendance attendance)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "INSERT INTO StuAttendance (StuId, StuSubjectId, Date, Status) VALUES (@stuId, @subjectId, @date, @status)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@stuId", attendance.StuId);
                    cmd.Parameters.AddWithValue("@subjectId", attendance.StuSubjectId);
                    cmd.Parameters.AddWithValue("@date", attendance.Date);
                    cmd.Parameters.AddWithValue("@status", attendance.Status);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static List<StuAttendance> GetAll()
        {
            var list = new List<StuAttendance>();

            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "SELECT * FROM StuAttendance";
                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new StuAttendance
                        {
                            StuId = Convert.ToInt32(reader["StuId"]),
                            StuSubjectId = Convert.ToInt32(reader["StuSubjectId"]),
                            Date = reader["Date"].ToString() ?? string.Empty,
                            Status = reader["Status"].ToString() ?? string.Empty
                        });
                    }
                }
            }

            return list;
        }
    }
}

    

