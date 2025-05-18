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

namespace Chemie.transfer_pages
{
    /// <summary>
    /// Interaction logic for weight.xaml
    /// </summary>
    public partial class weight : Page
    {
        internal string SourceU;
        internal string TargetU;
        public weight()
        {
            InitializeComponent();
            SourceUnit.SelectedValue = g;
            TargetUnit.SelectedValue = _g;
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
                case "g":
                    return 0.001;
                case "mg":
                    return 0.000001;
                case "dag":
                    return 0.01;
                case "kg":
                    return 1.0;
                case "t":
                    return 1000.0;
                case "q":
                    return 100.0;
                case "cent":
                    return 61.7244;
                case "lb":
                    return 0.453592;
                default: throw new NotImplementedException();
            }
        }
        private static double A_FromMeters(string unit)
        {
            switch (unit)
            {
                case "g":
                    return 1000.0;
                case "mg":
                    return 1000000.0;
                case "dag":
                    return 100.0;
                case "kg":
                    return 1.0;
                case "t":
                    return 0.001;
                case "q":
                    return 0.01;
                case "cent":
                    return 0.016201;
                case "lb":
                    return 2.2046244;
                default: throw new NotImplementedException();
            }
        }
    }
}
