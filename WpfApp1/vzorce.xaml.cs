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

namespace Chemie
{
    /// <summary>
    /// Interakční logika pro vzorce.xaml
    /// </summary>
    public partial class vzorce : Page
    {
        public vzorce()
        {
            InitializeComponent();
            fncpick.Items.Add("Hmotnostní zlomek");
            fncpick.Items.Add("Objemový zlomek");
            /*  fncpick.Items.Add("Látkové množství");
             fncpick.Items.Add("Molární koncentrace");
             fncpick.Items.Add("Ředění roztoků");
             fncpick.Items.Add("Chemické rovnice"); */
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
        private void choose_grid(object sender, RoutedEventArgs e)
        {
            if (fncpick.SelectedItem == null)
            {
                MessageBox.Show("Vyberte prosím jednu z možností");
            }
            else
            {
                var vybran = fncpick.SelectedItem.ToString();
                if (vybran == "Hmotnostní zlomek")
                {
                    hmzlomek.Visibility = Visibility.Visible;
                    objzlmk.Visibility = Visibility.Hidden;
                    molárníkoncgrid.Visibility = Visibility.Hidden;
                    fnctitle.Content = "Výpočet hmotnostního zlomku";
                }
                if (vybran == "Objemový zlomek")
                {
                    hmzlomek.Visibility = Visibility.Hidden;
                    objzlmk.Visibility = Visibility.Visible;
                    molárníkoncgrid.Visibility = Visibility.Hidden;
                    fnctitle.Content = "Výpočet objemového zlomku";
                }
                if (vybran == "Molární koncentrace")
                {
                    hmzlomek.Visibility = Visibility.Hidden;
                    objzlmk.Visibility = Visibility.Hidden;
                    molárníkoncgrid.Visibility = Visibility.Visible;
                    fnctitle.Content = "Výpočet molární koncentrace";
                }

                if (vybran == "Látkové množství")
                {
                    hmzlomek.Visibility = Visibility.Hidden;
                    objzlmk.Visibility = Visibility.Hidden;
                    molárníkoncgrid.Visibility = Visibility.Hidden;
                    latkovemngrid.Visibility = Visibility.Visible;
                    fnctitle.Content = "Výpočet látkového množství";
                }
                if (vybran == "Ředění roztoků")
                {
                    hmzlomek.Visibility = Visibility.Hidden;
                    objzlmk.Visibility = Visibility.Hidden;
                    molárníkoncgrid.Visibility = Visibility.Hidden;
                    fnctitle.Content = "Výpočet ředění roztoků";
                }
                if (vybran == "Chemické rovnice")
                {
                    hmzlomek.Visibility = Visibility.Hidden;
                    objzlmk.Visibility = Visibility.Hidden;
                    molárníkoncgrid.Visibility = Visibility.Hidden;
                    fnctitle.Content = "Chemické rovnice";
                }
                else
                {

                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                decimal.TryParse(tb3.Text, out var v1);
                decimal.TryParse(tb4.Text, out var v2);
                decimal c = (decimal)v1 / (decimal)v2;
                mlatky.Content = v1.ToString();
                mroztokulb.Content = v2.ToString();
                string output = String.Format("{0:#,##0.0000}", c);
                decimalnumlab.Content = output;
                decimal d = c * 100;
                string output1 = String.Format("{0:#,##0.00}", d);
                percentnumlab.Content = output1 + "%";
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Nulou nelze dělit! Zkontrolujte si prosím hodnoty!");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (tb1.Text == "" && tb2.Text == "")
            {
                MessageBox.Show("Zadejte prosím hodnoty!");
            }
            if (tb1.Text != "" && tb2.Text != "")
            {
                decimal.TryParse(tb1.Text, out var v3);
                decimal.TryParse(tb2.Text, out var v4);
                decimal a = (decimal)v3 + (decimal)v4;
                string b = String.Format("{0:#,##0.00}", a);
                decimal.TryParse(tb1.Text, out var g);
                string v = g.ToString();
                mroztoku.Content = b;
                tb4.Text = b;
                tb3.Text = v;
                Button_Click_1(sender, e);
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

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
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
    }
}
