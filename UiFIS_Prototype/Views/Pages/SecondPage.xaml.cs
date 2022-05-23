﻿using System;
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
    /// Логика взаимодействия для SecondPage.xaml
    /// </summary>
    public partial class SecondPage : Page
    {
        public SecondPage()
        {
            InitializeComponent();
            DataContext = new CreateEMC();
            AdressGet.Text = "Адрес";
            AdressGet.Opacity = 0.5;
        }
        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            AdressGet.Text = "Адрес";
            AdressGet.Opacity = 0.5;
        }
    }
}