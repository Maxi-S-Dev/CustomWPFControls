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

namespace CustomControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void LightTheme(object sender, RoutedEventArgs e)
        {
            
        }

        private void DarkTheme(object sender, RoutedEventArgs e)
        {

        }


        private void ChangeTheme(Uri themeUri)
        {
            ResourceDictionary Theme = new ResourceDictionary() {Source = themeUri };

            App.Current.Resources.Clear();
            App.Current.Resources.MergedDictionaries.Add(Theme);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
