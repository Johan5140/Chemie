using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Runtime.ConstrainedExecution;

namespace Chemie
{
    /// <summary>
    /// Interakční logika pro settings.xaml
    /// </summary>
    public partial class settings : Page
    {
        public settings()
        {
            InitializeComponent(); headpick.Items.Add("Tmavý");
            headpick.Items.Add("Světlý");
            themepick.Items.Add("Tmavý");
            themepick.Items.Add("Světlý");
            bgenbaled.Items.Add("Ano");
            bgenbaled.Items.Add("Ne");
            lang.Items.Add("Český");
            lang.SelectedItem = "Český";
            /* Odemknutí vývojářského režimu */
            string bg = Properties.Settings.Default.background;
            if (bg == "Ano")
            {
                bgenbaled.SelectedItem = "Ano";
            }
            if (bg == "Ne")
            {
                bgenbaled.SelectedItem = "Ne";
            }
            string hdtext = Properties.Settings.Default.hdtextcolor;
            if (hdtext == "Tmavý")
            {
                headpick.SelectedItem = "Tmavý";
            }
            else
            {
                headpick.SelectedItem = "Světlý";
            }
            string thmpck = Chemie.Properties.Settings.Default.theme;
            string headcl = Properties.Settings.Default.head;
            hexcode.Text = headcl;
            if (thmpck == "Světlý")
            {
                themepick.SelectedItem = "Světlý";
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
                this.Resources["tbbg"] = new SolidColorBrush(Colors.White);
                this.Resources["tbfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["cbbg"] = new SolidColorBrush(Colors.White);
                this.Resources["cbfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["cbihoverfg"] = new SolidColorBrush(Colors.LightGray);
            }
            if (thmpck == "Tmavý")
            {
                themepick.SelectedItem = "Tmavý";
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
            //Colorpick.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Properties.Settings.Default.head));
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.head = "#b9d1ea";
            Properties.Settings.Default.theme = "Světlý";
            Properties.Settings.Default.hdtextcolor = "Tmavý";
            Properties.Settings.Default.background = "Ano";
            Properties.Settings.Default.Save();
            System.Windows.MessageBox.Show("Nastavení vrácena do výchozích hodnot, aplikace se restartuje!");
            System.Windows.Forms.Application.Restart();
            Process.GetCurrentProcess().Kill();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (hexcode.Text == "" || hexcode.Text == null)
            {
                System.Windows.MessageBox.Show("Nebyla vybrána barva!");
            }
            else
            {
                var hdset = headpick.SelectedItem.ToString();
                if (hdset == "Světlý")
                {
                    Properties.Settings.Default.hdtextcolor = "Světlý";
                }
                if (hdset == "Tmavý")
                {
                    Properties.Settings.Default.hdtextcolor = "Tmavý";
                }
                var thmset = themepick.SelectedItem.ToString();
                if (thmset == "Světlý")
                {
                    Properties.Settings.Default.theme = "Světlý";
                }
                if (thmset == "Tmavý")
                {
                    Properties.Settings.Default.theme = "Tmavý";
                }
                var bgset = bgenbaled.SelectedItem.ToString();
                if (bgset == "Ano")
                {
                    Properties.Settings.Default.background = "Ano";
                }
                if (bgset == "Ne")
                {
                    Properties.Settings.Default.background = "Ne";
                }
                Properties.Settings.Default.head = "" + hexcode.Text;
                Properties.Settings.Default.Save();
                System.Windows.MessageBox.Show("Nastavení uložena, aplikace se restartuje! ");
                System.Windows.Forms.Application.Restart();
                Process.GetCurrentProcess().Kill();
            }

            }

        private void hexcodee(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                colorconvert(sender, e);
            }
        }
        private void colorconvert(object sender, RoutedEventArgs e)
        {
            string hex = hexcode.Text;
            string clr = "" + hex;
            preview.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(clr));
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                preview.Fill = new SolidColorBrush(Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B));
                String code = (colorDialog.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                hexcode.Text = "#" + code;

            }
        }
        private void black_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "#000000";
            colorconvert(sender, e);
        }
        private void red_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "#F75454";
            colorconvert(sender, e);
        }
        private void def_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "#B9D1EA";
            colorconvert(sender, e);
        }
        private void blue_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "#365EFF";
            colorconvert(sender, e);
        }
        private void green_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "#59FF38";
            colorconvert(sender, e);
        }
        private void yellow_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "#F1FF00";
            colorconvert(sender, e);
        }
        private void brown_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "#4C3228";
            colorconvert(sender, e);
        }
    }
}
