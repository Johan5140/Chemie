using System;
using System.Collections.Generic;
using System.Data;
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
using System.Xml.Linq;

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
            // Vytvoření datasetu
            DataSet dataSet = new DataSet();
            // Vložení dat do datasetu
            dataSet.ReadXml(xml.CreateReader());
            DataView dataView = new DataView(dataSet.Tables[kodprvku]);
            dataGrid1.ItemsSource = dataView;
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
            }
            if (thmpck == "Tmavý")
            {
                this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);
                this.Resources["cellbg"] = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555555"));
                this.Resources["cellfg"] = new SolidColorBrush(Colors.White);
                //this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#555555"));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
