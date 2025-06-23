using Dapper;
using StudentManagementSystem.MODELS;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    public static  class StuAttendanceController
    {
        public static List<StuAttendance> GetAll()
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "SELECT * FROM StuAttendance";
                return con.Query<StuAttendance>(query).ToList();
            }
        }

        public static bool Insert(StuAttendance attendance)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = @"INSERT INTO StuAttendance (StuId, StuSubjectId, Date, Status)
                                 VALUES (@StuId, @StuSubjectId, @Date, @Status)";
                return con.Execute(query, attendance) > 0;
            }
        }

        public static bool Delete(int stuId, int subjectId, string date)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = @"DELETE FROM StuAttendance 
                                 WHERE StuId = @StuId AND StuSubjectId = @StuSubjectId AND Date = @Date";
                return con.Execute(query, new { StuId = stuId, StuSubjectId = subjectId, Date = date }) > 0;
            }
        }
    }
}
