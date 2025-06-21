using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class SubTimetable
    {
        public int  TimetableId { get; set; } 
        public string StuSubjectId { get; set; } = string.Empty;
        public string SubTimeslot { get; set; } = string.Empty;
        public int RoomId { get; set; }

    }
}
