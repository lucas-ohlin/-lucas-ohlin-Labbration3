using System;
using System.Collections.Generic;

namespace Labb3EF_Final.Models
{
    public partial class Person
    {
        public int Id { get; set; }
        public string Fname { get; set; } = null!;
        public string Lname { get; set; } = null!;

        public virtual Student? Student { get; set; }
        public virtual staff? staff { get; set; }
    }
}
