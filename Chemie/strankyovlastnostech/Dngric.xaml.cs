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
using static Chemie.strankyovlastnostech.Phrases;

namespace Chemie.strankyovlastnostech
{
    /// <summary>
    /// Interaction logic for Dngric.xaml
    /// </summary>
    public partial class Dngric : Page
    {
        internal string df1;
        internal string df2;
        public List<dangericons> dicn = new();
        public List<dwycf> dwf = new();
        public Dngric(string s)
        {
            InitializeComponent();
            dangericonimg.Source = (BitmapImage)System.Windows.Application.Current.Resources[s + "i"];
            headline.Content = (String)System.Windows.Application.Current.Resources[s];
            XDocument doc = XDocument.Parse(Soubory.Resource.dangericons);

            var result = from ele in doc.Descendants(s)
                         select new
                         {
                             dphrases = (string)ele.Element("dphrases"),
                             wycf = (string)ele.Element("wycf"),
                         };
            foreach (var t in result)
            {
                df1 = t.dphrases;
                df2 = t.wycf;
            }
            if (df1 != "")
            {
                string[] dngri = df1.Split(';', ' ');
                dngri = dngri.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                dngri = dngri.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                foreach (var dx in dngri)
                {
                    string d = dx.Replace("/", "_");
                    string dy = "- " + (String)System.Windows.Application.Current.Resources[d];
                    dicn.Add(new dangericons() { dm = dy});
                    dngericns.ItemsSource = dicn;
                }
            }
            if (df2 != "")
            {
                string[] dngri2 = df2.Split(';', ' ');
                dngri2 = dngri2.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                dngri2 = dngri2.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                foreach (var da in dngri2)
                {
                    string dk = da.Replace("/", "_");
                    string db = "- " + (String)System.Windows.Application.Current.Resources[dk];
                    dwf.Add(new dwycf() { dw = db });
                    wycfdata.ItemsSource = dwf;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
    public class dangericons
    {
        public string dm { get; set; }
    }
    public class dwycf
    {
        public string dw { get; set; }
    }
}
