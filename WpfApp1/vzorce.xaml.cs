using Chemie.vypocty;
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

namespace Chemie
{
    /// <summary>
    /// Interakční logika pro vzorce.xaml
    /// </summary>
    public partial class vzorce : Page
    {
        public vzorce()
        {
            InitializeComponent();
            fncpick.Items.Add("Hmotnostní zlomek");
            fncpick.Items.Add("Hustota nebo objem látky");
            fncpick.Items.Add("Objemový zlomek");
            fncpick.Items.Add("Látkové množství");
             fncpick.Items.Add("Molární koncentrace");
             fncpick.Items.Add("Ředění roztoků");
             fncpick.Items.Add("Chemické rovnice");
            string thmpck = Properties.Settings.Default.theme;
            if (thmpck == "Světlý")
            {
             /*   this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.Black);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.LightGray);
                this.Resources["comboboxcl"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                this.Resources["comboboxfr"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                this.Resources["arrowcl"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#e0e0e0"));
                this.Resources["arrowfl"] = new SolidColorBrush(Colors.Black);
                this.Resources["arrowmo"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#cccccc"));
                this.Resources["borderbg"] = new SolidColorBrush(Colors.Black);
                this.Resources["cbbg"] = new SolidColorBrush(Colors.White);
                this.Resources["cbfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbbg"] = new SolidColorBrush(Colors.White);
                this.Resources["tbfg"] = new SolidColorBrush(Colors.Black);
                this.Resources["cbihoverfg"] = new SolidColorBrush(Colors.LightGray); */
            }
            if (thmpck == "Tmavý")
            {
             /*   this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);
                this.Resources["comboboxcl"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#000000"));
                //this.Resources["comboboxfr"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FFFFFF"));
                this.Resources["arrowcl"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#808080"));
                this.Resources["arrowfl"] = new SolidColorBrush(Colors.White);
                this.Resources["arrowmo"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#a1a1a1"));
                this.Resources["borderbg"] = new SolidColorBrush(Colors.White);
                //this.Resources["cbbg"] = new SolidColorBrush(Colors.Black);
                this.Resources["cbfg"] = new SolidColorBrush(Colors.White);
                this.Resources["tbbg"] = new SolidColorBrush(Colors.Black);
                this.Resources["tbfg"] = new SolidColorBrush(Colors.White);
                this.Resources["cbihoverfg"] = new SolidColorBrush(Colors.Gray); */
            }
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
                if (fncpick.SelectedItem == null)
                {
                    MessageBox.Show("Vyberte prosím jednu z možností");
                }
                else
                {
                    var vybran = fncpick.SelectedItem.ToString();
                    if (vybran == "Hmotnostní zlomek")
                    {
                    vypocty.Source = new Uri("vypocty/hmzl.xaml", UriKind.Relative);
                }
                    if (vybran == "Hustota nebo objem látky")
                    {
                    vypocty.Source = new Uri("vypocty/hustota.xaml", UriKind.Relative);
                }
                    if (vybran == "Objemový zlomek")
                    {
                    vypocty.Source = new Uri("vypocty/objzl.xaml", UriKind.Relative);
                }

                   /* if (vybran == "Látkové množství")
                    {
                        hmzlomek.Visibility = Visibility.Hidden;
                        objzlmk.Visibility = Visibility.Hidden;
                        molárníkoncgrid.Visibility = Visibility.Hidden;
                        latkovemngrid.Visibility = Visibility.Visible;
                        fnctitle.Content = "Výpočet látkového množství";
                    }
                    if (vybran == "Ředění roztoků")
                    {
                        hmzlomek.Visibility = Visibility.Hidden;
                        objzlmk.Visibility = Visibility.Hidden;
                        molárníkoncgrid.Visibility = Visibility.Hidden;
                        fnctitle.Content = "Výpočet ředění roztoků";
                    }
                    if (vybran == "Chemické rovnice")
                    {
                        hmzlomek.Visibility = Visibility.Hidden;
                        objzlmk.Visibility = Visibility.Hidden;
                        molárníkoncgrid.Visibility = Visibility.Hidden;
                        fnctitle.Content = "Chemické rovnice";
                    } */ 
                    else
                    {

                    }
                }
            }
        }
    }
   
