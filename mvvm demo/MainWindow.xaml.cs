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
using mvvm_demo.Viewmodels;

namespace mvvm_demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       // MainWindowViewmodel vm = new MainWindowViewmodel();

        public MainWindow()
        {
            InitializeComponent();

            // button event
           // btnKlikMij.Click += BtnKlikMij_Click;
           // DataContext = vm;
            
        }

       /* private void BtnKlikMij_Click(object sender, RoutedEventArgs e)
        {
            vm.FirstName = "Test ABC";
            vm.LastName = "Test XYZ";

        }*/
    }
}
