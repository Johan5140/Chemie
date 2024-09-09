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
using Chemie.Properties;
using System.Windows.Media.Animation;

namespace Chemie
{
    /// <summary>
    /// Interakční logika pro settings.xaml
    /// </summary>
    public partial class settings : Page
    {
        public settings()
        {
            InitializeComponent();
            
            string langsel = Properties.Settings.Default.applang;
     

            /* Odemknutí výběru jazyka */
            string hdtext = Properties.Settings.Default.hdtextcolor;
            string thmpck = Chemie.Properties.Settings.Default.theme;
            string headcl = Properties.Settings.Default.head;
            langpick.Items.Add("Český");
            langpick.Items.Add("Русский");
            langpick.Items.Add("English");
            hexcode.Text = headcl;
            if (thmpck == "lighttheme")
            {
                themepick.SelectedValue = lighttheme; ;
                /*System.Windows.Application.Current.Resources.MergedDictionaries.Clear();
                System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Chemie;component/data/themes/light.xaml", UriKind.RelativeOrAbsolute)
                });*/
                /*System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Chemie;component/data/themes/app.xaml", UriKind.RelativeOrAbsolute)
                });*/
                /*  this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                  this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.Black);
                  this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.Black);
                  this.Resources["Buttonsback"] = new SolidColorBrush(Colors.White);
                  this.Resources["Buttonshover"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#bfbfbf"));*/

            }
            if (thmpck == "darktheme")
            {
                themepick.SelectedValue = darktheme;
                /*System.Windows.Application.Current.Resources.MergedDictionaries.Clear();
                System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Chemie;component/data/themes/dark.xaml", UriKind.RelativeOrAbsolute)
                });*/
                /*this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555555"));
                    this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                    this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                    this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                    this.Resources["Buttonshover"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));*/

            }
            string lang = Properties.Settings.Default.applang;
            if (lang == "CZ")
            {
                langpick.SelectedItem = "Český";
            }
            if(lang == "EN")
            {
                langpick.SelectedItem = "English";
            }
            if (lang == "RU")
            {
                langpick.SelectedItem = "Русский";
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string sapplang = Chemie.Properties.Settings.Default.applang.ToLower();
            Properties.Settings.Default.theme = "lighttheme";
            themepick.SelectedValue = lighttheme;
            Properties.Settings.Default.Save();
            System.Windows.Application.Current.Resources.MergedDictionaries.Clear();
            System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Chemie;component/data/themes/light.xaml", UriKind.RelativeOrAbsolute)
            });
            System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Chemie;component/data/languages/" + sapplang + ".xaml", UriKind.RelativeOrAbsolute)
            });
            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage((String)System.Windows.Application.Current.Resources["freset"], (String)System.Windows.Application.Current.Resources["info"], "Info");
        }
        private string langfile;
        private string themefile;

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            /*if (hexcode.Text == "" || hexcode.Text == null)
            {
                System.Windows.MessageBox.Show("Nebyla vybrána barva!");
            }
            else
            {*/
            var lngpck = langpick.SelectedItem.ToString();
            if (lngpck == "Český")
            {
                Properties.Settings.Default.applang = "CZ";
                langfile = "cz";
            }
            if (lngpck == "English")
            {
                Properties.Settings.Default.applang = "EN";
                langfile = "en";
            }
            if (lngpck == "Русский")
            {
                Properties.Settings.Default.applang = "RU";
                langfile = "ru";
            }
            ComboBoxItem ComboItem = (ComboBoxItem)themepick.SelectedItem;
            string theme = ComboItem.Name;
            if (theme == "lighttheme")
            {
                themefile = "light";
            }
            if (theme == "darktheme")
            {
                themefile = "dark";
            }
            System.Windows.Application.Current.Resources.MergedDictionaries.Clear();
            System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Chemie;component/data/themes/"+themefile+".xaml", UriKind.RelativeOrAbsolute)
            });
            System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri("/Chemie;component/data/languages/"+langfile+".xaml", UriKind.RelativeOrAbsolute)
            });
            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage((String)System.Windows.Application.Current.Resources["saved"], (String)System.Windows.Application.Current.Resources["info"], "Info");
            Properties.Settings.Default.theme = theme;
            Properties.Settings.Default.Save();
            //System.Windows.Forms.Application.Restart();
            //Process.GetCurrentProcess().Kill();*/

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
            //preview.Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString(clr));
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.ColorDialog colorDialog = new System.Windows.Forms.ColorDialog();
            if (colorDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //preview.Fill = new SolidColorBrush(Color.FromArgb(colorDialog.Color.A, colorDialog.Color.R, colorDialog.Color.G, colorDialog.Color.B));
                String code = (colorDialog.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                hexcode.Text = "#" + code;

            }
        }
        private void ThemeButton_click(object sender, RoutedEventArgs e)
        {
            /*if (themeswitch.IsChecked == true)
            {
                themeswitch.Content = "Tmavý";
                Properties.Settings.Default.theme = "Tmavý";
                Properties.Settings.Default.Save();
                System.Windows.Application.Current.Resources.MergedDictionaries.Clear();
                System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Chemie;component/data/themes/dark.xaml", UriKind.RelativeOrAbsolute)
                });
                MainWindow win = (MainWindow)MainWindow.GetWindow(this);
                win.Showmessage("Úspěšně nastaven tmavý režim", "Info");
            }
            else
            {
                themeswitch.Content = "Světlý";
                Properties.Settings.Default.theme = "Světlý";
                Properties.Settings.Default.Save();
                System.Windows.Application.Current.Resources.MergedDictionaries.Clear();
                System.Windows.Application.Current.Resources.MergedDictionaries.Add(new ResourceDictionary()
                {
                    Source = new Uri("/Chemie;component/data/themes/light.xaml", UriKind.RelativeOrAbsolute)
                });
                MainWindow win = (MainWindow)MainWindow.GetWindow(this);
                win.Showmessage("Úspěšně nastaven světlý režim", "Info");
            }*/
        }
        private void black_clck(object sender, RoutedEventArgs e)
        {
            hexcode.Text = "#000000";
            colorconvert(sender, e);
        }
        private void ok_clck(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.Application.Restart();
            Process.GetCurrentProcess().Kill();
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
