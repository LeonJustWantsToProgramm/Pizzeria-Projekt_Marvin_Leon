﻿using Pizzaria;
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

namespace Pizzeria_Projekt_Marvin_Leon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Getänkesortiment getränkesortiment = new Getänkesortiment();
            getränkesortiment.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Bestellungen bestellungen = new Bestellungen();
            bestellungen.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Lagerbestand lagerbestand = new Lagerbestand();
            lagerbestand.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Pizzasortiment pizzasortiment = new Pizzasortiment();
            pizzasortiment.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            BestellungErstellen bestellungErstellen = new BestellungErstellen();
            bestellungErstellen.Show();
        }

    }
}