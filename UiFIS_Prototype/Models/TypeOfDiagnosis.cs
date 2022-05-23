using System;
using System.Collections.Generic;

namespace UiFIS_Prototype
{
    public partial class TypeOfDiagnosis
    {
        public TypeOfDiagnosis()
        {
            Records = new HashSet<Record>();
        }

        public int Id { get; set; }
        public string TypeOfDiagnosis1 { get; set; } = null!;

        public virtual ICollection<Record> Records { get; set; }
    }
}
