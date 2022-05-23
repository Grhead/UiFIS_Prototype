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
using System.Windows.Shapes;
using UiFIS_Prototype.Models.Req;
using UiFIS_Prototype.ViewModel;

namespace UiFIS_Prototype.Views
{
    /// <summary>
    /// Логика взаимодействия для MainManagerWindow.xaml
    /// </summary>
    public partial class MainManagerWindow : Window
    {
        public MainManagerWindow()
        {
            InitializeComponent();
            Service.frame = MainFrame;
            DataContext = new MainManagerViewModel();
        }
    }
}
