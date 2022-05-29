using System;
using System.Windows;
using System.Windows.Controls;
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
            try
            {
                AddRecordViewModel.Dates = DateTime.Parse(DTP.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Incoorect syntax");
            }
            
        }
    }
}
