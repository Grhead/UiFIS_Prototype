using System.Windows;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.Views
{
    /// <summary>
    /// Логика взаимодействия для MainDoctorWindow.xaml
    /// </summary>
    public partial class MainDoctorWindow : Window
    {
        public MainDoctorWindow()
        {
            InitializeComponent();
            Service.frame = DoctorMainFrame;
            DataContext = Service.DNVM;
        }
    }
}
