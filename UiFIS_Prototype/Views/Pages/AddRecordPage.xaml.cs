using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UiFIS_Prototype.ViewModel;

namespace UiFIS_Prototype.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddRecordPage.xaml
    /// </summary>
    public partial class AddRecordPage : Page
    {
        public AddRecordPage()
        {
            InitializeComponent();
            DataContext = new AddRecordViewModel();
        }

        private void DTP_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            AddRecordViewModel.Dates = DateTime.Parse(DTP.Text);
        }
    }
}
