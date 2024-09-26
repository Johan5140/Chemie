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
    /// Interakční logika pro svetypage.xaml
    /// </summary>
    public partial class svetypage : Page
    {
        internal string sphrasesx;
        internal string sps;
        public svetypage(string kodprvku)
        {
            InitializeComponent();
            string thmpck = Chemie.Properties.Settings.Default.theme;
            if (kodprvku != null || kodprvku != "n" || kodprvku != "")
            {
                XDocument doc = XDocument.Parse(Soubory.Resource.data);

                var result = from ele in doc.Descendants(kodprvku)
                             select new
                             {
                                 sphrases = (string)ele.Element("sphrases")
                             };

                foreach (var t in result)
                {
                    sphrasesx = t.sphrases;
                }
                if (sphrasesx != null)
                {
                    string[] sps = sphrasesx.Split(';', ' ');
                    foreach (var sx in sps)
                    {
                        string s = sx.Replace("/", "_");
                        object prvekovl = grid.FindName(s);
                        if (prvekovl is Label)
                        {
                            // Following executed if Text element was found.
                            Label selement = prvekovl as Label;
                            selement.Foreground = new SolidColorBrush(Colors.Red);
                            selement.FontWeight = FontWeights.Bold;
                            selement.BorderBrush = new SolidColorBrush(Colors.Red);
                            selement.Background = new SolidColorBrush(Colors.LightGray);
                        }
                    }
                }
            }
       }

    }
}
