﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Entities
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Bonus { get; set; }
        public double Salary { get; set; }
        public string? Address { get; set; }
        public double HourRate { get; set; }

        [InverseProperty(nameof(Department.ManagerId))] 
        public Department MangeDepartment { get; set; }
        [ForeignKey(nameof(WorkForDepartment))]
        public int ?DepartmetId { get; set; }
        public Department WorkForDepartment { get; set; }
        public ICollection<InstructorCourse> instructorCourses{ get; set; }= new HashSet<InstructorCourse>();
    }
}