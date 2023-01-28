using System;
using System.Collections.Generic;

namespace Labb3EF_Final.Models
{
    public partial class Grade
    {
        public string? Grade1 { get; set; }
        public DateTime? GradeDate { get; set; }
        public int CourseId { get; set; }
        public int StaffId { get; set; }
        public int StudentId { get; set; }

        public virtual Course Course { get; set; } = null!;
        public virtual staff Staff { get; set; } = null!;
        public virtual Student Student { get; set; } = null!;
    }
}
