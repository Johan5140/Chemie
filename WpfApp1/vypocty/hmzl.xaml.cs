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
    /// Interakční logika pro hmzl.xaml
    /// </summary>
    public partial class hmzl : Page
    {
        public hmzl()
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
    
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                decimal.TryParse(tb3.Text, out var v1);
                decimal.TryParse(tb4.Text, out var v2);
                decimal c = v1 / v2;
                mlatky.Content = v1.ToString();
                mroztokulb.Content = v2.ToString();
                string output = string.Format("{0:#,##0.0000}", c);
                decimalnumlab.Content = output;
                decimal d = c * 100;
                string output1 = string.Format("{0:#,##0.00}", d);
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
                decimal a = v3 + v4;
                string b = string.Format("{0:#,##0.00}", a);
                decimal.TryParse(tb1.Text, out var g);
                string v = g.ToString();
                mroztoku.Content = b;
                tb4.Text = b;
                tb3.Text = v;
                Button_Click_1(sender, e);
            }
        }
    }
}
