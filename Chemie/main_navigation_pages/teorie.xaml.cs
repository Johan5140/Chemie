using Chemie.strankyovlastnostech;
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

namespace Chemie
{
    /// <summary>
    /// Interakční logika pro teorie.xaml
    /// </summary>
    public partial class teorie : Page
    {
        public List<dngbtns> xbtns = new();
        internal string xbx;
        internal string labelsbytag;
        public teorie()
        {
            InitializeComponent();
            string thmpck = Chemie.Properties.Settings.Default.theme;
            XDocument doc = XDocument.Parse(Soubory.Resource.tctll);

            var result = from ele in doc.Descendants("danger")
                         select new
                         {
                             symbol = (string)ele.Element("xb"),
                         };
            foreach (var t in result)
            {
                xbx = t.symbol;
            }
            if (xbx != "")
            {
                string[] dngri = xbx.Split(';', ' ');
                dngri = dngri.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                dngri = dngri.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                foreach (var dx in dngri)
                {
                    string tbg = "Gray";
                    string d = dx.Replace("/", "_");
                    if (d == "radiace")
                    {
                        tbg = "DarkOrange";
                    }
                    else
                    {
                        tbg = "#693232";
                    }
                    string dy = (String)System.Windows.Application.Current.Resources[d];
                    BitmapImage di = (BitmapImage)System.Windows.Application.Current.Resources[d + "i"];
                    xbtns.Add(new dngbtns() { btn = d, dimg = di, dt = dy, ttbg = tbg });
                    thdbtns.ItemsSource = xbtns;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button xs = (Button)sender;
            NavigationService.Navigate(new Phrases("n" ,xs.Name, labelsbytag));
        }
        private void Dngr_Click(object sender, RoutedEventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();
            NavigationService.Navigate(new Dngric(tag));
        }

    }
  public class dngbtns
    {
        public string btn { get; set; }
        public string dt { get; set; }
        public string ttbg { get; set; }
        public BitmapImage dimg { get; set; }
    }
}
