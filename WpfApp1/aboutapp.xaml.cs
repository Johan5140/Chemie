using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Diagnostics;

namespace Chemie
{
    /// <summary>
    /// Interaction logic for aboutapp.xaml
    /// </summary>
    public partial class aboutapp : Window
    {
        public aboutapp()
        {
            InitializeComponent();
            Nameapp.Content = "Chemie";
            ver.Content = "0.2.0";
            Autor.Content = "Copyright © Johan5140 (GitHub)  2024";
            abouttext.Text = Soubory.Resource.info; 
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
