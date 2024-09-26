using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chemie.vypocty
{
    /// <summary>
    /// Interakční logika pro hmzl.xaml
    /// </summary>
    public partial class hmzl : Page
    {
        public hmzl()
        {
            InitializeComponent();
            string thmpck = Properties.Settings.Default.theme;

        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            try
            {
                decimal.TryParse(tb3.Text, out var v1);
                decimal.TryParse(tb4.Text, out var v2);
                decimal c = v1 / v2;
                mlatky.Content = v1.ToString();
                mroztokulb.Content = v2.ToString();
                string output = string.Format("{0:#,##0.0000}", c);
                decimalnumlab.Content = output;
                decimal d = c * 100;
                string output1 = string.Format("{0:#,##0.00}", d);
                percentnumlab.Content = output1 + "%";
            }
            catch (DivideByZeroException)
            {
                MainWindow win = (MainWindow)MainWindow.GetWindow(this);
                win.Showmessage("Nulou nelze dělit! Zkontrolujte si prosím hodnoty!", "Chyba", "Chyba");
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (tb1.Text == "" && tb2.Text == "")
            {
                MainWindow win = (MainWindow)MainWindow.GetWindow(this);
                win.Showmessage("Zadejte prosím hodnoty!", "Chyba", "Chyba");
            }
            if (tb1.Text != "" && tb2.Text != "")
            {
                decimal.TryParse(tb1.Text, out var v3);
                decimal.TryParse(tb2.Text, out var v4);
                decimal a = v3 + v4;
                string b = string.Format("{0:#,##0.00}", a);
                decimal.TryParse(tb1.Text, out var g);
                string v = g.ToString();
                mroztoku.Content = b;
                tb4.Text = b;
                tb3.Text = v;
                Button_Click_1(sender, e);
            }
        }
    }
}
