using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    public class StuAttendance
    {
        public int StuId { get; set; }
        public int StuSubjectId { get; set; }
        public string Date { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty; // e.g., "Present" or "Absent"
    }
}
