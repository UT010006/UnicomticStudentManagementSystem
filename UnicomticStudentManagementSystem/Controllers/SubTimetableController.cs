using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    internal class SubTimetableController
    {
        public static List<SubTimetable> GetAll()
        {
            var list = new List<SubTimetable>();
            using (var con = DatabaseManagement.GetConnection())
            {
               
                string query = "SELECT * FROM SubTimetable";
                using (var cmd = new SQLiteCommand(query, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new SubTimetable
                        {
                            TimetableId = Convert.ToInt32(reader["TimetableId"]),
                            StuSubjectId = reader["StuSubjectId"].ToString() ?? "",
                            SubTimeslot = reader["SubTimeslot"].ToString() ?? "",
                            RoomId = Convert.ToInt32(reader["RoomId"])
                        });
                    }
                }
            }
            return list;
        }

        public static void Insert(SubTimetable timetable)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                
                string query = "INSERT INTO SubTimetable (StuSubjectId, SubTimeslot, RoomId) VALUES (@subId, @timeslot, @roomId)";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@subId", timetable.StuSubjectId);
                    cmd.Parameters.AddWithValue("@timeslot", timetable.SubTimeslot);
                    cmd.Parameters.AddWithValue("@roomId", timetable.RoomId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void Delete(int timetableId)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                
                string query = "DELETE FROM SubTimetable WHERE TimetableId = @id";
                using (var cmd = new SQLiteCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@id", timetableId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

    

