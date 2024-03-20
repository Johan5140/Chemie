using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Chemie;
using WpfApp1;

namespace Chemie
{
    /// <summary>
    /// Interaction logic for aboutapp.xaml
    /// </summary>
    public partial class aboutapp : Window
    {
        public aboutapp()
        {
            InitializeComponent();
            Nameapp.Content = "Chemie";
            ver.Content = "0.4";
            Autor.Content = "Copyright © Johan5140 (GitHub)  2024";
            abouttext.Text = Soubory.Resource.info;
            PreviewKeyDown += (s, e) => { if (e.Key == Key.Escape) this.Close(); };
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
            if (thmpck == "Světlý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.Black);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.LightGray);
                abouttext.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                abouttext.Foreground = new SolidColorBrush(Colors.Black);
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
            }
            if (thmpck == "Tmavý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);
                abouttext.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                abouttext.Foreground = new SolidColorBrush(Colors.White);
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555555"));
            }
            Headline.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Chemie.Properties.Settings.Default.head));
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (!e.Handled && e.Key == Key.Escape && Keyboard.Modifiers == ModifierKeys.None)
            {
                this.Close();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
