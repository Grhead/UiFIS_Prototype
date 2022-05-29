using System.Windows.Controls;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddEMC.xaml
    /// </summary>
    public partial class AddEMC : Page
    {
        public AddEMC()
        {
            InitializeComponent();
            Service.frame = CreateEMC;
            Service.frame.Navigate(new FirstPage());
        }

    }
}
