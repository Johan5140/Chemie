using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using Chemie;
using WpfApp1;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace Chemie
{
    /// <summary>
    /// Interaction logic for nastaveni.xaml
    /// </summary>
    public partial class Nastaveni : System.Windows.Window
    {
        public Nastaveni()
        {
            InitializeComponent();
            headpick.Items.Add("Tmavý");
            headpick.Items.Add("Světlý");
            themepick.Items.Add("Tmavý");
            themepick.Items.Add("Světlý");
            bgenbaled.Items.Add("Ano");
            bgenbaled.Items.Add("Ne");
            string bg = Properties.Settings.Default.background;
            if (bg == "Ano") {
                bgenbaled.SelectedItem = "Ano";
            }
            if (bg == "Ne")
            {
                bgenbaled.SelectedItem = "Ne";
            }
            string hdtext = Properties.Settings.Default.hdtextcolor;
            if (hdtext == "Tmavý")
            {
                Headline.Foreground = new SolidColorBrush((Color)Colors.Black);
                headpick.SelectedItem = "Tmavý";
            }
            else {
                Headline.Foreground = new SolidColorBrush((Color)Colors.White);
                headpick.SelectedItem = "Světlý";
            }
            string thmpck = Chemie.Properties.Settings.Default.theme;
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
                this.Resources["cbbg"] = new SolidColorBrush(Colors.White);
                this.Resources["cbfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["cbihoverfg"] = new SolidColorBrush(Colors.LightGray);
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
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
                this.Resources["cbihoverfg"] = new SolidColorBrush(Colors.Gray); 
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555555"));
            }
            Headline.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Properties.Settings.Default.head));
            Colorpick.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Properties.Settings.Default.head));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
            Properties.Settings.Default.Save();
            System.Windows.MessageBox.Show("Nastavení uložena, aplikace se restartuje! ");
            System.Windows.Forms.Application.Restart();
            Process.GetCurrentProcess().Kill();
        }

        private void Colorpick_Click(object sender, RoutedEventArgs e)
        {
            Window1 clpick = new Window1();
            clpick.Show();
            
        }
    }
}
