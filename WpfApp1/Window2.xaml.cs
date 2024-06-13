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
            home.Background = new SolidColorBrush(Colors.DarkGray);
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
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);
                this.menu.Background = new SolidColorBrush(Colors.LightGray);
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
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);
                this.menu.Background = new SolidColorBrush(Colors.Gray);
            }
            Headline.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Properties.Settings.Default.head));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("main.xaml", UriKind.Relative);
            home.Background = new SolidColorBrush(Colors.DarkGray);
            vypocty.Background = new SolidColorBrush(Colors.Transparent);
            prevody.Background = new SolidColorBrush(Colors.Transparent);
            teorie.Background = new SolidColorBrush(Colors.Transparent);
            set.Background = new SolidColorBrush(Colors.Transparent);
            about.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("info.xaml", UriKind.Relative);
            home.Background = new SolidColorBrush(Colors.Transparent);
            vypocty.Background = new SolidColorBrush(Colors.Transparent);
            prevody.Background = new SolidColorBrush(Colors.Transparent);
            teorie.Background = new SolidColorBrush(Colors.Transparent);
            set.Background = new SolidColorBrush(Colors.Transparent);
            about.Background = new SolidColorBrush(Colors.DarkGray);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("settings.xaml", UriKind.Relative);
            home.Background = new SolidColorBrush(Colors.Transparent);
            vypocty.Background = new SolidColorBrush(Colors.Transparent);
            prevody.Background = new SolidColorBrush(Colors.Transparent);
            teorie.Background = new SolidColorBrush(Colors.Transparent);
            set.Background = new SolidColorBrush(Colors.DarkGray);
            about.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("vzorce.xaml", UriKind.Relative);
            home.Background = new SolidColorBrush(Colors.Transparent);
            vypocty.Background = new SolidColorBrush(Colors.DarkGray);
            prevody.Background = new SolidColorBrush(Colors.Transparent);
            teorie.Background = new SolidColorBrush(Colors.Transparent);
            set.Background = new SolidColorBrush(Colors.Transparent);
            about.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("prevody.xaml", UriKind.Relative);
            home.Background = new SolidColorBrush(Colors.Transparent);
            vypocty.Background = new SolidColorBrush(Colors.Transparent);
            prevody.Background = new SolidColorBrush(Colors.DarkGray);
            teorie.Background = new SolidColorBrush(Colors.Transparent);
            set.Background = new SolidColorBrush(Colors.Transparent);
            about.Background = new SolidColorBrush(Colors.Transparent);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("teorie.xaml", UriKind.Relative);
            home.Background = new SolidColorBrush(Colors.Transparent);
            vypocty.Background = new SolidColorBrush(Colors.Transparent);
            prevody.Background = new SolidColorBrush(Colors.Transparent);
            teorie.Background = new SolidColorBrush(Colors.DarkGray);
            set.Background = new SolidColorBrush(Colors.Transparent);
            about.Background = new SolidColorBrush(Colors.Transparent);
        }
    }
}