using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.MODELS
{
    public class StudentDetails
    {
        public int StuId { get; set; }
        public string StuName { get; set; } = string.Empty;
        public int StuCourseId
        {
            get; set;

        }
    }
}
