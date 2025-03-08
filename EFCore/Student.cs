﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string? LName { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }

        public int? DepartmentId { get; set; } //FK
        public Department Department { get; set; }

        public ICollection<StudentCourse> Courses { get; set; } = new HashSet<StudentCourse>();
    }

}