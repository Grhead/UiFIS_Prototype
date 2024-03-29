﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using UiFIS_Prototype.Models.Req;
using UiFIS_Prototype.Views.Pages;

namespace UiFIS_Prototype.ViewModel
{
    public class MainManagerViewModel : StaticViewModel
    {
        public MainManagerViewModel()
        {
            ListOfRecords = new ObservableCollection<Record>(Service.db.Records.Where(x => x.RecordTime >= DateTime.Now));
        }
        private ObservableCollection<Record> _listOfRecords = new ObservableCollection<Record>();
        public ObservableCollection<Record> ListOfRecords
        {
            get { return _listOfRecords; }
            set { _listOfRecords = value; OnPropertyChanged(); }
        }
        private RelayCommand _goToRecord;
        public RelayCommand GoToRecord => _goToRecord ?? (_goToRecord = new RelayCommand(x =>
        {
            Service.frame.Navigate(new AddRecordPage());
        }));
        private RelayCommand _createCommand;
        public RelayCommand CreateCommand => _createCommand ?? (_createCommand = new RelayCommand(x =>
        {
            Service.frame.Navigate(new AddEMC());
        }));
    }
}
