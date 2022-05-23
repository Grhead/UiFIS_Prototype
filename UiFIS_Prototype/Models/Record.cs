using System;
using System.Collections.Generic;

namespace UiFIS_Prototype
{
    public partial class Record
    {
        public Record()
        {
            PatientRecords = new HashSet<PatientRecord>();
        }

        public int Id { get; set; }
        public DateTime RecordTime { get; set; }
        public int TypeOfDiagnosis { get; set; }
        public string? Symptom { get; set; }
        public string? Medicament { get; set; }
        public string? Procedures { get; set; }
        public int Doctor { get; set; }
        public int Patient { get; set; }

        public virtual Person DoctorNavigation { get; set; } = null!;
        public virtual Person PatientNavigation { get; set; } = null!;
        public virtual TypeOfDiagnosis TypeOfDiagnosisNavigation { get; set; } = null!;
        public virtual ICollection<PatientRecord> PatientRecords { get; set; }
    }
}
