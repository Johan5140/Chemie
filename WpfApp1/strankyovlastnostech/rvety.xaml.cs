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
            if (kodprvku != null)
            {
                headline.Content = "R-věty" + kodprvku;
            }
            if (kodprvku == null || kodprvku ==  "")
            {
                headline.Content = "R-věty";
            }
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
                this.Resources["labelbordercl"] = new SolidColorBrush(Colors.Black);
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
                this.Resources["labelbordercl"] = new SolidColorBrush(Colors.DarkGray);
            }
            /* Zvýraznění R vět v závislosti na prvku */          
            if (kodprvku == "Vodík")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R12 (jsou vyznačeny červeně)";
                R12.Foreground = new SolidColorBrush(Colors.Red);
                R12.FontWeight = FontWeights.Bold;
                R12.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Lithium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R14/15; R34 (jsou vyznačeny červeně)";
                R34.Foreground = new SolidColorBrush(Colors.Red);
                R34.FontWeight = FontWeights.Bold;
                R34.BorderBrush = new SolidColorBrush(Colors.Red);
                R14_15.Foreground = new SolidColorBrush(Colors.Red);
                R14_15.FontWeight = FontWeights.Bold;
                R14_15.BorderBrush = new SolidColorBrush(Colors.Red);
            }     
            if (kodprvku == "Sodík")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R14/15; R34 (jsou vyznačeny červeně)";
                R34.Foreground = new SolidColorBrush(Colors.Red);
                R34.FontWeight = FontWeights.Bold;
                R34.BorderBrush = new SolidColorBrush(Colors.Red);
                R14_15.Foreground = new SolidColorBrush(Colors.Red);
                R14_15.FontWeight = FontWeights.Bold;
                R14_15.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Draslík")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R14/15; R34 (jsou vyznačeny červeně)";
                R34.Foreground = new SolidColorBrush(Colors.Red);
                R34.FontWeight = FontWeights.Bold;
                R34.BorderBrush = new SolidColorBrush(Colors.Red);
                R14_15.Foreground = new SolidColorBrush(Colors.Red);
                R14_15.FontWeight = FontWeights.Bold;
                R14_15.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Rubidium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R14/15; R34 (jsou vyznačeny červeně)";
                R34.Foreground = new SolidColorBrush(Colors.Red);
                R34.FontWeight = FontWeights.Bold;
                R34.BorderBrush = new SolidColorBrush(Colors.Red);
                R14_15.Foreground = new SolidColorBrush(Colors.Red);
                R14_15.FontWeight = FontWeights.Bold;
                R14_15.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Beryllium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R49; R25; R26; R48/23; R36/37/38; R43 (jsou vyznačeny červeně)";
                R49.Foreground = new SolidColorBrush(Colors.Red);
                R49.FontWeight = FontWeights.Bold;
                R49.BorderBrush = new SolidColorBrush(Colors.Red);
                R25.Foreground = new SolidColorBrush(Colors.Red);
                R25.FontWeight = FontWeights.Bold;
                R25.BorderBrush = new SolidColorBrush(Colors.Red);
                R26.Foreground = new SolidColorBrush(Colors.Red);
                R26.FontWeight = FontWeights.Bold;
                R26.BorderBrush = new SolidColorBrush(Colors.Red);
                R48_23.Foreground = new SolidColorBrush(Colors.Red);
                R48_23.FontWeight = FontWeights.Bold;
                R48_23.BorderBrush = new SolidColorBrush(Colors.Red);
                R36_37_38.Foreground = new SolidColorBrush(Colors.Red);
                R36_37_38.FontWeight = FontWeights.Bold;
                R36_37_38.BorderBrush = new SolidColorBrush(Colors.Red);
                R43.Foreground = new SolidColorBrush(Colors.Red);
                R43.FontWeight = FontWeights.Bold;
                R43.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Hořčík")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11; R15; R17 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
                R15.Foreground = new SolidColorBrush(Colors.Red);
                R15.FontWeight = FontWeights.Bold;
                R15.BorderBrush = new SolidColorBrush(Colors.Red);
                R17.Foreground = new SolidColorBrush(Colors.Red);
                R17.FontWeight = FontWeights.Bold;
                R17.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Vápník")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R15 (jsou vyznačeny červeně)";
                R15.Foreground = new SolidColorBrush(Colors.Red);
                R15.FontWeight = FontWeights.Bold;
                R15.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Stroncium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R15 (jsou vyznačeny červeně)";
                R15.Foreground = new SolidColorBrush(Colors.Red);
                R15.FontWeight = FontWeights.Bold;
                R15.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Skandium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Yttrium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Titan")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R17; R36/37/38 (jsou vyznačeny červeně)";
                R17.Foreground = new SolidColorBrush(Colors.Red);
                R17.FontWeight = FontWeights.Bold;
                R17.BorderBrush = new SolidColorBrush(Colors.Red);
                R36_37_38.Foreground = new SolidColorBrush(Colors.Red);
                R36_37_38.FontWeight = FontWeights.Bold;
                R36_37_38.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Zirkonium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R15; R17 (jsou vyznačeny červeně)";
                R15.Foreground = new SolidColorBrush(Colors.Red);
                R15.FontWeight = FontWeights.Bold;
                R15.BorderBrush = new SolidColorBrush(Colors.Red);
                R17.Foreground = new SolidColorBrush(Colors.Red);
                R17.FontWeight = FontWeights.Bold;
                R17.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Vanad")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R17; R36/37/38 (jsou vyznačeny červeně)";
                R17.Foreground = new SolidColorBrush(Colors.Red);
                R17.FontWeight = FontWeights.Bold;
                R17.BorderBrush = new SolidColorBrush(Colors.Red);
                R36_37_38.Foreground = new SolidColorBrush(Colors.Red);
                R36_37_38.FontWeight = FontWeights.Bold;
                R36_37_38.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Niob")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Tantal")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Dubnium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Chrom")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11; R40 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
                R40.Foreground = new SolidColorBrush(Colors.Red);
                R40.FontWeight = FontWeights.Bold;
                R40.BorderBrush = new SolidColorBrush(Colors.Red);


            }
            if (kodprvku == "Mangan")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Železo")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Ruthenium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            /*
            if (kodprvku == "Kobalt")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Rhodium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Iridium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Meitnerium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Nikl")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Palladium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Platina")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Darmstadtium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Měď")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Stříbro")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Zlato")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Roentgenium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Zinek")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Kadmium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Rtuť")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Kopernicium")
            {
                headline.Content = "R-věty: " + kodprvku;
                rvetyprvku.Content = "R-věty pro prvek " + kodprvku + " jsou: R11 (jsou vyznačeny červeně)";
                R11.Foreground = new SolidColorBrush(Colors.Red);
                R11.FontWeight = FontWeights.Bold;
                R11.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Bor")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "R22";
            }
            if (kodprvku == "Hliník")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;

                svety.Content = "S2; S7/8; S43";
                rvety.Content = "R10; R15; R17";
            }
            if (kodprvku == "Gallium")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                svety.Content = "S26; S36/37/39; S45";
                rvety.Content = "R34";
            }
            if (kodprvku == "Indium")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Thallium")
            {
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "S1/2; S22; S35; S45; S46; S61";
                rvety.Content = "R26; R28; R45; R50/53";
            }
            if (kodprvku == "Nihonium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Uhlík")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Křemík")
            {
                svety.Content = "S26; S36/37/39; S22";
                rvety.Content = "R36/38; R11; R36/37/38";
            }
            if (kodprvku == "Germanium")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                svety.Content = "S9; S16; S29; S33";
                rvety.Content = "R11";
            }
            if (kodprvku == "Cín")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Olovo")
            {
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                svety.Content = "S1/2; S45; S46; S61";
                rvety.Content = "R25; R45; R58; R61";
            }
            if (kodprvku == "Flerovium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Dusík")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
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
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "Červený:S2; S7; S43; S61    Bílý:S1/2; S5; S26; S38; S45; S61";
                rvety.Content = "Červený:R11; R16; R52/53    Bílý: R17; R26/28; R35; R50";
            }
            if (kodprvku == "Arsen")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "S1/2; S20/21; S28; S45; S60; S61";
                rvety.Content = "R23/25; R50/53";
            }
            if (kodprvku == "Antimon")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Bismut")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Moscovium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Kyslík")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                oxidujici.Visibility = Visibility.Visible;
                oxidujicibtn.IsEnabled = true;
                svety.Content = "S2; S17";
                rvety.Content = "R8";
            }
            if (kodprvku == "Síra")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                svety.Content = "S2; S46";
                rvety.Content = "R38";
            }
            if (kodprvku == "Selen")
            {
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "S1/2; S20/21; S28; S45; S61";
                rvety.Content = "R23/25; R33; R53";
            }
            if (kodprvku == "Tellur")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Polonium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Livermorium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Fluor")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                oxidujici.Visibility = Visibility.Visible;
                oxidujicibtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "S9; S26; S28; S36/37/39; S45";
                rvety.Content = "R8; R26; R35";
            }
            if (kodprvku == "Chlor")
            {
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                oxidujici.Visibility = Visibility.Visible;
                oxidujicibtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "S1/2; S9; S45; S61";
                rvety.Content = "R23, R36/37/38, R50";
            }
            if (kodprvku == "Brom")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
                latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                svety.Content = "S1/2; S7/9; S26; S45; S61";
                rvety.Content = "R26; R35; R50";
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
            }
            if (kodprvku == "Astat")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Tennessin")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Helium")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                rvetybtn.IsEnabled = false;
                svety.Content = "S9; S23";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Neon")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Argon")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Krypton")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Xenon")
            {
                plyn.Visibility = Visibility.Visible;
                plynbtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Radon")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Oganesson")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Lanthan")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Cer")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Praseodym")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Neodym")
            {
                nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
                nebezpeci_pro_zdravibtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Promethium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Samarium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Europium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Gadolinium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Terbium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
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
            }
            if (kodprvku == "Holmium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Erbium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
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
            }
            if (kodprvku == "Lutecium")
            {
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Aktinium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
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
            }
            if (kodprvku == "Protaktinium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Uran")
            {
                vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
                vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
                akutni_toxicita.Visibility = Visibility.Visible;
                akutni_toxicitabtn.IsEnabled = true;
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svety.Content = "S1/2; S20/21; S45; S61";
                rvety.Content = "R26/28; R33; R53";
            }
            if (kodprvku == "Neptunium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Plutonium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Americium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Curium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Berkelium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Kalifornium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Einsteinium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Fermium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Mendelevium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Nobelium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            if (kodprvku == "Lawrencium")
            {
                radiace.Visibility = Visibility.Visible;
                radiacebtn.IsEnabled = true;
                svetybtn.IsEnabled = false;
                rvetybtn.IsEnabled = false;
                svety.Content = "Neuvedeno";
                rvety.Content = "Neuvedeno";
            }
            */
            /* else
             {
                 rvetyprvku.Content = "Zde jsou vypsány všechny R-věty (angl. Risk phrases - upozorňovaly na nebezpečnost prvku). Dnes jsou nahrazeny H-větami.";
                 headline.Content = "R-věty";
             }*/

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
