using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Chemie;
using WpfApp1;
using System.Diagnostics;
using System.Windows.Navigation;

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
            ver.Content = "0.4";
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
            string thmpck = Properties.Settings.Default.theme;
            if (thmpck == "Světlý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.Black);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.LightGray);
                this.Resources["tbfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbbg"] = new SolidColorBrush(Colors.White);
                reportlink.Foreground = new SolidColorBrush(Colors.Gray);
                swpage.Foreground = new SolidColorBrush(Colors.Gray);
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
            }
            if (thmpck == "Tmavý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);
                this.Resources["tbbg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbfg"] = new SolidColorBrush(Colors.White);
                reportlink.Foreground = new SolidColorBrush(Colors.LightGray);
                swpage.Foreground = new SolidColorBrush(Colors.LightGray);
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
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            // for .NET Core you need to add UseShellExecute = true
            // see https://learn.microsoft.com/dotnet/api/system.diagnostics.processstartinfo.useshellexecute#property-value
            //UseShellExecute = true;
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
            e.Handled = true;
        }
    }
}
