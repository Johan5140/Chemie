using Chemie.strankyovlastnostech;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Http;
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
        internal string sphrasesy;
        internal string rphrasesy;
        public prvekinfo(string kodprvku)
        {
            InitializeComponent();
            string lang = Properties.Settings.Default.applang;           
            headline.Content = Application.Current.Resources["information"];
            string applang = lang.ToLower();
            elementname.Content = Application.Current.Resources[kodprvku];
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
                             sphrases = (string)ele.Element("sphrases"),
                             rphrases = (string)ele.Element("rphrases"),
                             wikilnk = (string)ele.Element("wikilink_"+applang+""),
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
                sphrasesy = t.sphrases;
                rphrasesy = t.rphrases;
                link = t.wikilnk;

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
            #region zobrazení tlačítek nebezpečí podle XML
            if (ziravinay == "yes")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
            }
            if (latky_nebezpecne_pro_ZPy == "yes") 
            { 
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
            }
            if (plyny == "yes") 
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
            }
            if (nebezpeci_pro_zdraviy == "yes") 
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
            }
            if (vybusninay == "yes") 
            {
                vybusnina.Visibility = Visibility.Visible;
                vybusninabtn.IsEnabled = true;
            }
            if (horlavinay == "yes") 
            {
                horlavina.Visibility = Visibility.Visible; 
                horlavinabtn.IsEnabled = true;
            }
            if (oxidujiciy == "yes") 
            {
                oxidujici.Visibility = Visibility.Visible;
                oxidujicibtn.IsEnabled = true;
            }
            if (vysoka_nebezpecnost_pro_zdraviy == "yes") 
            {
                vysoka_nebezpecnost_pro_zdravi.Visibility=Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled=true;
            }
            if (akutni_toxicitay == "yes") 
            {
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled=true;
            }
            if (radiacey == "yes") 
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
            }
            if (sphrasesy == "no")
            {
                svetybtn.IsEnabled = false;
                svety.Content = "---";
            }
            if (sphrasesy != "no")
            {
                svety.Content=sphrasesy;
            }
            if (rphrasesy == "no")
            {
                rvetybtn.IsEnabled = false;
                rvety.Content = "---";
            }
            if (rphrasesy != "no")
            {
                rvety.Content = rphrasesy;
            }
            #endregion
            string hdtext = Chemie.Properties.Settings.Default.hdtextcolor;
            string thmpck = Chemie.Properties.Settings.Default.theme;
            if (thmpck == "Světlý")
            {
                /*this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.Black);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.LightGray);
                this.Resources["cellbg"] = new SolidColorBrush(Colors.White);
                this.Resources["cellfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbbg"] = new SolidColorBrush(Colors.White);*/
            }
            if (thmpck == "Tmavý")
            {
                /*this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);
                this.Resources["cellbg"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555555"));
                this.Resources["cellfg"] = new SolidColorBrush(Colors.White);
                this.Resources["tbbg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbfg"] = new SolidColorBrush(Colors.White);*/
            }
            //string prvek = kodprvku;
            this.kodprvku = kodprvku;
            //test.Content = link;
            
            //this.link = btnlink;

        }
        public string kodprvku { get; set; }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

        }
        #region ikony_nebezpeci
        private void radiace_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new radiace());
        }

        private void ziravina_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ziravina());
        }

        private void latky_nebezpecne_pro_ZP_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new nebezpeciZP());
        }

        private void plyn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new plyn());
        }

        private void nebezpeci_pro_zdravi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new nebezpecizdravi());
        }

        private void vybusnina_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new vybusny());
        }

        private void horlavina_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new horlavy());
        }

        private void oxidujici_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new oxidace());
        }

        private void vysoka_nebezpecnost_pro_zdravi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new drazdivy());
        }

        private void akutni_toxicita_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new jedovaty());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new svety(kodprvku));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new rvety(kodprvku));
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
}
