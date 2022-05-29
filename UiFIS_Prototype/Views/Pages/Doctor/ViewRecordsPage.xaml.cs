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

namespace UiFIS_Prototype.Views.Pages.Doctor
{
    public partial class ViewRecordsPage : Page
    {
        public ViewRecordsPage()
        {
            InitializeComponent();
            DataContext = new ViewRecordsViewModel();
        }

        private void DTP_ValueChangedS(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                ViewRecordsViewModel.DateStartBlockSelected = DateTime.Parse(DTP1.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Incoorect syntax");
            }
        }

        private void DTP_ValueChangedE(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            try
            {
                ViewRecordsViewModel.DateEndBlockSelected = DateTime.Parse(DTP2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Incoorect syntax");
            }
        }
    }
}
