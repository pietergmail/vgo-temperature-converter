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

        private void ConvertCelsius(object sender, RoutedEventArgs e)
        {
            CelsiusToFahrenheit(sender, e);
            CelsiusToKelvin(sender, e);
        }

        protected void ConvertFahrenheit(object sender, RoutedEventArgs e)
        {
            FahrenheitToCelsius(sender, e);
            CelsiusToKelvin(sender, e);
        }

        protected void ConvertKelvin(object sender, RoutedEventArgs e)
        {
            KelvinToCelsius(sender, e);
            CelsiusToFahrenheit(sender, e);
        }



        private void FahrenheitToCelsius(object sender, RoutedEventArgs e)
        {
            var strfahr = FahrenheitText.Text;
            var fahr = double.Parse(strfahr);
            var cel = (fahr - 32) / 1.8;
            var strcel = cel.ToString();
            CelsiusText.Text = strcel;
        }

        private void CelsiusToFahrenheit(object sender, RoutedEventArgs e)
        {
            var strcel = CelsiusText.Text;
            var cel = double.Parse(strcel);
            var fahr = (cel * 1.8) + 32;
            var strfahr = fahr.ToString();
            FahrenheitText.Text = strfahr;
        }

        private void CelsiusToKelvin(object sender, RoutedEventArgs e) 
        {
            var strcel = CelsiusText.Text;
            var cel = double.Parse(strcel);
            var Kel = cel + 273.15;
            var strKel = Kel.ToString();
            KelvinText.Text = strKel;
        }

        private void KelvinToCelsius(object sender, RoutedEventArgs e)
        {
            var strkel = KelvinText.Text;
            var kel = double.Parse(strkel);
            var cel = kel - 273.15;
            var strcel = cel.ToString();
            CelsiusText.Text = strcel;
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var kelvin = slider.Value;
            var celsius = kelvin - 273.15;
            var fahrenheit = celsius * 1.8 + 32;

            var kelvinString = kelvin.ToString();
            var fahrenheitString = fahrenheit.ToString();
            var celsiusString = celsius.ToString();

            kelvinTextBox.Text = kelvinString;
            fahrenheitTextBox.Text = fahrenheitString;
            celsiusTextBox.Text = celsiusString;
        }
    }
}