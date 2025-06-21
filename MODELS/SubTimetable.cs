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
        public string StuSubjectId { get; set; }
        public string SubTimeslot { get; set; }
        public int RoomId { get; set; }

    }
}
