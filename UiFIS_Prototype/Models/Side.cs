using System.Collections.Generic;

namespace UiFIS_Prototype
{
    public partial class Side
    {
        public Side()
        {
            People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int Side1 { get; set; }

        public virtual ICollection<Person> People { get; set; }
    }
}
