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
            if (thmpck == "Světlý")
            {
                
            }
            if (thmpck == "Tmavý")
            {
                /*this.Resources["CustomLabelColor"] = new SolidColorBrush(Colors.White);
                this.Resources["ButtonsLabel"] = new SolidColorBrush(Colors.White);
                this.Resources["Buttonsback"] = new SolidColorBrush(Colors.Black);
                this.Resources["Buttonshover"] = new SolidColorBrush(Colors.DarkGray);*/
            }
        }

        private void buttonprvek_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            NavigationService.Navigate(new prvekinfo(btn.Name));

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
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage("Tato funkce ještě nebyla implementována!", "Chyba","Chyba");
        }

       private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage("Tato funkce ještě nebyla implementována!", "Chyba", "Chyba");

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage("Tato funkce ještě nebyla implementována!", "Chyba", "Chyba");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage("Tato funkce ještě nebyla implementována!", "Chyba", "Chyba");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage("Tato funkce ještě nebyla implementována!", "Chyba", "Chyba");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage("Tato funkce ještě nebyla implementována!", "Chyba", "Chyba");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage("Tato funkce ještě nebyla implementována!", "Chyba", "Chyba");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage("Tato funkce ještě nebyla implementována!", "Chyba", "Chyba");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage("Tato funkce ještě nebyla implementována!", "Chyba", "Chyba");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MainWindow win = (MainWindow)MainWindow.GetWindow(this);
            win.Showmessage("Tato funkce ještě nebyla implementována!", "Chyba", "Chyba");

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
