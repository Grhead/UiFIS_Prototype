using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.ViewModel
{
    public class SearchBoxViewModel : StaticViewModel
    {
        public SearchBoxViewModel()
        {

        }
        private RelayCommand _searchCommand;
        public RelayCommand SearchCommand => _searchCommand ?? (_searchCommand = new RelayCommand(x =>
        {

        }));
        private string _searchText;
        public string SearchText
        {
            get
            {
                return _searchText;
            }
            set
            {
                _searchText = value;
                OnPropertyChanged();
            }
        }
    }
}
