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

namespace View
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

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            var strfahr = textBox.Text;
            var fahr = double.Parse(strfahr);
            var cel = (fahr - 32) / 1.8;
            var strcel = cel.ToString();
            textBox.Text = strcel;

            /*var fahrenheitString = textBox.Text;
            var fahrenheit = double.Parse(fahrenheitString);
            var celsius = (fahrenheit - 32) / 1.8;
            var celsiusString = celsius.ToString();
            textBox.Text = celsiusString;*/
        }
    }
}