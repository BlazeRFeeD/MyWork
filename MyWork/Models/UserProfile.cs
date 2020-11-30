using System;
using System.Collections.Generic;
using System.Text;
using SharpDX.Direct2D1;

namespace MyWork.Models
{
    public class UserProfile
    {
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public Salary Salary { get; set; }
    }
}
