using System;
using System.Collections.ObjectModel;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype
{
    public class ViewModelRegistre : ViewModel.StaticViewModel
    {
        public ViewModelRegistre()
        {
            ListOfGenders = new ObservableCollection<Gender>(Service.db.Genders);
        }
        private ObservableCollection<Gender> _listOfGenders = new ObservableCollection<Gender>();
        public ObservableCollection<Gender> ListOfGenders
        {
            get { return _listOfGenders; }
            set { _listOfGenders = value; OnPropertyChanged(); }
        }
        
    }
}
