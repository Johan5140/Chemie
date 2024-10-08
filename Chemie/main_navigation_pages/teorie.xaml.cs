﻿using Chemie.strankyovlastnostech;
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
    /// Interakční logika pro teorie.xaml
    /// </summary>
    public partial class teorie : Page
    {
        public teorie()
        {
            InitializeComponent();
            string thmpck = Chemie.Properties.Settings.Default.theme;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new svety("n"));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new rvety("n"));
        }
        private void radiace_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new radiace());
        }

        private void ziravina_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ziravina());
        }

        private void latky_nebezpecne_pro_ZP_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new nebezpeciZP());
        }

        private void plyn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new plyn());
        }

        private void nebezpeci_pro_zdravi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new nebezpecizdravi());
        }

        private void vybusnina_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new vybusny());
        }

        private void horlavina_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new horlavy());
        }

        private void oxidujici_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new oxidace());
        }

        private void vysoka_nebezpecnost_pro_zdravi_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new drazdivy());
        }

        private void akutni_toxicita_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new jedovaty());
        }

    }
}
