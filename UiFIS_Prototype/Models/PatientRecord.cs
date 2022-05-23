using System;
using System.Collections.Generic;

namespace UiFIS_Prototype
{
    public partial class PatientRecord
    {
        public int Id { get; set; }
        public int Patient { get; set; }
        public int Record { get; set; }

        public virtual Person PatientNavigation { get; set; } = null!;
        public virtual Record RecordNavigation { get; set; } = null!;
    }
}
