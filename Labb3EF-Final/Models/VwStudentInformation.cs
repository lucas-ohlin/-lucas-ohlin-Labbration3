using System;
using System.Collections.Generic;

namespace Labb3EF_Final.Models
{
    public partial class VwStudentInformation
    {
        public int Id { get; set; }
        public string Fname { get; set; } = null!;
        public string Lname { get; set; } = null!;
        public string PersonNumber { get; set; } = null!;
        public string Class { get; set; } = null!;
    }
}
