using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Chemie.transfer_pages
{
    /// <summary>
    /// Interaction logic for lenght.xaml
    /// </summary>
    public partial class lenght : Page
    {
        internal string SourceU;
        internal string TargetU;
        public lenght()
        {
            InitializeComponent();
            SourceUnit.SelectedValue = m;
            TargetUnit.SelectedValue = _m;


        }
        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Here e.Text is string so we need to convert it into char
            char ch = e.Text[0];

            if ((Char.IsDigit(ch) || ch == ','))
            {
                //Here TextBox1.Text is name of your TextBox
                if (ch == ',' && SourceValue.Text.Contains(',')) 
                {
                    e.Handled = true;
                }
            }
            else 
            {
                e.Handled = true;
            
            }
    }
        private void TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                ConvertBtn_Click(sender, e);
            }
        }
        private void ConvertBtn_Click(object sender, RoutedEventArgs e)
        {
            if (SourceValue.Text == "" || SourceValue.Text == ",")
            {
                MainWindow win = (MainWindow)MainWindow.GetWindow(this);
                win.Showmessage((String)System.Windows.Application.Current.Resources["invalid_input"], (String)System.Windows.Application.Current.Resources["error"], "Chyba");
            }
            else
            {
                ComboBoxItem SU = (ComboBoxItem)SourceUnit.SelectedItem;
                string SourceUx = SU.Name.ToString();
                SourceU = SourceUx;
                ComboBoxItem TU = (ComboBoxItem)TargetUnit.SelectedItem;
                string TargetUx = TU.Name;
                TargetU = TargetUx.Replace("_", "");
                if (SourceU != TargetU)
                {
                    double value = double.Parse(SourceValue.Text);
                    string result = ConvertLenght(value, SourceU, TargetU).ToString();
                    TargetValue.Text = result;
                }
                else
                {
                    TargetValue.Text = "1";
                }
            }
        }
          public static double ConvertLenght(double value, string SourceU, string TargetU)
          {
              //konverze do metrů
              double valueInMeters = value * A_ToMeters(SourceU);
              //Z metrů do požadované valičiny
              return valueInMeters * A_FromMeters(TargetU);
          }
          private static double A_ToMeters(string unit)
          {
              switch (unit)
              {
                  case "pm":
                      return 0.000000000001;
                  case "nm":
                      return 0.000000001;
                  case "mcm":
                      return 0.000001;
                  case "mm":
                      return 0.001;
                  case "cm":
                      return 0.01;
                  case "dm":
                      return 0.1;
                  case "m":
                      return 1.0;
                  case "dcm":
                      return 10.0;
                  case "hm":
                      return 100.0;
                  case "km":
                      return 1000.0;
                  case "ft":
                    return 0.3048;
                  case "mi":
                    return 1609.34;
                case "in":
                    return 0.0254;
                case "yd":
                    return 0.9144;
                default: throw new NotImplementedException();
              }
          }
              private static double A_FromMeters(string unit)
              {
                  switch (unit)
                  {
                      case "pm":
                          return 1000000000000.0;
                      case "nm":
                          return 1000000000.0;
                      case "mcm":
                          return 1000000.0;
                      case "mm":
                          return 1000.0;
                      case "cm":
                          return 100.0;
                      case "dm":
                          return 10.0;
                      case "m":
                          return 1.0;
                      case "dcm":
                          return 0.1;
                      case "hm":
                          return 0.01;
                      case "km":
                          return 0.001;
                case "ft":
                    return 3.2808399;
                case "mi":
                    return 0.000621371192;
                case "in":
                    return 39.3700787;
                case "yd":
                    return 1.0936133;
                default: throw new NotImplementedException();
            }
              }
    }
}
