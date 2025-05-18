using Chemie.strankyovlastnostech;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Xps.Packaging;
using System.Xml;
using System.Xml.Linq;
using System.Data.SQLite;
using Path = System.IO.Path;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Chemie
{
    /// <summary>
    /// Interakční logika pro prvekinfo.xaml
    /// </summary>
    public partial class prvekinfo : Page

    {
        internal string link;
        internal string ziravinay;
        internal string latky_nebezpecne_pro_ZPy;
        internal string plyny;
        internal string nebezpeci_pro_zdraviy;
        internal string vybusninay;
        internal string horlavinay;
        internal string oxidujiciy;
        internal string vysoka_nebezpecnost_pro_zdraviy;
        internal string akutni_toxicitay;
        internal string radiacey;
        internal string ssphrasesy;
        internal string srphrasesy;
        internal string csphrasesy;
        internal string crphrasesy;
        internal string dngricnsy;
        internal string labelsbytag;
        internal string xnazev;
        public List<dangericons> ssphrasesitem = new();
        public prvekinfo(string idprvku)
        {
            InitializeComponent();
            string lang = Properties.Settings.Default.applang;           
            headline.Content = Application.Current.Resources["information"];
            string applang = lang.ToLower();

            using (SQLiteConnection conn = new SQLiteConnection("Data Source=data.db;Version=3;"))
            {
                conn.Open();

                SQLiteCommand command = new SQLiteCommand("SELECT * FROM prvky_cz WHERE id = " + idprvku + "", conn);
                SQLiteDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    elementname.Content = $"{reader["nazev"]}";
                    chmsymbol.Content = $"{reader["symbol"]}";
                    atmcnbr.Content = $"{reader["id"]}";
                    latn.Content = $"{reader["latin"]}";
                    grp.Content = $"{reader["chemgroup"]}";
                    prd.Content = $"{reader["chemperiod"]}";
                    atmwght.Content = $"{reader["atomicweight"]}";
                    link = $"{reader["wikilink"]}";
                    xnazev = $"{reader["nazev"]}";

                    ssphrasesy = $"{reader["ssphrases"]}";
                    srphrasesy = $"{reader["srphrases"]}";
                    csphrasesy = $"{reader["csphrases"]}";
                    crphrasesy = $"{reader["crphrases"]}";
                    dngricnsy = $"{reader["danger_icns"]}";

                }
            }
            var fullsp = ssphrasesy + csphrasesy;
            if (fullsp != "")
            {
                sphrases.IsEnabled = true;
            }
            var fullrp = srphrasesy + crphrasesy;
            if (fullrp != "")
            {
                rphrases.IsEnabled = true;
            }
            if (ssphrasesy == "")
            {
                sspr.Content = "---";
            }
            else
            {
                sspr.Content = ssphrasesy;
            }
            if (csphrasesy == "")
            {
                cspr.Content = "---";
            }
            else
            {
                cspr.Content = csphrasesy;
            }
            if (srphrasesy == "")
            {
                srpr.Content = "---";
            }
            else
            {
                srpr.Content = srphrasesy;
            }
            if (crphrasesy == "")
            {
                crpr.Content = "---";
            }
            else
            {
                crpr.Content = crphrasesy;
            }
            if (dngricnsy != "")
            {
                string[] dngri = dngricnsy.Split(';', ' ');
                dngri = dngri.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                dngri = dngri.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                foreach (var dx in dngri)
                {
                    string tbg;
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
                    ssphrasesitem.Add(new dangericons() { btn = d, dimg = di, dt = dy, ttbg = tbg });
                    sphrasesdata.ItemsSource = ssphrasesitem;
                }
            }

            this.idprvku = idprvku;
        }
        public string idprvku { get; set; }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }
        private void Btn_Clck(object sender, RoutedEventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();
            NavigationService.Navigate(new Dngric(tag));
        }
        #region ikony_nebezpeci
        private void Phrases_Click(object sender, RoutedEventArgs e)
        {
            Button xs = (Button)sender;
            NavigationService.Navigate(new Phrases(xnazev, xs.Name, labelsbytag));
        }
        #endregion
        private void wiki_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = link,
                UseShellExecute = true
            });
        }
    }
    public class dangericons
    {
        public string btn { get; set; }
        public string dt { get; set; }
        public string ttbg { get; set; }
        public BitmapImage dimg { get; set; }
    }
}
