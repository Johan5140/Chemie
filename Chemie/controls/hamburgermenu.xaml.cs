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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chemie.controls
{
    /// <summary>
    /// Interakční logika pro hamburgermenu.xaml
    /// </summary>
    public partial class hamburgermenu : UserControl
    {
        public hamburgermenu()
        {
            InitializeComponent();
            string thmpck = Chemie.Properties.Settings.Default.theme;
        }
        public string theme = Properties.Settings.Default.theme;
        public void Onload()
        {
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("../main_navigation_pages/main.xaml", UriKind.Relative);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("../main_navigation_pages/info.xaml", UriKind.Relative);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("../main_navigation_pages/settings.xaml", UriKind.Relative);

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("../main_navigation_pages/vzorce.xaml", UriKind.Relative);

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            nav.Source = new Uri("../main_navigation_pages/prevody.xaml", UriKind.Relative);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
               nav.Source = new Uri("../main_navigation_pages/teorie.xaml", UriKind.Relative);

        }
        private void ToggleButton_click(object sender, RoutedEventArgs e)
        {
            if (menucontrol.IsChecked == true)
            {
                var a = new DoubleAnimation
                {
                    From = 50,
                    To = 170,
                    BeginTime = TimeSpan.FromSeconds(0),
                    Duration = new Duration(TimeSpan.FromMilliseconds(70)),
                };
                var storyboard = new Storyboard();
                storyboard.Children.Add(a);
                //Storyboard.SetTarget(a, menu);
                Storyboard.SetTarget(a, menu);
                Storyboard.SetTargetProperty(a, new PropertyPath(WidthProperty));
                storyboard.Begin();
                Content.ColumnDefinitions[0].Width = new GridLength(170, GridUnitType.Pixel);
            }
            else
            {
                var a = new DoubleAnimation
                {
                    From = 170,
                    To = 50,
                    BeginTime = TimeSpan.FromSeconds(0),
                    Duration = new Duration(TimeSpan.FromMilliseconds(70)),
                };
                var storyboard = new Storyboard();

                storyboard.Children.Add(a);
                Storyboard.SetTarget(a, menu);
                Storyboard.SetTargetProperty(a, new PropertyPath(WidthProperty));
                storyboard.Begin();
                Content.ColumnDefinitions[0].Width = new GridLength(50, GridUnitType.Pixel);
            }
        }
    }
}
