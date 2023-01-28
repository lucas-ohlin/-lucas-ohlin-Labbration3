using System;
using System.Collections.Generic;

namespace Labb3EF_Final.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string ClassName { get; set; } = null!;
        public string PersonNumber { get; set; } = null!;

        public virtual Person StudentNavigation { get; set; } = null!;
    }
}
