using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;
using Chemie;
using WpfApp1;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string hdtext = Chemie.Properties.Settings.Default.hdtextcolor;
            if (hdtext == "Tmavý")
            {
                Headline.Foreground = new SolidColorBrush((Color)Colors.Black);

            }
            else
            {
                Headline.Foreground = new SolidColorBrush((Color)Colors.White);
            }
            string thmpck = Chemie.Properties.Settings.Default.theme;
            if (thmpck == "Světlý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.Black);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.LightGray);
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
            }
            if (thmpck == "Tmavý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);
                this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555555"));
            }
            Headline.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(Chemie.Properties.Settings.Default.head));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            aboutapp aboutappw = new aboutapp();
            aboutappw.Show();
        }

        #region Akční tlačítka pro prvky
        private void button2_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Vodík");
            info.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Lithium");
            info.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Sodík");
            info.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Draslík");
            info.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            infooprvku info = new infooprvku("Rubidium");
            info.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            infooprvku info = new infooprvku("Cesium");
            info.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            infooprvku info = new infooprvku("Francium");
            info.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            infooprvku info = new infooprvku("Beryllium");
            info.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Hořčík");
            info.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Vápník");
            info.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Stroncium");
            info.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            infooprvku info = new infooprvku("Baryum");
            info.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Radium");
            info.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Skandium");
            info.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Yttrium");
            info.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Titan");
            info.Show();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Zirkonium");
            info.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Hafnium");
            info.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Rutherfordium");
            info.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Vanad");
            info.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Niob");
            info.Show();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Tantal");
            info.Show();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Dubnium");
            info.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Chrom");
            info.Show();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Molybden");
            info.Show();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Wolfram");
            info.Show();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Seaborgium");
            info.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Mangan");
            info.Show();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Technecium");
            info.Show();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Rhenium");
            info.Show();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Bohrium");
            info.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Železo");
            info.Show();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Ruthenium");
            info.Show();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Osmium");
            info.Show();
        }

        private void button36_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Hassium");
            info.Show();
        }

        private void button37_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Kobalt");
            info.Show();
        }

        private void button38_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Rhodium");
            info.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Iridium");
            info.Show();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Meitnerium");
            info.Show();
        }

        private void button41_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Nikl");
            info.Show();
        }

        private void button42_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Palladium");
            info.Show();
        }

        private void button43_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Platina");
            info.Show();
        }

        private void button44_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Darmstadtium");
            info.Show();
        }

        private void button45_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Měď");
            info.Show();
        }

        private void button46_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Stříbro");
            info.Show();
        }

        private void button47_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Zlato");
            info.Show();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Roentgenium");
            info.Show();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Zinek");
            info.Show();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Kadmium");
            info.Show();
        }

        private void button51_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Rtuť");
            info.Show();
        }

        private void button52_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Kopernicium");
            info.Show();
        }

        private void button55_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Bor");
            info.Show();
        }

        private void button54_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Hliník");
            info.Show();
        }

        private void button53_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Gallium");
            info.Show();
        }

        private void button56_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Indium");
            info.Show();
        }

        private void button57_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Thallium");
            info.Show();
        }

        private void button58_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Nihonium");
            info.Show();
        }

        private void button59_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Uhlík");
            info.Show();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Křemík");
            info.Show();
        }

        private void button61_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Germanium");
            info.Show();
        }

        private void button62_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Cín");
            info.Show();
        }

        private void button63_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Olovo");
            info.Show();
        }

        private void button64_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Flerovium");
            info.Show();
        }

        private void button65_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Dusík");
            info.Show();
        }

        private void button66_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Fosfor");
            info.Show();
        }

        private void button67_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Arsen");
            info.Show();
        }

        private void button68_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Antimon");
            info.Show();
        }

        private void button69_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Bismut");
            info.Show();
        }

        private void button70_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Moscovium");
            info.Show();
        }

        private void button71_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Kyslík");
            info.Show();
        }

        private void button72_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Síra");
            info.Show();
        }

        private void button73_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Selen");
            info.Show();
        }

        private void button74_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Tellur");
            info.Show();
        }

        private void button75_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Polonium");
            info.Show();
        }

        private void button76_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Livermorium");
            info.Show();
        }

        private void button77_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Fluor");
            info.Show();
        }

        private void button78_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Chlor");
            info.Show();
        }

        private void button79_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Brom");
            info.Show();
        }

        private void button80_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Jod");
            info.Show();
        }

        private void button81_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Astat");
            info.Show();
        }

        private void button82_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Tennessin");
            info.Show();
        }

        private void button83_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Helium");
            info.Show();
        }

        private void button84_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Neon");
            info.Show();
        }

        private void button85_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Argon");
            info.Show();
        }

        private void button86_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Krypton");
            info.Show();
        }

        private void button87_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Xenon");
            info.Show();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Radon");
            info.Show();
        }

        private void button89_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Oganesson");
            info.Show();
        }

        private void button90_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Lanthan");
            info.Show();
        }

        private void button91_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Cer");
            info.Show();
        }

        private void button92_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Praseodym");
            info.Show();
        }

        private void button93_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Neodym");
            info.Show();
        }

        private void button94_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Promethium");
            info.Show();
        }

        private void button95_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Samarium");
            info.Show();
        }

        private void button96_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Europium");
            info.Show();
        }

        private void button97_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Gadolinium");
            info.Show();
        }

        private void button98_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Terbium");
            info.Show();
        }

        private void button99_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Dysprosium");
            info.Show();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Holmium");
            info.Show();
        }

        private void button101_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Erbium");
            info.Show();
        }

        private void button102_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Thulium");
            info.Show();
        }

        private void button103_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Ytterbium");
            info.Show();
        }

        private void button104_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Lutecium");
            info.Show();
        }

        private void button105_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Aktinium");
            info.Show();
        }

        private void button106_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Thorium");
            info.Show();
        }

        private void button107_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Protaktinium");
            info.Show();
        }

        private void button108_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Uran");
            info.Show();
        }

        private void button109_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Neptunium");
            info.Show();
        }

        private void button110_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Plutonium");
            info.Show();
        }

        private void button111_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Americium");
            info.Show();
        }

        private void button112_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Curium");
            info.Show();
        }

        private void button113_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Berkelium");
            info.Show();
        }

        private void button114_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Kalifornium");
            info.Show();
        }

        private void button115_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Einsteinium");
            info.Show();
        }

        private void button116_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Fermium");
            info.Show();
        }

        private void button117_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Mendelevium");
            info.Show();
        }

        private void button119_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Nobelium");
            info.Show();
        }

        private void button118_Click(object sender, EventArgs e)
        {
            infooprvku info = new infooprvku("Lawrencium");
            info.Show();
        }
        #endregion
        private void set_click(object sender, RoutedEventArgs e)
        {
            Nastaveni st = new Nastaveni();
            st.Show();
        }
        private void calc_click(object sender, RoutedEventArgs e)
        {
            vypocty vp = new vypocty();
            vp.Show();
        }
        private void teorie_click(object sender, RoutedEventArgs e)
        {
            System.Windows.MessageBox.Show("Funkce zatím není dostupná!");
        }
    }
}
