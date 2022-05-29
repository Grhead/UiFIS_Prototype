using System;
using System.Windows.Controls;
using System.Windows.Input;
using UiFIS_Prototype.Models.Req;

namespace UiFIS_Prototype.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
            DataContext = Service.CEMC;
        }
        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    Service.frame.Navigate(new FirstPage());
        //}
    }
}
