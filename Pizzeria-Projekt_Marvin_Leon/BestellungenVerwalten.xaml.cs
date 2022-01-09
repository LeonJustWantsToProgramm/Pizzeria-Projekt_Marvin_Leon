using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace Pizzeria_Projekt_Marvin_Leon
{
    /// <summary>
    /// Interaktionslogik für BestellungenVerwalten.xaml
    /// </summary>
    public partial class BestellungenVerwalten : Window
    {

        public BestellungenVerwalten()
        {
            InitializeComponent();

            var pathWithEnv = @"%USERPROFILE%\Desktop\Bestellung.txt";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);

            txtEditor.Text = File.ReadAllText(filePath);
        }
    }
}
