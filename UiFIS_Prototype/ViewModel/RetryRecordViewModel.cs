using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.ViewModel
{
    public class RetryRecordViewModel : StaticViewModel
    {
        public RetryRecordViewModel()
        {
            if (Service.DNVM.SelectedRecord != null)
            {
                Symptom = Service.DNVM.SelectedRecord.Symptom;
                Medicaments = Service.DNVM.SelectedRecord.Medicament;
                Procedures = Service.DNVM.SelectedRecord.Procedures;
            }
        }
        private RelayCommand _filter;
        public RelayCommand Filter => _filter ?? (_filter = new RelayCommand(x =>
        {
        if (Service.DNVM != null && Symptom != null && Medicaments != null && Procedures != null)
            {
                var ToPush = Service.DNVM.SelectedRecord;
                ToPush.Symptom = Symptom;
                ToPush.Medicament = Medicaments;
                ToPush.Procedures = Procedures;
                Service.db.SaveChanges();
            }
            
        }));
        private string _symptom;
        public string Symptom
        {
            get
            {
                return _symptom;
            }
            set
            {
                _symptom = value;
                OnPropertyChanged();
            }
        }
        private string _medicaments;
        public string Medicaments
        {
            get { return _medicaments; }
            set { _medicaments = value; OnPropertyChanged(); }
        }
        private string _procedures;
        public string Procedures
        {
            get { return _procedures; }
            set { _procedures = value; OnPropertyChanged(); }
        }
    }

}
