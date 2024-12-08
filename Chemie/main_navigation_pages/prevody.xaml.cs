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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chemie
{
    /// <summary>
    /// Interakční logika pro prevody.xaml
    /// </summary>
    public partial class prevody : Page
    {
        public prevody()
        {
            InitializeComponent();
            string thmpck = Chemie.Properties.Settings.Default.theme;
            tfncpick.SelectedValue = lenght;
            transnav.Source = new Uri("../transfer_pages/lenght.xaml", UriKind.Relative);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (tfncpick.SelectedItem == null)
            {
                MainWindow win = (MainWindow)MainWindow.GetWindow(this);
                win.Showmessage((String)System.Windows.Application.Current.Resources["empty_cb"], (String)System.Windows.Application.Current.Resources["error"], "Chyba");
            }
            else
            {
                ComboBoxItem ComboItem = (ComboBoxItem)tfncpick.SelectedItem;
                string vybran = ComboItem.Name;
                if (vybran == "lenght")
                {
                    transnav.Source = new Uri("../transfer_pages/lenght.xaml", UriKind.Relative);
                }
                if (vybran == "weight")
                {
                    transnav.Source = new Uri("../transfer_pages/weight.xaml", UriKind.Relative);
                }
                if (vybran == "volume")
                {
                    transnav.Source = new Uri("../transfer_pages/volume.xaml", UriKind.Relative);
                }
                if (vybran == "area")
                {
                    transnav.Source = new Uri("../transfer_pages/area.xaml", UriKind.Relative);
                }
                if (vybran == "density")
                {
                    transnav.Source = new Uri("../transfer_pages/density.xaml", UriKind.Relative);
                }
                if (vybran == "force")
                {
                    transnav.Source = new Uri("../transfer_pages/force.xaml", UriKind.Relative);
                }
                if (vybran == "pressure")
                {
                    transnav.Source = new Uri("../transfer_pages/pressure.xaml", UriKind.Relative);
                }
                if (vybran == "workandenergy")
                {
                    transnav.Source = new Uri("../transfer_pages/workandenergy.xaml", UriKind.Relative);
                }
                if (vybran == "power")
                {
                    transnav.Source = new Uri("../transfer_pages/power.xaml", UriKind.Relative);
                }
                if (vybran == "angle")
                {
                    transnav.Source = new Uri("../transfer_pages/angle.xaml", UriKind.Relative);
                }
                if (vybran == "time")
                {
                    transnav.Source = new Uri("../transfer_pages/time.xaml", UriKind.Relative);
                }
                if (vybran == "speed")
                {
                    transnav.Source = new Uri("../transfer_pages/speed.xaml", UriKind.Relative);
                }
            }
        }
    }
}
