using System.Windows.Controls;
using UiFIS_Prototype.ViewModel;

namespace UiFIS_Prototype.Views.Pages.Doctor
{
    /// <summary>
    /// Логика взаимодействия для DoctorMainPage.xaml
    /// </summary>
    public partial class DoctorMainPage : Page
    {
        public DoctorMainPage()
        {
            InitializeComponent();
            DataContext = new ProfileAndMoreViewModel();
        }
    }
}
