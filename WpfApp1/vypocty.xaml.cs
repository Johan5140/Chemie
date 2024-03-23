using System;
using System.Windows;
using System.Windows.Media.Imaging;
using System.Windows.Media;

namespace Chemie
{
    /// <summary>
    /// Interaction logic for vypocty.xaml
    /// </summary>
    public partial class vypocty : Window
    {
        public vypocty()
        {
            InitializeComponent();
            fncpick.Items.Add("Hmotnostní zlomek");
            fncpick.Items.Add("Objemový zlomek");
            fncpick.Items.Add("Molární hmornost");
            string hdtext = Properties.Settings.Default.hdtextcolor;
            if (hdtext == "Tmavý")
            {
                Headline.Foreground = new SolidColorBrush((Color)Colors.Black);
            }
            else
            {
                Headline.Foreground = new SolidColorBrush((Color)Colors.White);
            }
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
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
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
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555555"));
            }
            Headline.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Properties.Settings.Default.head));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
                    fnctitle.Content = "Jednoduchý výpočet hmotnostního zlomku";
                }
                else {
                    MessageBox.Show("CHYBA!");
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
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
}
