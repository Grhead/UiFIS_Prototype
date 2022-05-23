using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.ViewModel
{
    public class AddRecordViewModel : StaticViewModel
    {
        public AddRecordViewModel()
        {
            ListOfTypes = new List<TypeOfDiagnosis>(Service.db.TypeOfDiagnoses);
            ListOfPatient = new List<Person>(Service.db.People.Where(x => x.Side == 1));
            ListOfDoctors = new List<Person>(Service.db.People.Where(x => x.Side == 1));
        }
        private List<TypeOfDiagnosis> _listOfTypes;
        public List<TypeOfDiagnosis> ListOfTypes
        {
            get { return _listOfTypes; }
            set { _listOfTypes = value; OnPropertyChanged(); }
        }
        private TypeOfDiagnosis _selectedComboBoxItem;
        public TypeOfDiagnosis SelectedComboBoxItem
        {
            get { return _selectedComboBoxItem; }
            set { _selectedComboBoxItem = value; OnPropertyChanged(); }
        }
        private Person _selectedPatientItem;
        public Person SelectedPatientItem
        {
            get { return _selectedPatientItem; }
            set { _selectedPatientItem = value; OnPropertyChanged(); }
        }
        private Person _selectedDoctorItem;
        public Person SelectedDoctorItem
        {
            get { return _selectedDoctorItem; }
            set { _selectedDoctorItem = value; OnPropertyChanged(); }
        }

        private List<Person> _listOfDoctors;
        public List<Person> ListOfDoctors
        {
            get { return _listOfDoctors; }
            set { _listOfDoctors = value; OnPropertyChanged(); }
        }
        private List<Person> _listOfPatient;
        public List<Person> ListOfPatient
        {
            get { return _listOfPatient; }
            set { _listOfPatient = value; OnPropertyChanged(); }
        }
        private string _doctorAdress;
        public string DoctorAdress
        {
            get { return _doctorAdress; }
            set { _doctorAdress = value; OnPropertyChanged(); }
        }
        private string _patientSN;
        public string PatientSN
        {
            get { return _patientSN; }
            set { _patientSN = value; OnPropertyChanged(); }
        }
        public string SymptomText { get; set; }
        private RelayCommand _doctorAdressSearch;
        public RelayCommand DoctorAdressSearch => _doctorAdressSearch ?? (_doctorAdressSearch = new RelayCommand(x =>
        {
            ListOfDoctors = new List<Person>(Service.db.People.Where(x => x.Side == 1 && x.Adress.Contains(DoctorAdress) == true));
        }));
        private RelayCommand _patientSNSearch;
        public RelayCommand PatientSNSearch => _patientSNSearch ?? (_patientSNSearch = new RelayCommand(x =>
        {
            ListOfPatient = new List<Person>(Service.db.People.Where(x => x.Side == 1 && x.SecondName.Contains(PatientSN) == true));
        }));
        private RelayCommand _setRecord;
        public RelayCommand SetRecord => _setRecord ?? (_setRecord = new RelayCommand(x =>
        {
            Record ToPush = new Record();
            if (SelectedDoctorItem != null && SelectedComboBoxItem != null && SymptomText != null && SelectedPatientItem !=  null)
            {
                ToPush.Doctor = Service.db.People.FirstOrDefault(x => x.Logins == SelectedDoctorItem.Logins).Id;
                ToPush.Patient = Service.db.People.FirstOrDefault(x => x.Polices == SelectedPatientItem.Polices).Id;
                ToPush.Symptom = SymptomText;
                ToPush.TypeOfDiagnosis = SelectedComboBoxItem.Id;
                ToPush.RecordTime = DateTime.Now;
                Service.db.Add(ToPush);
                Service.db.SaveChanges();
                MessageBox.Show("Ok");
            }
        }));
    }
}
