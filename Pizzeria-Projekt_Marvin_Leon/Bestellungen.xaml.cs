using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;

namespace Pizzaria
{
    /// <summary>
    /// Interaktionslogik für Bestellungen.xaml
    /// </summary>
    public partial class Bestellungen : Window
    {
        public Bestellungen()
        {
            InitializeComponent();
            //txtEditor.Text = File.ReadAllText("Bestellungen.txt");
        }
    }
}
