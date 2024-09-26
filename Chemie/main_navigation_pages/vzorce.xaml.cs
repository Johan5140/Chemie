using Chemie.vypocty;
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
    /// Interakční logika pro vzorce.xaml
    /// </summary>
    public partial class vzorce : Page
    {
        public vzorce()
        {
            InitializeComponent();
            string thmpck = Properties.Settings.Default.theme;
            fncpick.SelectedValue = hm;
            vypocty.Source = new Uri("../vypocty/hmzl.xaml", UriKind.Relative);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (fncpick.SelectedItem == null)
            {
                MainWindow win = (MainWindow)MainWindow.GetWindow(this);
                win.Showmessage((String)System.Windows.Application.Current.Resources["empty_cb"], (String)System.Windows.Application.Current.Resources["error"], "Chyba");
            }
            else
            {
                ComboBoxItem ComboItem = (ComboBoxItem)fncpick.SelectedItem;
                string vybran = ComboItem.Name;
                if (vybran == "hm")
                {
                    vypocty.Source = new Uri("../vypocty/hmzl.xaml", UriKind.Relative);
                }
                if (vybran == "hol")
                {
                    vypocty.Source = new Uri("../vypocty/hustota.xaml", UriKind.Relative);
                }
                if (vybran == "oz")
                {
                    vypocty.Source = new Uri("../vypocty/objzl.xaml", UriKind.Relative);
                }
            }
        }
    }
}
   
