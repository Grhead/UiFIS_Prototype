using System.Windows;
using UiFIS_Prototype.Models.Req;
using UiFIS_Prototype.ViewModel;

namespace UiFIS_Prototype.Views
{
    /// <summary>
    /// Логика взаимодействия для MainManagerWindow.xaml
    /// </summary>
    public partial class MainManagerWindow : Window
    {
        public MainManagerWindow()
        {
            InitializeComponent();
            Service.frame = MainFrame;
            DataContext = new MainManagerViewModel();
        }
    }
}
