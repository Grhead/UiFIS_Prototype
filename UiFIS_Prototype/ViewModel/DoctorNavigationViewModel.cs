using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using UiFIS_Prototype.Models.Req;
using UiFIS_Prototype.Views.Pages.Doctor;

namespace UiFIS_Prototype.ViewModel
{
    public class DoctorNavigationViewModel : StaticViewModel
    {
        public DoctorNavigationViewModel()
        {
            ListOfRecords = new ObservableCollection<Record>(Service.db.Records.Where(x => x.Doctor == Service.ClientSession.Id && x.RecordTime >= DateTime.Now).Include(x => x.PatientNavigation));
            ListOfRecordsOld = new ObservableCollection<Record>(Service.db.Records.Where(x => x.Doctor == Service.ClientSession.Id && x.RecordTime < DateTime.Now).Include(x => x.PatientNavigation));
        }
        private ObservableCollection<Record> _listOfRecords;
        public ObservableCollection<Record> ListOfRecords
        {
            get { return _listOfRecords; }
            set { _listOfRecords = value; OnPropertyChanged(); }
        }
        private ObservableCollection<Record> _listOfRecordsOld;
        public ObservableCollection<Record> ListOfRecordsOld
        {
            get { return _listOfRecordsOld; }
            set { _listOfRecordsOld = value; OnPropertyChanged(); }
        }
        private Record _selectedRecord;
        public Record SelectedRecord
        {
            get
            {
                return _selectedRecord;
            }
            set
            {
                _selectedRecord = value; OnPropertyChanged();
            }
        }
        private int a = 0;
        private RelayCommand _menuCommand;
        public RelayCommand MenuCommand => _menuCommand ?? (_menuCommand = new RelayCommand(x =>
        {
            if (a == 0)
            {
                ListOfRecordsOld = new ObservableCollection<Record>(Service.db.Records.Where(x => x.Doctor == Service.ClientSession.Id && x.RecordTime < DateTime.Now).Include(x => x.PatientNavigation));
                ListOfRecords = new ObservableCollection<Record>(Service.db.Records.Where(x => x.Doctor == Service.ClientSession.Id).Include(x => x.PatientNavigation));
                Service.frame.Navigate(new MenuPage());
                a = 1;
            }
            else
            {
                Service.frame.Navigate(new DoctorMainPage());
                a = 0;
            }
        }));
        private RelayCommand _infoCommand;
        public RelayCommand InfoCommand => _infoCommand ?? (_infoCommand = new RelayCommand(x =>
        {
            Service.frame.Navigate(new DoctorMainPage());
        }));
        private RelayCommand _recordCommand;
        public RelayCommand RecordCommand => _recordCommand ?? (_recordCommand = new RelayCommand(x =>
        {
            Service.frame.Navigate(new ViewRecordsPage());
        }));
        private RelayCommand _retryCommand;
        public RelayCommand RetryCommand => _retryCommand ?? (_retryCommand = new RelayCommand(x =>
        {
            Service.frame.Navigate(new RetryRecords());
        }));
        private RelayCommand _reportCommand;
        public RelayCommand ReportCommand => _reportCommand ?? (_reportCommand = new RelayCommand(x =>
        {
            ReportViewModel.CreateA();
        }));
    }
}
