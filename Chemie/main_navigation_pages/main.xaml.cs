using Chemie;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
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
        }

        private void buttonprvek_Click(object sender, EventArgs e)
        {
            string tag = ((Button)sender).Tag.ToString();
            NavigationService.Navigate(new prvekinfo(tag));

        }
        private void ScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            ScrollViewer scrollViewer = (ScrollViewer)sender;
            if (e.Delta < 0)
            {
                scrollViewer.LineRight();
            }
            else
            {
                scrollViewer.LineLeft();
            }
            e.Handled = true;
        }
        Point oldMousePosition;
        private void grid_MouseMove(object sender, MouseEventArgs e)
        {
            Point newMousePosition = Mouse.GetPosition((Grid)sender);

            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                if (newMousePosition.Y < oldMousePosition.Y)
                    scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset + 1);
                if (newMousePosition.Y > oldMousePosition.Y)
                    scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - 1);

                if (newMousePosition.X < oldMousePosition.X)
                    scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset + 1);
                if (newMousePosition.X > oldMousePosition.X)
                    scrollViewer.ScrollToHorizontalOffset(scrollViewer.HorizontalOffset - 1);
            }
            else
            {
                oldMousePosition = newMousePosition;
            }
        }

    }
}
