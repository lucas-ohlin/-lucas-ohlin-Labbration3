using System;
using System.Collections.Generic;

namespace Labb3EF_Final.Models
{
    public partial class staff
    {
        public staff()
        {
            Courses = new HashSet<Course>();
        }

        public int StaffId { get; set; }
        public string Title { get; set; } = null!;

        public virtual Person Staff { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; }
    }
}
