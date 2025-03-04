using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Entities
{
    internal class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public int? duration { get; set; }

    }
}