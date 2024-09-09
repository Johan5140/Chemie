using Chemie.strankyovlastnostech;
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
using System.Xml.Linq;

namespace Chemie.strankyovlastnostech
{
    /// <summary>
    /// Interakční logika pro rvety.xaml
    /// </summary>
    public partial class rvety : Page
    {
        public rvety(string kodprvku)
        {
            InitializeComponent();
            nav2.NavigationService.Navigate(new rvetypage(kodprvku));
            string prvek = kodprvku;
            this.kodprvku = kodprvku;
            string thmpck = Chemie.Properties.Settings.Default.theme;
            if (kodprvku == "n")
            {
                headline.Content = Application.Current.Resources["rphrases"];
            }
            else
            {
                headline.Content = Application.Current.Resources["rphrases"] + " " + Application.Current.Resources[kodprvku];
                XDocument doc = XDocument.Parse(Soubory.Resource.data);

                var result = from ele in doc.Descendants(kodprvku)
                             select new
                             {
                                 rphrases = (string)ele.Element("rphrases")
                             };
                foreach (var t in result)
                {
                    rvetyprvku.Content = Application.Current.Resources["rphrasesfor"] + " " + Application.Current.Resources[kodprvku] + ": " + t.rphrases;
                }
            }

        }
        public string kodprvku { get; set; }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
