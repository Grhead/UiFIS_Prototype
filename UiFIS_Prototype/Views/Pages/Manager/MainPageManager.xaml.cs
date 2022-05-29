using System.Windows.Controls;
using UiFIS_Prototype.ViewModel;

namespace UiFIS_Prototype.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPageManager.xaml
    /// </summary>
    public partial class MainPageManager : Page
    {
        public MainPageManager()
        {
            InitializeComponent();
            DataContext = new MainManagerViewModel();
        }
    }
}
