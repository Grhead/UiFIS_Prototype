using System;

namespace UiFIS_Prototype
{
    public partial class Emc
    {
        public int Id { get; set; }
        public DateTime Registration { get; set; }
        public int Patient { get; set; }
        public int Place { get; set; }

        public virtual Person PatientNavigation { get; set; } = null!;
        public virtual Place PlaceNavigation { get; set; } = null!;
    }
}
