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

namespace Pizzeria_Projekt_Marvin_Leon
{
    /// <summary>
    /// Interaktionslogik für BestellungErstellen.xaml
    /// </summary>
    public partial class BestellungErstellen : Window
    {
        public BestellungErstellen()
        {
            InitializeComponent();

            tbx_cola.Text = "0";
            tbx_fanta.Text = "0";
            tbx_sprite.Text = "0";
            tbx_wasser.Text = "0";
            tbx_pizza.Text = "0";
        }
        double preis = 0;
        double pizzaPreis = 5.5;
        double colaPreis = 0;
        double fantaPreis = 0;
        double spritePreis = 0;
        double wasserPreis = 0;

        List<String> zutatenListe = new List<String>();


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            colaPreis = 0;
            fantaPreis = 0;
            spritePreis = 0;
            wasserPreis = 0;


            string vorname = tb_vorname.ToString();
            string nachname = tb_nachname.ToString();
            string straße = tb_straße.ToString();
            string hausnummer = tb_hausnummer.ToString();
            int plz = Convert.ToInt32(tb_plz.Text);
            string stadt = tb_stadt.ToString();
            string date = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");


            Kunde kunde = new Kunde(vorname, nachname, plz, stadt, straße, hausnummer);

            preisEigenePizza();
            preisPizzen();
            preisGetränke();

            Bestellung bestellung = new Bestellung(date, preis);

            if (tbx_pizza.Text != "0")
            {
                bestellung.bestellteProdukte.Add(new Pizza("Pizza", pizzaPreis, zutatenListe));
            }
            if (tbx_cola.Text != "0")
            {
                bestellung.bestellteProdukte.Add(new Getraenk("Cola", colaPreis));
            }
            if (tbx_fanta.Text != "0")
            {
                bestellung.bestellteProdukte.Add(new Getraenk("Fanta", fantaPreis));
            }
            if (tbx_sprite.Text != "0")
            {
                bestellung.bestellteProdukte.Add(new Getraenk("sprite", spritePreis));
            }
            if (tbx_wasser.Text != "0")
            {
                bestellung.bestellteProdukte.Add(new Getraenk("Wasser", wasserPreis));
            }

        }

        public void preisEigenePizza()
        {
            if (cb_ananas.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Ananas");
            }
            if (cb_käse.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Käse");
            }
            if (cb_paprika.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Paprika");
            }
            if (cb_peperoni.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Peperoni");
            }
            if (cb_salami.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Salami");
            }
            if (cb_schinken.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Schinken");
            }
            if (cb_thunfisch.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Thunfisch");
            }
        }

        public void preisPizzen()
        {
            if (tbx_pizza.ToString() != "0")
            {
                int input = int.Parse(tbx_pizza.Text);
                preis += input * 5.5;
            }
        }

        public void preisGetränke()
        {
            if (tbx_cola.ToString() != "0")
            {
                int input = int.Parse(tbx_cola.Text);
                preis += input * 2.5;
                colaPreis += input * 2.5;
            }
            if (tbx_fanta.ToString() != "0")
            {
                int input = int.Parse(tbx_fanta.Text);
                preis += input * 2.5;
                fantaPreis += input * 2.5;
            }
            if (tbx_sprite.ToString() != "0")
            {
                int input = int.Parse(tbx_sprite.Text);
                preis += input * 2.5;
                spritePreis += input * 2.5;
            }
            if (tbx_wasser.ToString() != "0")
            {
                int input = int.Parse(tbx_wasser.Text);
                preis += input * 1.5;
                wasserPreis += input * 2.5;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            preis = 0;
            preisEigenePizza();
            preisPizzen();
            preisGetränke();

            string text = preis.ToString();
            tbx_gesamtpreis.Content = text + "€";
        }

        private void cb_salami_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
