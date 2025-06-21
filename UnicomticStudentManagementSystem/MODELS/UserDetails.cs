using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem
{
    internal class UserDetails
    {
        public int UserId { get; set; } 
        public string UserName { get; set; } = string.Empty;
        public string UserPassword { get; set; } = string.Empty;
        public string UserRole { get; set; } = string.Empty;
    }
}
