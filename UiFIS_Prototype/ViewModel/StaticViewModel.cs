using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace UiFIS_Prototype.ViewModel
{
    public class StaticViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
