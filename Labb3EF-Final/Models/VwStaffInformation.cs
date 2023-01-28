using System;
using System.Collections.Generic;

namespace Labb3EF_Final.Models
{
    public partial class VwStaffInformation
    {
        public int Id { get; set; }
        public string Fname { get; set; } = null!;
        public string Lname { get; set; } = null!;
        public string Title { get; set; } = null!;
    }
}
