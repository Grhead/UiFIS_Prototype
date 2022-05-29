using System.Collections.Generic;

namespace UiFIS_Prototype
{
    public partial class Gender
    {
        public Gender()
        {
            People = new HashSet<Person>();
        }

        public int Id { get; set; }
        public string Gender1 { get; set; } = null!;

        public virtual ICollection<Person> People { get; set; }
    }
}
