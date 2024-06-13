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
    /// Interakční logika pro svety.xaml
    /// </summary>
    public partial class svety : Page
    {
        public svety(string kodprvku)
        {
            InitializeComponent();
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

            if (kodprvku == "")
            {
                svetyprvku.Text = "Zde jsou vypsány všechny S-věty (angl. Safety advice - bezpečnostní pokyny pro nakládání s nebezpečnými chemickými látkami). Dnes jsou nahrazeny P-větami.";
                headline.Content = "S-věty";
            }
            if (kodprvku == "Vodík")
            {
                headline.Content = "S-věty: " + kodprvku;
                svetyprvku.Text = "S-věty pro prvek "+ kodprvku +" jsou: S2; S9; S16; S33 (jsou vyznačeny červeně)";
                S2.Foreground = new SolidColorBrush(Colors.Red);
                S2.FontWeight = FontWeights.Bold;
                S2.BorderBrush = new SolidColorBrush(Colors.Red);
                S9.Foreground = new SolidColorBrush(Colors.Red);
                S9.FontWeight = FontWeights.Bold;
                S9.BorderBrush = new SolidColorBrush(Colors.Red);
                S16.Foreground = new SolidColorBrush(Colors.Red);
                S16.FontWeight = FontWeights.Bold;
                S16.BorderBrush = new SolidColorBrush(Colors.Red);
                S33.Foreground = new SolidColorBrush(Colors.Red);
                S33.FontWeight = FontWeights.Bold;
                S33.BorderBrush = new SolidColorBrush(Colors.Red);
            }
            if (kodprvku == "Lithium")
            {
                 svetyprvku.Text = "S-věty pro prvek "+ kodprvku + " jsou: S1/2; S8; S43; S45 (jsou vyznačeny červeně)";
                S1_2.Foreground = new SolidColorBrush(Colors.Red);
                S1_2.FontWeight = FontWeights.Bold;
                S1_2.BorderBrush = new SolidColorBrush(Colors.Red);
                S8.Foreground = new SolidColorBrush(Colors.Red);
                S8.FontWeight = FontWeights.Bold;
                S8.BorderBrush = new SolidColorBrush(Colors.Red);
                S43.Foreground = new SolidColorBrush(Colors.Red);
                S43.FontWeight = FontWeights.Bold;
                S43.BorderBrush = new SolidColorBrush(Colors.Red);
                S45.Foreground = new SolidColorBrush(Colors.Red);
                S45.FontWeight = FontWeights.Bold;
                S45.BorderBrush = new SolidColorBrush(Colors.Red);
            }/*
            if (kodprvku == "Sodík")
            {
                svetyprvku.Content = "S-věty pro prvek "+ kodprvku + " jsou: S1/2, S8, S43, S45";
                S1_2.Foreground = new SolidColorBrush(Colors.Red);
                S1_2.FontWeight = FontWeights.Bold;
                S8.Foreground = new SolidColorBrush(Colors.Red);
                S8.FontWeight = FontWeights.Bold;
                S43.Foreground = new SolidColorBrush(Colors.Red);
                S43.FontWeight = FontWeights.Bold;
                S45.Foreground = new SolidColorBrush(Colors.Red);
                S45.FontWeight = FontWeights.Bold;
            }
            if (kodprvku == "Draslík")
            {
                svetyprvku.Content = "S-věty pro prvek "+ kodprvku + " jsou: S1/2, S8, S43, S45";
                S1_2.Foreground = new SolidColorBrush(Colors.Red);
                S1_2.FontWeight = FontWeights.Bold;
                S8.Foreground = new SolidColorBrush(Colors.Red);
                S8.FontWeight = FontWeights.Bold;
                S43.Foreground = new SolidColorBrush(Colors.Red);
                S43.FontWeight = FontWeights.Bold;
                S45.Foreground = new SolidColorBrush(Colors.Red);
                S45.FontWeight = FontWeights.Bold;
        }
            if (kodprvku == "Rubidium")
            {
                ziravina.Visibility = Visibility.Visible;
                ziravinabtn.IsEnabled = true;
                horlavina.Visibility = Visibility.Visible;
                horlavinabtn.IsEnabled = true;
                svety.Content = "S7/8; S20; S26; S30; S33; S36/37/39; S43; S45";
                rvety.Content = "R14/15; R34";
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
            }
if (kodprvku == "Francium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Beryllium")
{
    nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
    nebezpeci_pro_zdravibtn.IsEnabled = true;
    vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
    vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
    akutni_toxicita.Visibility = Visibility.Visible;
    akutni_toxicitabtn.IsEnabled = true;
    svety.Content = "S53; S45";
}
if (kodprvku == "Hořčík")
{
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S2; S7/8; S43";
    rvety.Content = "R11; R15; R17";
}
if (kodprvku == "Vápník")
{
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S2; S8; S24/25; S43";
    rvety.Content = "R15";
}
if (kodprvku == "Stroncium")
{
    ziravina.Visibility = Visibility.Visible;
    ziravinabtn.IsEnabled = true;
    nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
    nebezpeci_pro_zdravibtn.IsEnabled = true;
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S8; S24/25; S43";
    rvety.Content = "R15";
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
}
if (kodprvku == "Radium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Skandium")
{
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S16; S43";
    rvety.Content = "R11";
}
if (kodprvku == "Yttrium")
{
    nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
    nebezpeci_pro_zdravibtn.IsEnabled = true;
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S7/9; S16; S33";
    rvety.Content = "R11";
}
if (kodprvku == "Titan")
{
    nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
    nebezpeci_pro_zdravibtn.IsEnabled = true;
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S26";
    rvety.Content = "R17; R36/37/38";
}
if (kodprvku == "Zirkonium")
{
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S2; S7/8; S43";
    rvety.Content = "R15; R17";
}
if (kodprvku == "Hafnium")
{
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Rutherfordium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Vanad")
{
    svety.Content = "S7; S26; S33; S37; S43; S60";
    rvety.Content = "R17; R36/37/38";
}
if (kodprvku == "Niob")
{
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S43";
    rvety.Content = "R11";
}
if (kodprvku == "Tantal")
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
if (kodprvku == "Dubnium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
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

}
if (kodprvku == "Molybden")
{
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
    vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Wolfram")
{
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Seaborgium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Mangan")
{
    latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
    latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
    nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
    nebezpeci_pro_zdravibtn.IsEnabled = true;
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S7; S33; S43; S60";
    rvety.Content = "R11";
}
if (kodprvku == "Technecium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Rhenium")
{
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Bohrium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Železo")
{
    nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
    nebezpeci_pro_zdravibtn.IsEnabled = true;
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S53; S45; S60; S61";
    rvety.Content = "R11";
}
if (kodprvku == "Ruthenium")
{
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S16; S22; S24/25";
    rvety.Content = "R11";
}
if (kodprvku == "Osmium")
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
}
if (kodprvku == "Hassium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Kobalt")
{
    nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
    nebezpeci_pro_zdravibtn.IsEnabled = true;
    vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
    vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
    svety.Content = "S2; S22; S24; S37; S61";
    rvety.Content = "R42/43; R53";
}
if (kodprvku == "Rhodium")
{
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S16; S22; S24/25";
    rvety.Content = "R11";
}
if (kodprvku == "Iridium")
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
if (kodprvku == "Meitnerium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Nikl")
{
    nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
    nebezpeci_pro_zdravibtn.IsEnabled = true;
    vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
    vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;

    svety.Content = "S2; S36/37/39; S45; S61";
    rvety.Content = "R40; R43; R48/23; R52/53";
}
if (kodprvku == "Palladium")
{
    nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
    nebezpeci_pro_zdravibtn.IsEnabled = true;
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S7/9; S16; S26; S36";
    rvety.Content = "R11; R36/37/38";
}
if (kodprvku == "Platina")
{
    nebezpeci_pro_zdravi.Visibility = Visibility.Visible;
    nebezpeci_pro_zdravibtn.IsEnabled = true;
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    oxidujici.Visibility = Visibility.Visible;
    oxidujicibtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Darmstadtium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Měď")
{
    latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
    latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Stříbro")
{
    latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
    latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Zlato")
{
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Roentgenium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
}
if (kodprvku == "Zinek")
{
    latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
    latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    svety.Content = "S2; S43; S46; S60; S61";
    rvety.Content = "R15; R17; R50/53";
}
if (kodprvku == "Kadmium")
{
    latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
    latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
    horlavina.Visibility = Visibility.Visible;
    horlavinabtn.IsEnabled = true;
    vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
    vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
    akutni_toxicita.Visibility = Visibility.Visible;
    akutni_toxicitabtn.IsEnabled = true;

    svety.Content = "S1/2; S22; S35; S45; S46; S61";
    rvety.Content = "R23; R25; R33; R45; R50/53";
}
if (kodprvku == "Rtuť")
{
    latky_nebezpecne_pro_ZP.Visibility = Visibility.Visible;
    latky_nebezpecne_pro_ZPbtn.IsEnabled = true;
    vysoka_nebezpecnost_pro_zdravi.Visibility = Visibility.Visible;
    vysoka_nebezpecnost_pro_zdravibtn.IsEnabled = true;
    akutni_toxicita.Visibility = Visibility.Visible;
    akutni_toxicitabtn.IsEnabled = true;
    svety.Content = "S53; S45; S60; S61";
    rvety.Content = "R61; R26; R48/23; R50/53";
}
if (kodprvku == "Kopernicium")
{
    radiace.Visibility = Visibility.Visible;
    radiacebtn.IsEnabled = true;
    svetybtn.IsEnabled = false;
    rvetybtn.IsEnabled = false;
    svety.Content = "Neuvedeno";
    rvety.Content = "Neuvedeno";
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
