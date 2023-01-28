using System;
using System.Collections.Generic;

namespace Labb3EF_Final.Models
{
    public partial class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; } = null!;
        public int StaffId { get; set; }

        public virtual staff Staff { get; set; } = null!;
    }
}
