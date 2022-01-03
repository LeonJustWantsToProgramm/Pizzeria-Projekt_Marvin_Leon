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

namespace Pizzaria
{
    /// <summary>
    /// Interaktionslogik für Pizzasortiment.xaml
    /// </summary>
    public partial class Pizzasortiment : Window
    {
        public Pizzasortiment()
        {
            InitializeComponent();
            txtEditor.Text = File.ReadAllText("Pizzasortiment.txt");

        }
    }
}
