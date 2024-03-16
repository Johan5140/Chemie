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
//using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace WpfApp1
{
    /// <summary>
    /// Interakční logika pro infooprvku.xaml
    /// </summary>
    public partial class infooprvku : Window
    {
        public infooprvku(string kodprvku)
        {
            InitializeComponent();
            var xml = XDocument.Parse(Soubory.Resource.prvky);
            // Vytvoření datasetu
            DataSet dataSet = new DataSet();
            // Vložení dat do datasetu
            dataSet.ReadXml(xml.CreateReader());
            DataView dataView = new DataView(dataSet.Tables[kodprvku]);
            dataGrid1.ItemsSource = dataView;
            Headline.Content = "Informace o prvku: "+kodprvku;
            PreviewKeyDown += (s, e) => { if (e.Key == Key.Escape) this.Close(); };
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (!e.Handled && e.Key == Key.Escape && Keyboard.Modifiers == ModifierKeys.None)
            {
                this.Close();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
