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

namespace Chemie.vypocty
{
    /// <summary>
    /// Interakční logika pro hustota.xaml
    /// </summary>
    public partial class hustota : Page
    {
        public hustota()
        {
            InitializeComponent();
            string thmpck = Properties.Settings.Default.theme;
            if (thmpck == "Světlý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.Black);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.LightGray);
                this.Resources["comboboxcl"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                this.Resources["comboboxfr"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                this.Resources["arrowcl"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e0e0e0"));
                this.Resources["arrowfl"] = new SolidColorBrush(Colors.Black);
                this.Resources["arrowmo"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#cccccc"));
                this.Resources["borderbg"] = new SolidColorBrush(Colors.Black);
                this.Resources["cbbg"] = new SolidColorBrush(Colors.White);
                this.Resources["cbfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbbg"] = new SolidColorBrush(Colors.White);
                this.Resources["tbfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["cbihoverfg"] = new SolidColorBrush(Colors.LightGray);
            }
            if (thmpck == "Tmavý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);
                this.Resources["comboboxcl"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                this.Resources["comboboxfr"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                this.Resources["arrowcl"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#808080"));
                this.Resources["arrowfl"] = new SolidColorBrush(Colors.White);
                this.Resources["arrowmo"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#a1a1a1"));
                this.Resources["borderbg"] = new SolidColorBrush(Colors.White);
                this.Resources["cbbg"] = new SolidColorBrush(Colors.Black);
                this.Resources["cbfg"] = new SolidColorBrush(Colors.White);
                this.Resources["tbbg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbfg"] = new SolidColorBrush(Colors.White);
                this.Resources["cbihoverfg"] = new SolidColorBrush(Colors.Gray);
            }
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
             if (tb9.Text != "" && tb10.Text != "" && tb11.Text != "")
            {
                MessageBox.Show("Příliš mnoho argumentů - zadejte pouze hodnoty, které znáte");
            }
            if (tb9.Text == "")
            {
                try
                {
                    decimal.TryParse(tb10.Text, out var v10);
                    decimal.TryParse(tb11.Text, out var v11);
                    decimal f = (decimal)v10 / (decimal)v11;
                    string g = String.Format("{0:#,##0.00000}", f);
                    tb9.Text = g;
                    tb9.Foreground = new SolidColorBrush(Colors.Green);
                    vysledekhustota.Visibility = Visibility.Visible;
                    vysledekhustota.Content = "V (látky) = " + g + " cm3";
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Nulou nelze dělit! Zkontrolujte si prosím hodnoty!");
                }
            }
            if (tb11.Text == "")
            {
                try
                {
                    decimal.TryParse(tb9.Text, out var v12);
                    decimal.TryParse(tb10.Text, out var v13);
                    decimal h = (decimal)v13 / (decimal)v12;
                    string ch = String.Format("{0:#,##0.00000}", h);
                    tb11.Text = ch;
                    tb11.Foreground = new SolidColorBrush(Colors.Green);
                    vysledekhustota.Visibility = Visibility.Visible;
                    vysledekhustota.Content = "ρ (látky) = " + ch + " cm3";
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Nulou nelze dělit! Zkontrolujte si prosím hodnoty!");
                }
            }

            if (tb10.Text == "")
            {
                try
                {
                    decimal.TryParse(tb9.Text, out var v14);
                    decimal.TryParse(tb11.Text, out var v15);
                    decimal i = (decimal)v14 * (decimal)v15;
                    string j = String.Format("{0:#,##0.00000}", i);
                    tb10.Text = j;
                    tb10.Foreground = new SolidColorBrush(Colors.Green);
                    vysledekhustota.Visibility = Visibility.Visible;
                    vysledekhustota.Content = "m (látky) = " + j + " g";
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Nulou nelze dělit! Zkontrolujte si prosím hodnoty!");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tb10.Clear();
            tb11.Clear();
            tb9.Clear();
            tb10.Foreground = new SolidColorBrush(Colors.White);
            tb11.Foreground = new SolidColorBrush(Colors.White);
            tb9.Foreground = new SolidColorBrush(Colors.White);
            vysledekhustota.Content = "";
        }
    }
}
