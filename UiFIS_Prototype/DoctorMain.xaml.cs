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
using System.Windows.Shapes;

namespace UiFIS_Prototype
{
    /// <summary>
    /// Логика взаимодействия для DoctorMain.xaml
    /// </summary>
    public partial class DoctorMain : Window
    {
        public DoctorMain()
        {
            InitializeComponent();
        }

        private void GeneralButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("DoctorMainPage.xaml", UriKind.Relative));
        }

        private void ResearchButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("DoctorResearch.xaml", UriKind.Relative));
        }

        private void DiagnosisButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("DoctorDiagnosis.xaml", UriKind.Relative));
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uri("DoctorPrint.xaml", UriKind.Relative));
        }
    }
}
