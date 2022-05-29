using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.ViewModel
{
    public class ViewRecordsViewModel : StaticViewModel
    {
        public ViewRecordsViewModel()
        {
            if (Service.DNVM.SelectedRecord != null)
            {
                RecordsData = new ObservableCollection<Record>(Service.db.Records.Where(x => x.Patient == Service.DNVM.SelectedRecord.Patient));
            }
        }
        private ObservableCollection<Record> _recordsData;
        public ObservableCollection<Record> RecordsData
        {
            get { return _recordsData; }
            set { _recordsData = value; OnPropertyChanged(); }
        }
        private static DateTime _dateStartBlock;
        private static DateTime _dateEndBlock;
        public static DateTime DateStartBlockSelected
        {
            get { return _dateStartBlock; }
            set { _dateStartBlock = value; }
        }
        public static DateTime DateEndBlockSelected
        {
            get { return _dateEndBlock; }
            set { _dateEndBlock = value; }
        }
        private Record _selectedItem;
        public Record SelectedItem
        {
            get { return _selectedItem; }
            set { _selectedItem = value; OnPropertyChanged(); }
        }
        private RelayCommand _findCommand;
        public RelayCommand FindCommand => _findCommand ?? (_findCommand = new RelayCommand(x =>
        {
            if (DateStartBlockSelected != DateTime.Parse("01.01.0001") && DateEndBlockSelected != DateTime.Parse("01.01.0001"))
            {
                var start = DateStartBlockSelected;
                var end = DateEndBlockSelected;
                RecordsData = new ObservableCollection<Record>(Service.db.Records.Where(x => x.Patient == Service.DNVM.SelectedRecord.Patient && x.RecordTime < end && x.RecordTime > start));
            }
        }));
    }
}
