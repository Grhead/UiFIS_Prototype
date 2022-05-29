using System.Windows.Controls;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.Views.Pages.Doctor
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
            //DataContext = new DoctorNavigationViewModel();
            DataContext = Service.DNVM;
        }
    }
}
