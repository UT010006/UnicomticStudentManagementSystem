﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.MODELS
{
    public class LecturerDetails : Person
    {
        public int LecturerId { get; set; }
        public string LecturerName { get; set; } = string.Empty;
    }
}
