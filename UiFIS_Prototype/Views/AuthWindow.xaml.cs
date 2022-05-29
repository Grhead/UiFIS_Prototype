using System;
using System.Windows;
using System.Windows.Threading;
using UiFIS_Prototype.ViewModel;

namespace UiFIS_Prototype.Views
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public AuthWindow()
        {
            InitializeComponent();
            var timer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(1)
            };
            timer.Tick += TimerTick;
            timer.Start();

            void TimerTick(object sender, EventArgs e)
            {
                timerNow.Text = DateTime.Now.ToLongTimeString();
            }
            DataContext = new AuthViewModel();
        }
    }
}
