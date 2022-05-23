using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        private string _selectedComboBoxItem;
        public string SelectedComboBoxItem
        {
            get { return _selectedComboBoxItem; }
            set { _selectedComboBoxItem = value; OnPropertyChanged(); }
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
    }
}
