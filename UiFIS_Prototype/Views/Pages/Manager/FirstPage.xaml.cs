using System.Windows.Controls;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для FirstPage.xaml
    /// </summary>
    public partial class FirstPage : Page
    {
        public FirstPage()
        {
            InitializeComponent();
            DataContext = Service.CEMC;
        }
    }
}
