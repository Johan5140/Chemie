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
using System.Xml.Linq;

namespace Chemie.strankyovlastnostech
{
    /// <summary>
    /// Interakční logika pro rvetypage.xaml
    /// </summary>
    public partial class rvetypage : Page
    {
        internal string rphrasesx;
        public rvetypage(string kodprvku)
        {
            InitializeComponent();
            string thmpck = Chemie.Properties.Settings.Default.theme;
            if (kodprvku != null || kodprvku != "n" || kodprvku != "")
            {
                XDocument doc = XDocument.Parse(Soubory.Resource.data);

                var result = from ele in doc.Descendants(kodprvku)
                             select new
                             {
                                 rphrases = (string)ele.Element("rphrases")
                             };

                foreach (var t in result)
                {
                    rphrasesx = t.rphrases;
                }
                if (rphrasesx != null)
                {
                    string[] sps = rphrasesx.Split(';', ' ');

                    foreach (var sx in sps)
                    {
                        string s = sx.Replace("/", "_");
                        object prvekovl = grid.FindName(s);
                        if (prvekovl is Label)
                        {
                            // Following executed if Text element was found.
                            Label relement = prvekovl as Label;
                            relement.Foreground = new SolidColorBrush(Colors.Red);
                            relement.FontWeight = FontWeights.Bold;
                            relement.BorderBrush = new SolidColorBrush(Colors.Red);
                            relement.Background = new SolidColorBrush(Colors.LightGray);
                        }
                    }
                }
            }
        }
    }
}
