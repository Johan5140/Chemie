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
        public List<dangericons> ssphrasesitem = new();
        public prvekinfo(string kodprvku)
        {
            InitializeComponent();
            string lang = Properties.Settings.Default.applang;           
            headline.Content = Application.Current.Resources["information"];
            string applang = lang.ToLower();
            elementname.Content = Application.Current.Resources[kodprvku];
            #region generated content
            XDocument doc = XDocument.Parse(Soubory.Resource.data);

            var result = from ele in doc.Descendants(kodprvku)
                         select new
                         {
                             symbol = (string)ele.Element("symbol"),
                             atomicnumber = (string)ele.Element("atomicnumber"),
                             latin = (string)ele.Element("latin"),
                             chmgrp = (string)ele.Element("chemgroup"),
                             chmprd = (string)ele.Element("chemperiod"),
                             atmweight = (string)ele.Element("atomicweight"),
                             ssphrases = (string)ele.Element("ssphrases"),
                             csphrases = (string)ele.Element("csphrases"),
                             srphrases = (string)ele.Element("srphrases"),
                             crphrases = (string)ele.Element("crphrases"),
                             wikilnk = (string)ele.Element("wikilink_"+applang+""),
                             dngricns = (string)ele.Element("danger_icns"),
                             ziravinax = (string)ele.Element("ziravina"),
                             latky_nebezpecne_pro_ZPx = (string)ele.Element("latky_nebezpecne_pro_ZP"),
                             plynx = (string)ele.Element("plyn"),
                             nebezpeci_pro_zdravix = (string)ele.Element("nebezpeci_pro_zdravi"),
                             vybusninax = (string)ele.Element("vybusnina"),
                             horlavinax = (string)ele.Element("horlavina"),
                             oxidujicix = (string)ele.Element("oxidujici"),
                             vysoka_nebezpecnost_pro_zdravix = (string)ele.Element("vysoka_nebezpecnost_pro_zdravi"),
                             akutni_toxicitax = (string)ele.Element("akutni_toxicita"),
                             radiacex = (string)ele.Element("radiace"),
                         };
            foreach (var t in result)
            {
                chmsymbol.Content = t.symbol;
                atmcnbr.Content = t.atomicnumber;
                latn.Content = t.latin;
                grp.Content = t.chmgrp;
                prd.Content = t.chmprd;
                atmwght.Content = t.atmweight;
               /* svety.Content = t.sphrases;
                rvety.Content = t.rphrases; */
                ssphrasesy = t.ssphrases;
                srphrasesy = t.srphrases;
                csphrasesy = t.csphrases;
                crphrasesy = t.crphrases;
                link = t.wikilnk;
                dngricnsy = t.dngricns;

                ziravinay = t.ziravinax;
                latky_nebezpecne_pro_ZPy = t.latky_nebezpecne_pro_ZPx;
                plyny = t.plynx;
                nebezpeci_pro_zdraviy = t.nebezpeci_pro_zdravix;
                vybusninay = t.vybusninax;
                horlavinay = t.horlavinax;
                oxidujiciy = t.oxidujicix;
                vysoka_nebezpecnost_pro_zdraviy = t.vysoka_nebezpecnost_pro_zdravix;
                akutni_toxicitay = t.akutni_toxicitax;
                radiacey = t.radiacex;
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
                    BitmapImage di =  (BitmapImage)System.Windows.Application.Current.Resources[d + "i"];
                    ssphrasesitem.Add(new dangericons() { btn = d, dimg = di, dt = dy, ttbg = tbg });
                    sphrasesdata.ItemsSource = ssphrasesitem;
                }
            }
            var fullsp = ssphrasesy + csphrasesy;
            if (fullsp != "" )
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
            } else
            {
                sspr.Content = ssphrasesy;
            }
            if (csphrasesy == "")
            {
                cspr.Content = "---";
            }
            else {
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
            #endregion
            this.kodprvku = kodprvku;
        }
        public string kodprvku { get; set; }
        
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
            NavigationService.Navigate(new Phrases(kodprvku, xs.Name, labelsbytag));
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
