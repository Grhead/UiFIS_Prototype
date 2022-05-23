using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
