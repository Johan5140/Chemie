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
    /// Interakční logika pro prevody.xaml
    /// </summary>
    public partial class prevody : Page
    {
        public prevody()
        {
            InitializeComponent();
            string thmpck = Chemie.Properties.Settings.Default.theme;
            tfncpick.SelectedValue = lenght;
            transnav.Source = new Uri("../transfer_pages/lenght.xaml", UriKind.Relative);
        }
    }
}
