using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
using static System.Windows.Forms.LinkLabel;
using System.Xml.Linq;

namespace Chemie.strankyovlastnostech
{
    /// <summary>
    /// Interakční logika pro svety.xaml
    /// </summary>
    public partial class svety : Page
    {
        public svety(string kodprvku)
        {
            InitializeComponent();
            nav1.NavigationService.Navigate(new svetypage(kodprvku));
            string thmpck = Chemie.Properties.Settings.Default.theme;
            string prvek = kodprvku;
            this.kodprvku = kodprvku;
            if (kodprvku == "n")
            {
                headline.Content = Application.Current.Resources["sphrases"];
            }
            else {
                headline.Content = Application.Current.Resources["sphrases"] + " " + Application.Current.Resources[kodprvku];
                XDocument doc = XDocument.Parse(Soubory.Resource.data);

                var result = from ele in doc.Descendants(kodprvku)
                             select new
                             {
                                 sphrases = (string)ele.Element("sphrases")
                             };
                foreach (var t in result)
                {
                    svetyprvku.Text = Application.Current.Resources["sphrasesfor"] +" " + Application.Current.Resources[kodprvku] + ": " +t.sphrases;
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
