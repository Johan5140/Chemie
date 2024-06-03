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
using WpfApp1;

namespace Chemie
{
    /// <summary>
    /// Interakční logika pro main.xaml
    /// </summary>
    public partial class main : Page
    {
        public main()
        {
            InitializeComponent();
            string thmpck = Chemie.Properties.Settings.Default.theme;
            string bgenabled = Chemie.Properties.Settings.Default.background;
            if (thmpck == "Světlý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.Black);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.LightGray);
            }
            if (thmpck == "Tmavý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            aboutapp aboutappw = new aboutapp();
            aboutappw.Show();
        }

        #region Akční tlačítka pro prvky
        private void button2_Click(object sender, EventArgs e)
        {

            NavigationService.Navigate(new prvekinfo("Vodík"));

        }
        private void button3_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Lithium"));
        }
        private void button4_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Sodík"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Draslík"));
        }

        private void button6_Click(object sender, EventArgs e)
        {

            NavigationService.Navigate(new prvekinfo("Rubidium"));
        }

        private void button7_Click(object sender, EventArgs e)
        {

            NavigationService.Navigate(new prvekinfo("Cesium"));
        }

        private void button8_Click(object sender, EventArgs e)
        {

            NavigationService.Navigate(new prvekinfo("Francium"));
        }

        private void button9_Click(object sender, EventArgs e)
        {

            NavigationService.Navigate(new prvekinfo("Beryllium"));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Hořčík"));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Vápník"));
        }

        private void button12_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Stroncium"));
        }

        private void button13_Click(object sender, EventArgs e)
        {

            NavigationService.Navigate(new prvekinfo("Baryum"));
        }

        private void button14_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Radium"));
        }

        private void button15_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Skandium"));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Yttrium"));
        }

        private void button17_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Titan"));
        }

        private void button18_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Zirkonium"));
        }

        private void button19_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Hafnium"));
        }

        private void button20_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Rutherfordium"));
        }

        private void button21_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Vanad"));
        }

        private void button22_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Niob"));
        }

        private void button23_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Tantal"));
        }

        private void button24_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Dubnium"));
        }

        private void button25_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Chrom"));
        }

        private void button26_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Molybden"));
        }

        private void button27_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Wolfram"));
        }

        private void button28_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Seaborgium"));
        }

        private void button29_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Mangan"));
        }

        private void button30_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Technecium"));
        }

        private void button31_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Rhenium"));
        }

        private void button32_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Bohrium"));
        }

        private void button33_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Železo"));
        }

        private void button34_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Ruthenium"));
        }

        private void button35_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Osmium"));
        }

        private void button36_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Hassium"));
        }

        private void button37_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Kobalt"));
        }

        private void button38_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Rhodium"));
        }

        private void button39_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Iridium"));
        }

        private void button40_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Meitnerium"));
        }

        private void button41_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Nikl"));
        }

        private void button42_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Palladium"));
        }

        private void button43_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Platina"));
        }

        private void button44_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Darmstadtium"));
        }

        private void button45_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Měď"));
        }

        private void button46_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Stříbro"));
        }

        private void button47_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Zlato"));
        }

        private void button48_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Roentgenium"));
        }

        private void button49_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Zinek"));
        }

        private void button50_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Kadmium"));
        }

        private void button51_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Rtuť"));
        }

        private void button52_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Kopernicium"));
        }

        private void button55_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Bor"));
        }

        private void button54_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Hliník"));
        }

        private void button53_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Gallium"));
        }

        private void button56_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Indium"));
        }

        private void button57_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Thallium"));
        }

        private void button58_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Nihonium"));
        }

        private void button59_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Uhlík"));
        }

        private void button60_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Křemík"));
        }

        private void button61_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Germanium"));
        }

        private void button62_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Cín"));
        }

        private void button63_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Olovo"));
        }

        private void button64_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Flerovium"));
        }

        private void button65_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Dusík"));
        }

        private void button66_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Fosfor"));
        }

        private void button67_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Arsen"));
        }

        private void button68_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Antimon"));
        }

        private void button69_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Bismut"));
        }

        private void button70_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Moscovium"));
        }

        private void button71_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Kyslík"));
        }

        private void button72_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Síra"));
        }

        private void button73_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Selen"));
        }

        private void button74_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Tellur"));
        }

        private void button75_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Polonium"));
        }

        private void button76_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Livermorium"));
        }

        private void button77_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Fluor"));
        }

        private void button78_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Chlor"));
        }

        private void button79_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Brom"));
        }

        private void button80_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Jod"));
        }

        private void button81_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Astat"));
        }

        private void button82_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Tennessin"));
        }

        private void button83_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Helium"));
        }

        private void button84_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Neon"));
        }

        private void button85_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Argon"));
        }

        private void button86_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Krypton"));
        }

        private void button87_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Xenon"));
        }

        private void button88_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Radon"));
        }

        private void button89_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Oganesson"));
        }

        private void button90_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Lanthan"));
        }

        private void button91_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Cer"));
        }

        private void button92_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Praseodym"));
        }

        private void button93_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Neodym"));
        }

        private void button94_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Promethium"));
        }

        private void button95_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Samarium"));
        }

        private void button96_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Europium"));
        }

        private void button97_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Gadolinium"));
        }

        private void button98_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Terbium"));
        }

        private void button99_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Dysprosium"));
        }

        private void button100_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Holmium"));
        }

        private void button101_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Erbium"));
        }

        private void button102_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Thulium"));
        }

        private void button103_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Ytterbium"));
        }

        private void button104_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Lutecium"));
        }

        private void button105_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Aktinium"));
        }

        private void button106_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Thorium"));
        }

        private void button107_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Protaktinium"));
        }

        private void button108_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Uran"));
        }

        private void button109_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Neptunium"));
        }

        private void button110_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Plutonium"));
        }

        private void button111_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Americium"));
        }

        private void button112_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Curium"));
        }

        private void button113_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Berkelium"));
        }

        private void button114_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Kalifornium"));
        }

        private void button115_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Einsteinium"));
        }

        private void button116_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Fermium"));
        }

        private void button117_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Mendelevium"));
        }

        private void button119_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Nobelium"));
        }

        private void button118_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new prvekinfo("Lawrencium"));
        }
        #endregion
    }
}
