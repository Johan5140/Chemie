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
    /// Interakční logika pro objzl.xaml
    /// </summary>
    public partial class objzl : Page
    {
        public objzl()
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
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (tb5.Text == "" || tb6.Text == "")
            {
                MessageBox.Show("Zadejte prosím hodnoty");
            }
            if (tb5.Text != "" && tb6.Text != "")
            {
                decimal.TryParse(tb5.Text, out var v5);
                decimal.TryParse(tb6.Text, out var v6);
                decimal a = (decimal)v5 + (decimal)v6;
                string b = String.Format("{0:#,##0.00}", a);
                decimal.TryParse(tb5.Text, out var g);
                string v = g.ToString();
                vroztoku.Content = b;
                tb8.Text = b;
                tb7.Text = v;
                Button_Click_4(sender, e);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (tb7.Text != null && tb8.Text != null)
            {
                try
                {
                    decimal.TryParse(tb7.Text, out var v7);
                    decimal.TryParse(tb8.Text, out var v8);
                    decimal c = (decimal)v7 / (decimal)v8;
                    vlatky.Content = v7.ToString();
                    vroztokulb.Content = v8.ToString();
                    string output = String.Format("{0:#,##0.0000}", c);
                    decimalnumlab1.Content = output;
                    decimal d = c * 100;
                    string output1 = String.Format("{0:#,##0.00}", d);
                    percentnumlab1.Content = output1 + "%";
                }
                catch (DivideByZeroException)
                {
                    MessageBox.Show("Nulou nelze dělit! Zkontrolujte si prosím hodnoty!");
                }
            }
        }
    }
}
