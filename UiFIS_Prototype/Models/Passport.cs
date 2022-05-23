using System;
using System.Collections.Generic;

namespace UiFIS_Prototype
{
    public partial class Passport
    {
        public Passport()
        {
            People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public int Series { get; set; }
        public int Number { get; set; }
        public int DivisionCode { get; set; }
        public string Division { get; set; } = null!;
        public string DateOfIssue { get; set; } = null!;

        public virtual ICollection<Person> People { get; set; }
    }
}
