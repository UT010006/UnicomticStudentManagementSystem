﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class StuSubject
    {
        public int StuSubjectId { get; set; }
        public string StuSubjectName { get; set; } = string.Empty;
        public int StuCourseId { get; set; }
    }
}
