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
        public prvekinfo(string kodprvku)
        {
            InitializeComponent();
            var xml = XDocument.Parse(Soubory.Resource.prvky);
            string lang = Properties.Settings.Default.applang;
            // Vytvoření datasetu
            DataSet dataSet = new DataSet();
            // Vložení dat do datasetu
            dataSet.ReadXml(xml.CreateReader());
            DataView dataView = new DataView(dataSet.Tables[kodprvku]);
            dataGrid1.ItemsSource = dataView;
            #region ikony_nebezpecnosti_s_r_vety
            if (kodprvku == "Vodík")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S2; S9; S16; S33";
                rvety.Content = "R12";
                infobox.Text = Soubory.Resource.Vodík;
                wikilink.Click += new RoutedEventHandler(vodik_click);
            }
            if(kodprvku == "Lithium")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S1/2; S8; S43; S45";
                rvety.Content = "R14/15; R34";
                infobox.Text = Soubory.Resource.Lithium;
                wikilink.Click += new RoutedEventHandler(Lithium_click);

            }
            if (kodprvku == "Sodík")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled= true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S1/2; S5; S8; S43; S45";
                rvety.Content = "R14/15; R34";
                infobox.Text = Soubory.Resource.Sodík;
               wikilink.Click += new RoutedEventHandler(Sodík_click);
            }
            if (kodprvku == "Draslík")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S1/2; S8; S45";
                rvety.Content = "R14/15; R34";
                infobox.Text = Soubory.Resource.Draslík;
               wikilink.Click += new RoutedEventHandler(Draslík_click);
            }
            if (kodprvku == "Rubidium")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S7/8; S20; S26; S30; S33; S36/37/39; S43; S45";
                rvety.Content = "R14/15; R34";
                infobox.Text = Soubory.Resource.Rubidium;
               wikilink.Click += new RoutedEventHandler(Rubidium_click);
            }
            if (kodprvku == "Cesium")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Cesium;
               wikilink.Click += new RoutedEventHandler(Cesium_click);
            }
            if (kodprvku == "Francium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Francium;
               wikilink.Click += new RoutedEventHandler(Francium_click);
            }
            if (kodprvku == "Beryllium")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled=true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "S53; S45";
                rvety.Content = "R49; R25; R26; R48/23; R36/37/38; R43";
                infobox.Text = Soubory.Resource.Beryllium;
                wikilink.Click += new RoutedEventHandler(Beryllium_click);
            }
            if (kodprvku == "Hořčík")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S2; S7/8; S43";
                rvety.Content = "R11; R15; R17";
                infobox.Text = Soubory.Resource.Hořčík;
                wikilink.Click += new RoutedEventHandler(Hořčík_click);
            }
            if (kodprvku == "Vápník")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S2; S8; S24/25; S43";
                rvety.Content = "R15";
                infobox.Text = Soubory.Resource.Vápník;
                wikilink.Click += new RoutedEventHandler(Vápník_click);
            }
            if (kodprvku == "Stroncium")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled= true;
                svety.Content = "S8; S24/25; S43";
                rvety.Content = "R15";
                infobox.Text = Soubory.Resource.Stroncium;
                wikilink.Click += new RoutedEventHandler(Stroncium_click);
            }
            if (kodprvku == "Baryum")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Baryum;
                wikilink.Click += new RoutedEventHandler(Baryum_click);
            }
            if (kodprvku == "Radium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Radium;
                wikilink.Click += new RoutedEventHandler(Radium_click);
            }
            if (kodprvku == "Skandium")
            {               
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled= true;
                svety.Content = "S16; S43";
                rvety.Content = "R11";
                infobox.Text = Soubory.Resource.Skandium;
                wikilink.Click += new RoutedEventHandler(Skandium_click);
            }
            if (kodprvku == "Yttrium")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S7/9; S16; S33";
                rvety.Content = "R11";
                infobox.Text = Soubory.Resource.Yttrium;
                wikilink.Click += new RoutedEventHandler(Yttrium_click);
            }
            if (kodprvku == "Titan")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled= true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S26";
                rvety.Content = "R17; R36/37/38";
                infobox.Text = Soubory.Resource.Titan;
               wikilink.Click += new RoutedEventHandler(Titan_click);
            }
            if (kodprvku == "Zirkonium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S2; S7/8; S43";
                rvety.Content = "R15; R17";
                infobox.Text = Soubory.Resource.Zirkonium;
               wikilink.Click += new RoutedEventHandler(Zirkonium_click);
            }
            if (kodprvku == "Hafnium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Hafnium;
               wikilink.Click += new RoutedEventHandler(Hafnium_click);
            }
            if (kodprvku == "Rutherfordium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Rutherfordium;
               wikilink.Click += new RoutedEventHandler(Rutherfordium_click);
            }
            if (kodprvku == "Vanad")
            {
                svety.Content = "S7; S26; S33; S37; S43; S60";
                rvety.Content = "R17; R36/37/38";
                infobox.Text = Soubory.Resource.Vanad;
               wikilink.Click += new RoutedEventHandler(Vanad_click);
            }
            if (kodprvku == "Niob")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S43";
                rvety.Content = "R11";
                infobox.Text = Soubory.Resource.Niob;
               wikilink.Click += new RoutedEventHandler(Niob_click);
            }
            if (kodprvku == "Tantal")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled=true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Tantal;
               wikilink.Click += new RoutedEventHandler(Tantal_click);
            }
            if (kodprvku == "Dubnium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Dubnium;
               wikilink.Click += new RoutedEventHandler(Dubnium_click);
            }
            if (kodprvku == "Chrom")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                svety.Content = "S7; S33; S36/37; S60";
                rvety.Content = "R11; R40";
                infobox.Text = Soubory.Resource.Chrom;
               wikilink.Click += new RoutedEventHandler(Chrom_click);

            }
            if (kodprvku == "Molybden")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled= true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Molybden;
               wikilink.Click += new RoutedEventHandler(Molybden_click); 
            }
            if (kodprvku == "Wolfram")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled= true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Wolfram;
                wikilink.Click += new RoutedEventHandler(Wolfram_click);
            }
            if (kodprvku == "Seaborgium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Seaborgium;
                wikilink.Click += new RoutedEventHandler(Seaborgium_click);
            }
            if (kodprvku == "Mangan")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled= true;
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled=true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S7; S33; S43; S60";
                rvety.Content = "R11";
                infobox.Text = Soubory.Resource.Mangan;
               wikilink.Click += new RoutedEventHandler(Mangan_click);
            }
            if (kodprvku == "Technecium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Technecium;
               wikilink.Click += new RoutedEventHandler(Technecium_click);
            }
            if (kodprvku == "Rhenium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Rhenium;
               wikilink.Click += new RoutedEventHandler(Rhenium_click);
            }
            if (kodprvku == "Bohrium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Bohrium;
               wikilink.Click += new RoutedEventHandler(Bohrium_click);
            }
            if (kodprvku == "Železo")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled=true;
                svety.Content = "S53; S45; S60; S61";
                rvety.Content = "R11";
                infobox.Text = Soubory.Resource.Železo;
               wikilink.Click += new RoutedEventHandler(Železo_click);
            }
            if (kodprvku == "Ruthenium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S16; S22; S24/25";
                rvety.Content = "R11";
                infobox.Text = Soubory.Resource.Ruthenium;
               wikilink.Click += new RoutedEventHandler(Ruthenium_click);
            }
            if (kodprvku == "Osmium")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled= true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Osmium;
               wikilink.Click += new RoutedEventHandler(Osmium_click);
            }
            if (kodprvku == "Hassium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                infobox.Text = Soubory.Resource.Hassium;
               wikilink.Click += new RoutedEventHandler(Hassium_click);
            }
            if (kodprvku == "Kobalt")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                svety.Content = "S2; S22; S24; S37; S61";
                rvety.Content = "R42/43; R53";
                /*   infobox.Text = Soubory.Resource.Lithium;
               wikilink.Click += new RoutedEventHandler(Lithium_click); */
            }
            if (kodprvku == "Rhodium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S16; S22; S24/25";
                rvety.Content = "R11";
                /*   infobox.Text = Soubory.Resource.Lithium;
               wikilink.Click += new RoutedEventHandler(Lithium_click); */
            }
            if (kodprvku == "Iridium")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled= true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled= true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Lithium;
               wikilink.Click += new RoutedEventHandler(Lithium_click); */
            }
            if (kodprvku == "Meitnerium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Lithium;
               wikilink.Click += new RoutedEventHandler(Lithium_click); */
            }
            if (kodprvku == "Nikl")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;

                svety.Content = "S2; S36/37/39; S45; S61";
                rvety.Content = "R40; R43; R48/23; R52/53";
                /*   infobox.Text = Soubory.Resource.Lithium;
               wikilink.Click += new RoutedEventHandler(Lithium_click); */
            }
            if (kodprvku == "Palladium")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled= true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S7/9; S16; S26; S36";
                rvety.Content = "R11; R36/37/38";
                /*   infobox.Text = Soubory.Resource.Palladium;
               wikilink.Click += new RoutedEventHandler(Palladium_click); */
            }
            if (kodprvku == "Platina")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true ;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled= true;
                oxidujici.Visibility = Visibility.Visible;
                oxidujicibtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Platina;
               wikilink.Click += new RoutedEventHandler(Platina_click); */
            }
            if (kodprvku == "Darmstadtium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Darmstadtium;
               wikilink.Click += new RoutedEventHandler(Darmstadtium_click); */
            }
            if (kodprvku == "Měď")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true ;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Měď;
               wikilink.Click += new RoutedEventHandler(Měď_click); */
            }
            if (kodprvku == "Stříbro")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Stříbro;
               wikilink.Click += new RoutedEventHandler(Stříbro_click); */
            }
            if (kodprvku == "Zlato")
            {
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Zlato;
               wikilink.Click += new RoutedEventHandler(Zlato_click); */
            }
            if (kodprvku == "Roentgenium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Roentgenium;
               wikilink.Click += new RoutedEventHandler(Roentgenium_click); */
            }
            if (kodprvku == "Zinek")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled= true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S2; S43; S46; S60; S61";
                rvety.Content = "R15; R17; R50/53";
                /*   infobox.Text = Soubory.Resource.Zinek;
               wikilink.Click += new RoutedEventHandler(Zinek_click); */
            }
            if (kodprvku == "Kadmium")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled= true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;

                svety.Content = "S1/2; S22; S35; S45; S46; S61";
                rvety.Content = "R23; R25; R33; R45; R50/53";
                /*   infobox.Text = Soubory.Resource.Kadmium;
               wikilink.Click += new RoutedEventHandler(Kadmium_click); */
            }
            if (kodprvku == "Rtuť")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled= true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled= true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "S53; S45; S60; S61";
                rvety.Content = "R61; R26; R48/23; R50/53";
                /*   infobox.Text = Soubory.Resource.Rtuť;
               wikilink.Click += new RoutedEventHandler(Rtuť_click); */
            }
            if (kodprvku == "Kopernicium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Kopernicium;
               wikilink.Click += new RoutedEventHandler(Kopernicium_click); */
            }
            if (kodprvku == "Bor")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "R22";
                /*   infobox.Text = Soubory.Resource.Bor;
               wikilink.Click += new RoutedEventHandler(Bor_click); */
            }
            if (kodprvku == "Hliník")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;

                svety.Content = "S2; S7/8; S43";
                rvety.Content = "R10; R15; R17";
                /*   infobox.Text = Soubory.Resource.Hliník;
               wikilink.Click += new RoutedEventHandler(Hliník_click); */
            }
            if (kodprvku == "Gallium")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                svety.Content = "S26; S36/37/39; S45";
                rvety.Content = "R34";
                /*   infobox.Text = Soubory.Resource.Gallium;
               wikilink.Click += new RoutedEventHandler(Gallium_click); */
            }
            if (kodprvku == "Indium")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled=true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled=true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Indium;
               wikilink.Click += new RoutedEventHandler(Indium_click); */
            }
            if (kodprvku == "Thallium")
            {
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "S1/2; S22; S35; S45; S46; S61";
                rvety.Content = "R26; R28; R45; R50/53";
                /*   infobox.Text = Soubory.Resource.Thallium;
               wikilink.Click += new RoutedEventHandler(Thallium_click); */
            }
            if (kodprvku == "Nihonium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Nihonium;
               wikilink.Click += new RoutedEventHandler(Nihonium_click); */
            }
            if (kodprvku == "Uhlík")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled= true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled=true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Uhlík;
               wikilink.Click += new RoutedEventHandler(Uhlík_click); */
            }
            if (kodprvku == "Křemík")
            {
                svety.Content = "S26; S36/37/39; S22";
                rvety.Content = "R36/38; R11; R36/37/38";
                /*   infobox.Text = Soubory.Resource.Křemík;
               wikilink.Click += new RoutedEventHandler(Křemík_click); */
            }
            if (kodprvku == "Germanium")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled= true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                svety.Content = "S9; S16; S29; S33";
                rvety.Content = "R11";
                /*   infobox.Text = Soubory.Resource.Germanium;
               wikilink.Click += new RoutedEventHandler(Germanium_click); */
            }
            if (kodprvku == "Cín")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled= true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Cín;
               wikilink.Click += new RoutedEventHandler(Cín_click); */
            }
            if (kodprvku == "Olovo")
            {
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled=true;
                svety.Content = "S1/2; S45; S46; S61";
                rvety.Content = "R25; R45; R58; R61";
                /*   infobox.Text = Soubory.Resource.Olovo;
               wikilink.Click += new RoutedEventHandler(Olovo_click); */
            }
            if (kodprvku == "Flerovium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Flerovium;
               wikilink.Click += new RoutedEventHandler(Flerovium_click); */
            }
            if (kodprvku == "Dusík")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Dusík;
               wikilink.Click += new RoutedEventHandler(Dusík_click); */
            }
            if (kodprvku == "Fosfor")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled= true;
                svety.Content = "Červený:S2; S7; S43; S61    Bílý:S1/2; S5; S26; S38; S45; S61";
                rvety.Content = "Červený:R11; R16; R52/53    Bílý: R17; R26/28; R35; R50";
                /*   infobox.Text = Soubory.Resource.Fosfor;
               wikilink.Click += new RoutedEventHandler(Fosfor_click); */
            }
            if (kodprvku == "Arsen")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled= true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled=true;
                svety.Content = "S1/2; S20/21; S28; S45; S60; S61";
                rvety.Content = "R23/25; R50/53";
                /*   infobox.Text = Soubory.Resource.Arsen;
               wikilink.Click += new RoutedEventHandler(Arsen_click); */
            }
            if (kodprvku == "Antimon")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled= true;
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled= true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Antimon;
               wikilink.Click += new RoutedEventHandler(Antimon_click); */
            }
            if (kodprvku == "Bismut")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled=true;
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Bismut;
               wikilink.Click += new RoutedEventHandler(Bismut_click); */
            }
            if (kodprvku == "Moscovium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Moscovium;
               wikilink.Click += new RoutedEventHandler(Moscovium_click); */
            }
            if (kodprvku == "Kyslík")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                oxidujici.Visibility = Visibility.Visible;
                oxidujicibtn.IsEnabled = true;
                svety.Content = "S2; S17";
                rvety.Content = "R8";
                /*   infobox.Text = Soubory.Resource.Kyslík;
               wikilink.Click += new RoutedEventHandler(Kyslík_click); */
            }
            if (kodprvku == "Síra")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                svety.Content = "S2; S46";
                rvety.Content = "R38";
                /*   infobox.Text = Soubory.Resource.Síra;
               wikilink.Click += new RoutedEventHandler(Síra_click); */
            }
            if (kodprvku == "Selen")
            {
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled= true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "S1/2; S20/21; S28; S45; S61";
                rvety.Content = "R23/25; R33; R53";
                /*   infobox.Text = Soubory.Resource.Selen;
               wikilink.Click += new RoutedEventHandler(Selen_click); */
            }
            if (kodprvku == "Tellur")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled=true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled= true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Tellur;
               wikilink.Click += new RoutedEventHandler(Tellur_click); */
            }
            if (kodprvku == "Polonium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Polonium;
               wikilink.Click += new RoutedEventHandler(Polonium_click); */
            }
            if (kodprvku == "Livermorium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Livermorium;
               wikilink.Click += new RoutedEventHandler(Livermorium_click); */
            }
            if (kodprvku == "Fluor")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                oxidujici.Visibility = Visibility.Visible;
                oxidujicibtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled=true;
                svety.Content = "S9; S26; S28; S36/37/39; S45";
                rvety.Content = "R8; R26; R35";
                /*   infobox.Text = Soubory.Resource.Fluor;
               wikilink.Click += new RoutedEventHandler(Fluor_click); */
            }
            if (kodprvku == "Chlor")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                oxidujici.Visibility = Visibility.Visible;
                oxidujicibtn.IsEnabled=true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled=true;
                svety.Content = "S1/2; S9; S45; S61";
                rvety.Content = "R23, R36/37/38, R50";
                /*   infobox.Text = Soubory.Resource.Chlor;
               wikilink.Click += new RoutedEventHandler(Chlor_click); */
            }
            if (kodprvku == "Brom")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled=true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "S1/2; S7/9; S26; S45; S61";
                rvety.Content = "R26; R35; R50";
                /*   infobox.Text = Soubory.Resource.Brom;
               wikilink.Click += new RoutedEventHandler(Brom_click); */
            }
            if (kodprvku == "Jod")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Jod;
               wikilink.Click += new RoutedEventHandler(Jod_click); */
            }
            if (kodprvku == "Astat")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Astat;
               wikilink.Click += new RoutedEventHandler(Astat_click); */
            }
            if (kodprvku == "Tennessin")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Tennessin;
               wikilink.Click += new RoutedEventHandler(Tennessin_click); */
            }
            if (kodprvku == "Helium")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                rvetybtn.IsEnabled = false;
                svety.Content = "S9; S23";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Helium;
               wikilink.Click += new RoutedEventHandler(Helium_click); */
            }
            if (kodprvku == "Neon")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled= true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Neon;
               wikilink.Click += new RoutedEventHandler(Neon_click); */
            }
            if (kodprvku == "Argon")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Argon;
               wikilink.Click += new RoutedEventHandler(Argon_click); */
            }
            if (kodprvku == "Krypton")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Krypton;
               wikilink.Click += new RoutedEventHandler(Krypton_click); */
            }
            if (kodprvku == "Xenon")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Xenon;
               wikilink.Click += new RoutedEventHandler(Xenon_click); */
            }
            if (kodprvku == "Radon")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Radon;
               wikilink.Click += new RoutedEventHandler(Radon_click); */
            }
            if (kodprvku == "Oganesson")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Oganesson;
               wikilink.Click += new RoutedEventHandler(Oganesson_click); */
            }
            if (kodprvku == "Lanthan")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Lanthan;
               wikilink.Click += new RoutedEventHandler(Lanthan_click); */
            }
            if (kodprvku == "Cer")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled= true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Cer;
               wikilink.Click += new RoutedEventHandler(Cer_click); */
            }
            if (kodprvku == "Praseodym")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled= true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled=true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Praseodym;
               wikilink.Click += new RoutedEventHandler(Praseodym_click); */
            }
            if (kodprvku == "Neodym")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled=true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Neodym;
               wikilink.Click += new RoutedEventHandler(Neodym_click); */
            }
            if (kodprvku == "Promethium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Promethium;
               wikilink.Click += new RoutedEventHandler(Promethium_click); */
            }
            if (kodprvku == "Samarium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;                
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Samarium;
               wikilink.Click += new RoutedEventHandler(Samarium_click); */
            }
            if (kodprvku == "Europium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled=true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Europium;
               wikilink.Click += new RoutedEventHandler(Europium_click); */
            }
            if (kodprvku == "Gadolinium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Gadolinium;
               wikilink.Click += new RoutedEventHandler(Gadolinium_click); */
            }
            if (kodprvku == "Terbium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Terbium;
               wikilink.Click += new RoutedEventHandler(Terbium_click); */
            }
            if (kodprvku == "Dysprosium")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Dysprosium;
               wikilink.Click += new RoutedEventHandler(Dysprosium_click); */
            }
            if (kodprvku == "Holmium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Holmium;
               wikilink.Click += new RoutedEventHandler(Holmium_click); */
            }
            if (kodprvku == "Erbium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Erbium;
               wikilink.Click += new RoutedEventHandler(Erbium_click); */
            }
            if (kodprvku == "Thulium")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Thulium;
               wikilink.Click += new RoutedEventHandler(Thulium_click); */
            }
            if (kodprvku == "Ytterbium")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Ytterbium;
               wikilink.Click += new RoutedEventHandler(Ytterbium_click); */
            }
            if (kodprvku == "Lutecium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Lutecium;
               wikilink.Click += new RoutedEventHandler(Lutecium_click); */
            }
            if (kodprvku == "Aktinium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Aktinium;
               wikilink.Click += new RoutedEventHandler(Aktinium_click); */
            }
            if (kodprvku == "Thorium")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                oxidujici.Visibility = Visibility.Visible;
                oxidujicibtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Thorium;
               wikilink.Click += new RoutedEventHandler(Thorium_click); */
            }
            if (kodprvku == "Protaktinium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Protaktinium;
               wikilink.Click += new RoutedEventHandler(Protaktinium_click); */
            }
            if (kodprvku == "Uran")
            {
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled=true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svety.Content = "S1/2; S20/21; S45; S61";
                rvety.Content = "R26/28; R33; R53";
                /*   infobox.Text = Soubory.Resource.Uran;
               wikilink.Click += new RoutedEventHandler(Uran_click); */
            }
            if (kodprvku == "Neptunium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Neptunium;
               wikilink.Click += new RoutedEventHandler(Neptunium_click); */
            }
            if (kodprvku == "Plutonium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Plutonium;
               wikilink.Click += new RoutedEventHandler(Plutonium_click); */
            }
            if (kodprvku == "Americium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Americium;
               wikilink.Click += new RoutedEventHandler(Americium_click); */
            }
            if (kodprvku == "Curium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Curium;
               wikilink.Click += new RoutedEventHandler(Curium_click); */
            }
            if (kodprvku == "Berkelium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Berkelium;
               wikilink.Click += new RoutedEventHandler(Berkelium_click); */
            }
            if (kodprvku == "Kalifornium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Kalifornium;
               wikilink.Click += new RoutedEventHandler(Kalifornium_click); */
            }
            if (kodprvku == "Einsteinium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Einsteinium;
               wikilink.Click += new RoutedEventHandler(Einsteinium_click); */
            }
            if (kodprvku == "Fermium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Fermium;
               wikilink.Click += new RoutedEventHandler(Fermium_click); */
            }
            if (kodprvku == "Mendelevium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Mendelevium;
               wikilink.Click += new RoutedEventHandler(Mendelevium_click); */
            }
            if (kodprvku == "Nobelium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Nobelium;
               wikilink.Click += new RoutedEventHandler(Nobelium_click); */
            }
            if (kodprvku == "Lawrencium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
                /*   infobox.Text = Soubory.Resource.Lawrencium;
               wikilink.Click += new RoutedEventHandler(Lawrencium_click); */
            }
            #endregion;

            headline.Content = "Informace o prvku: "+ kodprvku;
            string hdtext = Chemie.Properties.Settings.Default.hdtextcolor;
            string thmpck = Chemie.Properties.Settings.Default.theme;
            if (thmpck == "Světlý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.Black);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.LightGray);
                this.Resources["cellbg"] = new SolidColorBrush(Colors.White);
                this.Resources["cellfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbbg"] = new SolidColorBrush(Colors.White);
            }
            if (thmpck == "Tmavý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);
                this.Resources["cellbg"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555555"));
                this.Resources["cellfg"] = new SolidColorBrush(Colors.White);
                this.Resources["tbbg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbfg"] = new SolidColorBrush(Colors.White);
            }
            string prvek = kodprvku;
            this.kodprvku = kodprvku;
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
        #region hotovo
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }      
        private void Lithium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Lithium",
                UseShellExecute = true
            });
        }
        private void Sodík_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Sod%C3%ADk",
                UseShellExecute = true
            });
        } 
        private void Draslík_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Drasl%C3%ADk",
                UseShellExecute = true
            });
        }
        private void Rubidium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Rubidium",
                UseShellExecute = true
            });
        }
        private void Cesium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Cesium",
                UseShellExecute = true
            });
        }
        private void Francium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Francium",
                UseShellExecute = true
            });
        }
        private void Beryllium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Beryllium",
                UseShellExecute = true
            });
        }
        private void Hořčík_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Ho%C5%99%C4%8D%C3%ADk",
                UseShellExecute = true
            });
        }
        private void Vápník_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/V%C3%A1pn%C3%ADk",
                UseShellExecute = true
            });
        }
        private void Stroncium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Stroncium",
                UseShellExecute = true
            });
        }
        private void Baryum_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Baryum",
                UseShellExecute = true
            });
        }
        private void Radium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Radium",
                UseShellExecute = true
            });
        }
        private void Skandium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Skandium",
                UseShellExecute = true
            });
        }
        private void Yttrium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Yttrium",
                UseShellExecute = true
            });
        }
        private void Titan_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Titan_(prvek)",
                UseShellExecute = true
            });
        }
        private void Zirkonium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Zirkonium",
                UseShellExecute = true
            });
        }
        private void Hafnium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Hafnium",
                UseShellExecute = true
            });
        }
        private void Rutherfordium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Rutherfordium",
                UseShellExecute = true
            });
        }
        private void Vanad_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vanad",
                UseShellExecute = true
            });
        }
        private void Niob_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Niob",
                UseShellExecute = true
            });
        }
        private void Tantal_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Tantal",
                UseShellExecute = true
            });
        }
        private void Dubnium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Dubnium",
                UseShellExecute = true
            });
        }
        private void Chrom_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Chrom",
                UseShellExecute = true
            });
        }
        private void Molybden_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Molybden",
                UseShellExecute = true
            });
        }
        private void Wolfram_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Wolfram",
                UseShellExecute = true
            });
        }
        private void Seaborgium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Seaborgium",
                UseShellExecute = true
            });
        }
        #endregion
        private void Mangan_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Mangan",
                UseShellExecute = true
            });
        }
        private void Technecium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Technecium",
                UseShellExecute = true
            });
        }
        private void Rhenium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Rhenium",
                UseShellExecute = true
            });
        }
        private void Bohrium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Bohrium",
                UseShellExecute = true
            });
        }
        private void Železo_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/%C5%BDelezo",
                UseShellExecute = true
            });
        }
        private void Ruthenium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Ruthenium",
                UseShellExecute = true
            });
        }
        private void Osmium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Osmium",
                UseShellExecute = true
            });
        }
        private void Hassium_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Hassium",
                UseShellExecute = true
            });
        }
        /*
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        private void vodik_click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = "https://cs.wikipedia.org/wiki/Vod%C3%ADk",
                UseShellExecute = true
            });
        }
        */
    }
}
