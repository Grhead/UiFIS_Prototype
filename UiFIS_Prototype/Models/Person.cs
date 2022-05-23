using System;
using System.Collections.Generic;

namespace UiFIS_Prototype
{
    public partial class Person
    {
        public Person()
        {
            Emcs = new HashSet<Emc>();
            PatientRecords = new HashSet<PatientRecord>();
            RecordDoctorNavigations = new HashSet<Record>();
            RecordPatientNavigations = new HashSet<Record>();
        }

        public int Id { get; set; }
        public string SecondName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; }
        public int Gender { get; set; }
        public DateTime BirthdayDate { get; set; }
        public int Passport { get; set; }
        public string Polices { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public int Blood { get; set; }
        public int Side { get; set; }
        public string Logins { get; set; } = null!;
        public string Passwords { get; set; } = null!;
        public string Adress { get; set; } = null!;

        public virtual BloodGroup BloodNavigation { get; set; } = null!;
        public virtual Gender GenderNavigation { get; set; } = null!;
        public virtual Passport PassportNavigation { get; set; } = null!;
        public virtual Side SideNavigation { get; set; } = null!;
        public virtual ICollection<Emc> Emcs { get; set; }
        public virtual ICollection<PatientRecord> PatientRecords { get; set; }
        public virtual ICollection<Record> RecordDoctorNavigations { get; set; }
        public virtual ICollection<Record> RecordPatientNavigations { get; set; }
    }
}
