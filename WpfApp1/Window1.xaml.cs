using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chemie
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
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
        private void hexcodee (object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
               colorconvert(sender, e);
            }
        }
        private void colorconvert (object sender, RoutedEventArgs e)
        {
            string hex = hexcode.Text;
            string clr = "#" + hex;
            preview.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(clr));
            int RGBint = Convert.ToInt32(hex, 16);
            byte Red = (byte)((RGBint >> 16) & 255);
            byte Green = (byte)((RGBint >> 8) & 255);
            byte Blue = (byte)(RGBint & 255);

            redcode.Text = Red.ToString();
            greencode.Text = Green.ToString();
            bluecode.Text = Blue.ToString();
        }
        private void redcodee (object sender, KeyEventArgs es)
        {
            if (es.Key == Key.Return)
            {
                
            }
        }
        private void black_clck (object sender, RoutedEventArgs e)
        {
            hexcode.Text = "000000";
            colorconvert(sender, e);
        }
        private void red_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "F75454";
            colorconvert(sender, e);
        }
        private void def_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "B9D1EA";
            colorconvert(sender, e);
        }
        private void blue_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "365EFF";
            colorconvert(sender, e);
        }
        private void green_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "59FF38";
            colorconvert(sender, e);
        }
        private void yellow_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "F1FF00";
            colorconvert(sender, e);
        }
        private void brown_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "4C3228";
            colorconvert(sender, e);
        }
        private void save_clck(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.head = "#"+hexcode.Text;
            Properties.Settings.Default.Save();
            MessageBox.Show("Barva vybrána, uložení je nutné potvrdit v okně nastavení");
            this.Close();

        }
    }
}
