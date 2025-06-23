using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    internal class SubTimetableController
    {
        public static List<SubTimetable> GetAll()
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "SELECT * FROM SubTimetable";
                return con.Query<SubTimetable>(query).ToList();
            }
        }

        public static bool Insert(SubTimetable timetable)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = @"INSERT INTO SubTimetable (StuSubjectId, SubTimeslot, RoomId)
                                 VALUES (@StuSubjectId, @SubTimeslot, @RoomId)";
                return con.Execute(query, timetable) > 0;
            }
        }

        public static bool Delete(int id)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "DELETE FROM SubTimetable WHERE TimetableId = @id";
                return con.Execute(query, new { id }) > 0;
            }
        }
    }
}

    

