using System;
using System.Collections.Generic;

namespace UiFIS_Prototype
{
    public partial class Place
    {
        public Place()
        {
            Emcs = new HashSet<Emc>();
        }

        public int Id { get; set; }
        public string? Adress { get; set; }

        public virtual ICollection<Emc> Emcs { get; set; }
    }
}
