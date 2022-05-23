using System;
using System.Collections.Generic;

namespace UiFIS_Prototype
{
    public partial class BloodGroup
    {
        public BloodGroup()
        {
            People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Groups { get; set; } = null!;

        public virtual ICollection<Person> People { get; set; }
    }
}
