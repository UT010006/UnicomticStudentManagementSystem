using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Controllers
{
    internal class SubRoomController
    {
        public static List<SubRoom> GetAll()
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "SELECT * FROM SubRoom;";
                return con.Query<SubRoom>(query).AsList();
            }
        }

        public static bool Insert(SubRoom room)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "INSERT INTO SubRoom (RoomName, RoomType) VALUES (@RoomName, @RoomType);";
                return con.Execute(query, room) > 0;
            }
        }

        public static bool Update(SubRoom room)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "UPDATE SubRoom SET RoomName = @RoomName, RoomType = @RoomType WHERE RoomId = @RoomId;";
                return con.Execute(query, room) > 0;
            }
        }

        public static bool Delete(int roomId)
        {
            using (var con = DatabaseManagement.GetConnection())
            {
                string query = "DELETE FROM SubRoom WHERE RoomId = @RoomId;";
                return con.Execute(query, new { RoomId = roomId }) > 0;
            }
        }
    }
}

    

