﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentEFCodeFirstApp
{
    internal class Student
    {
        public int Id { get; set; }           // Primary key (auto-inferred by EF)
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
