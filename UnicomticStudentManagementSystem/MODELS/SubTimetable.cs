using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class SubTimetable
    {
        public int  TimetableId { get; set; } 
        public int StuSubjectId { get; set; } 
        public string SubTimeslot { get; set; } = string.Empty;
        public int RoomId { get; set; }

    }
}
