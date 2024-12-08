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
    /// Interaction logic for Phrases.xaml
    /// </summary>
    public partial class Phrases : Page
    {
        internal string sphrasesx;
        internal string cphrasesx;
        internal string s;
        internal string cs;
        public List<sphrases> srphrasesitem = new();
        public List<cphrases> crphrasesitem = new();

    public Phrases(string kodprvku, string phrases, string labelsbytag)
        {
            InitializeComponent();
            if (kodprvku != null || kodprvku != "")
            {
                XDocument doc = XDocument.Parse(Soubory.Resource.data);

                var result = from ele in doc.Descendants(kodprvku)
                             select new
                             {
                                 sphrases = (string)ele.Element("s" + phrases),
                                 cphrases = (string)ele.Element("c" + phrases),
                             };
                foreach (var t in result)
                {
                    sphrasesx = t.sphrases;
                    cphrasesx = t.cphrases;
                }
                if (sphrasesx != null || kodprvku != "")
                {
                    string[] rps = sphrasesx.Split(';', ' ');
                    rps = rps.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    rps = rps.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                    foreach (var sx in rps)
                    {
                        s = sx.Replace("/", "_");
                        string sy = (String)System.Windows.Application.Current.Resources[s];
                        srphrasesitem.Add(new sphrases() { rphrase = sy });
                        rphrasesdata.ItemsSource = srphrasesitem;
                    }
                }
                if (cphrasesx != "")
                {
                    crphrasesdata.Visibility = Visibility.Visible;
                    combinedheadline.Visibility = Visibility.Visible;
                    string[] csps = cphrasesx.Split(';', ' ');
                    csps = csps.Where(x => !string.IsNullOrEmpty(x)).ToArray();
                    csps = csps.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                    foreach (var csx in csps)
                    {
                        string cs = csx.Replace("/", "_");
                        string csy = (String)System.Windows.Application.Current.Resources[cs];
                        crphrasesitem.Add(new cphrases() { crphrase = csy });
                        crphrasesdata.ItemsSource = crphrasesitem;
                    }
                }
                if (kodprvku != "n")
                {
                    ttpbtn.Visibility = Visibility.Hidden;
                    // Assuming itemsControl is your ItemsControl instance
                    //var labels = VisualTreeHelperExtensions.FindVisualChildren<Label>(rphrasesdata).ToList();

                 /*   foreach (var label in labels)
                    {
                        // Do something with each label, e.g., change text or style
                        label.Content = "Updated Text";
                        label.Background = new SolidColorBrush(Colors.Gray);
                    }*/

                }
            }
            if (kodprvku == "n")
            {
                headline.Content = Application.Current.Resources[phrases];
            }
            else
            {
                headline.Content = Application.Current.Resources[phrases + "for"] + " " + Application.Current.Resources[kodprvku];
            }
            Loaded += OnLoaded;

        }
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            /*var lbls = FindVisualChild<Label>(rphrasesdata);
            foreach (var lbl in lbls)
            {
                lbl.Background = new SolidColorBrush(Colors.Gray);
            }*/
            // Assuming itemsControl is your ItemsControl instance
            var labels = VisualTreeHelperExtensions.FindVisualChildren<Label>(rphrasesdata);

            foreach (var label in labels)
            {
                // Do something with each label, e.g., change text or style
                var brush = new SolidColorBrush(Color.FromArgb(255, (byte)252, (byte)111, (byte)119));
                label.Foreground = brush;
                //label.Background = new SolidColorBrush(Colors.LightGray);
                label.FontWeight = FontWeights.Bold;
            }
            var labels2 = VisualTreeHelperExtensions.FindVisualChildren<Label>(crphrasesdata);

            foreach (var labelx in labels2)
            {
                // Do something with each label, e.g., change text or style
                var brush = new SolidColorBrush(Color.FromArgb(255, (byte)252, (byte)111, (byte)119));
                labelx.Foreground = brush;
                //label.Background = new SolidColorBrush(Colors.LightGray);
                labelx.FontWeight = FontWeights.Bold;
            }

        }

        public static class VisualTreeHelperExtensions
    {
            public static List<Label> FindVisualChildren<Label>(DependencyObject depObj) where Label : DependencyObject
            {
                var children = new List<Label>();
                if (depObj == null) return children;

                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is Label)
                    {
                        children.Add((Label)child);
                    }
                    children.AddRange(FindVisualChildren<Label>(child));
                }

                return children;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        private void Ttp_Click(object sender, RoutedEventArgs e)
        {
            scrlv1.ScrollToTop();
        }
    }





    public class sphrases
    {
        public string rphrase { get; set; }
    }
    public class cphrases
    {
        public string crphrase { get; set; }
    }
}
