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
using System.Windows.Shapes;
using WpfApp1;

namespace Chemie
{
    /// <summary>
    /// Interakční logika pro Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
            string hdtext = Chemie.Properties.Settings.Default.hdtextcolor;
            if (hdtext == "Tmavý")
            {
                Headline.Foreground = new SolidColorBrush((Color)Colors.Black);

            }
            else
            {
                Headline.Foreground = new SolidColorBrush((Color)Colors.White);
            }
            string thmpck = Chemie.Properties.Settings.Default.theme;
            string bgenabled = Chemie.Properties.Settings.Default.background;
            if (thmpck == "Světlý")
            {
                if (bgenabled == "Ano")
                {
                    this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/Chemie;component/data/bglight.png")));
                }
                if (bgenabled == "Ne")
                {
                    this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                }
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.Black);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonshover"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#bfbfbf"));
                home.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#dedcdc"));
                this.menu.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#f5f5f5"));
                /* Popisky tlačítek - Světlý */
                this.home.Foreground = new SolidColorBrush(Colors.Black);
                this.set.Foreground = new SolidColorBrush(Colors.Black);
                this.about.Foreground = new SolidColorBrush(Colors.Black);
                this.teorie.Foreground = new SolidColorBrush(Colors.Black);
                this.prevody.Foreground = new SolidColorBrush(Colors.Black);
                this.vypocty.Foreground = new SolidColorBrush(Colors.Black);
                /* Světlý - Světlý */
                this.homeimg.Source = new BitmapImage(new Uri(@"/data/home-light.png", UriKind.Relative));
                this.setimg.Source = new BitmapImage(new Uri(@"/data/settings-light.png", UriKind.Relative));
                this.aboutimg.Source = new BitmapImage(new Uri(@"/data/about-light.png", UriKind.Relative));
                this.teorieimg.Source = new BitmapImage(new Uri(@"/data/bgdark.png", UriKind.Relative));
                this.prevodyimg.Source = new BitmapImage(new Uri(@"/data/prevody-light.png", UriKind.Relative));
                this.vypoctyimg.Source = new BitmapImage(new Uri(@"/data/vypocty-light.png", UriKind.Relative));

                /* Popisky tlačítek - Světlý */

            }
            if (thmpck == "Tmavý")
            {
                if (bgenabled == "Ano")
                {
                    this.Background = new ImageBrush(new BitmapImage(new Uri(@"pack://application:,,,/Chemie;component/data/bgdark.png")));
                }
                if (bgenabled == "Ne")
                {
                    this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555555"));
                }
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonshover"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#333333"));
                home.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4d4c4c"));
                this.menu.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#212121"));
                /* Popisky tlačítek - Tmavý */
                this.home.Foreground = new SolidColorBrush(Colors.White);
                this.set.Foreground = new SolidColorBrush(Colors.White);
                this.about.Foreground = new SolidColorBrush(Colors.White);
                this.teorie.Foreground = new SolidColorBrush(Colors.White);
                this.prevody.Foreground = new SolidColorBrush(Colors.White);
                this.vypocty.Foreground = new SolidColorBrush(Colors.White);
                /* Ikony - Tmavý */
                this.homeimg.Source = new BitmapImage(new Uri(@"/data/home-dark.png", UriKind.Relative));
                this.setimg.Source = new BitmapImage(new Uri(@"/data/settings-dark.png", UriKind.Relative));
                this.aboutimg.Source = new BitmapImage(new Uri(@"/data/about-dark.png", UriKind.Relative));
                this.teorieimg.Source = new BitmapImage(new Uri(@"/data/bglight.png", UriKind.Relative));
                this.prevodyimg.Source = new BitmapImage(new Uri(@"/data/prevody-dark.png", UriKind.Relative));
                this.vypoctyimg.Source = new BitmapImage(new Uri(@"/data/vypocty-dark.png", UriKind.Relative));
                /* Popisky tlačítek - Světlý */

            }

            Headline.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Properties.Settings.Default.head));

        }
        public string theme = Properties.Settings.Default.theme;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("main.xaml", UriKind.Relative);
            vypocty.Background = new SolidColorBrush(Colors.Transparent);
            prevody.Background = new SolidColorBrush(Colors.Transparent);
            teorie.Background = new SolidColorBrush(Colors.Transparent);
            set.Background = new SolidColorBrush(Colors.Transparent);
            about.Background = new SolidColorBrush(Colors.Transparent);
            if (theme == "Světlý")
            {
                home.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#dedcdc"));
            }
            if (theme == "Tmavý")
            {
                home.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4d4c4c"));
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("info.xaml", UriKind.Relative);
            home.Background = new SolidColorBrush(Colors.Transparent);
            vypocty.Background = new SolidColorBrush(Colors.Transparent);
            prevody.Background = new SolidColorBrush(Colors.Transparent);
            teorie.Background = new SolidColorBrush(Colors.Transparent);
            set.Background = new SolidColorBrush(Colors.Transparent);
            if (theme == "Světlý")
            {
                about.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#dedcdc"));
            }
            if (theme == "Tmavý")
            {
                about.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4d4c4c"));
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("settings.xaml", UriKind.Relative);
            home.Background = new SolidColorBrush(Colors.Transparent);
            vypocty.Background = new SolidColorBrush(Colors.Transparent);
            prevody.Background = new SolidColorBrush(Colors.Transparent);
            teorie.Background = new SolidColorBrush(Colors.Transparent);
            about.Background = new SolidColorBrush(Colors.Transparent);
            if (theme == "Světlý")
            {
                set.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#dedcdc"));
            }
            if (theme == "Tmavý")
            {
                set.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4d4c4c"));
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("vzorce.xaml", UriKind.Relative);
            home.Background = new SolidColorBrush(Colors.Transparent);
            prevody.Background = new SolidColorBrush(Colors.Transparent);
            teorie.Background = new SolidColorBrush(Colors.Transparent);
            set.Background = new SolidColorBrush(Colors.Transparent);
            about.Background = new SolidColorBrush(Colors.Transparent);
            if (theme == "Světlý")
            {
                vypocty.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#dedcdc"));
            }
            if (theme == "Tmavý")
            {
                vypocty.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4d4c4c"));
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("prevody.xaml", UriKind.Relative);
            home.Background = new SolidColorBrush(Colors.Transparent);
            vypocty.Background = new SolidColorBrush(Colors.Transparent);
            teorie.Background = new SolidColorBrush(Colors.Transparent);
            set.Background = new SolidColorBrush(Colors.Transparent);
            about.Background = new SolidColorBrush(Colors.Transparent);
            if (theme == "Světlý")
            {
                prevody.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#dedcdc"));
            }
            if (theme == "Tmavý")
            {
                prevody.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4d4c4c"));
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("teorie.xaml", UriKind.Relative);
            home.Background = new SolidColorBrush(Colors.Transparent);
            vypocty.Background = new SolidColorBrush(Colors.Transparent);
            prevody.Background = new SolidColorBrush(Colors.Transparent);
            set.Background = new SolidColorBrush(Colors.Transparent);
            about.Background = new SolidColorBrush(Colors.Transparent);
            if (theme == "Světlý")
            {
                teorie.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#dedcdc"));
            }
            if (theme == "Tmavý")
            {
                teorie.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#4d4c4c"));
            }
        }
    }
}