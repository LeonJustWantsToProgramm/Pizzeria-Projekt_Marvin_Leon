using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        Pizza pizza;

        int anzahlZutaten = 0;

        List<String> zutatenListe = new List<String>();
        List<String> getränkeListe = new List<string>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            preis = 0;
            colaPreis = 0;
            fantaPreis = 0;
            spritePreis = 0;
            wasserPreis = 0;

            zutatenListe.Clear();
            getränkeListe.Clear();

            string vorname = tb_vorname.Text;
            string nachname = tb_nachname.Text;
            string straße = tb_straße.Text;
            string hausnummer = tb_hausnummer.Text;
            int plz = Convert.ToInt32(tb_plz.Text);
            string stadt = tb_stadt.Text;
            string date = DateTime.Now.ToString("dd/MM/yyyy h:mm tt");

            Kunde kunde = new Kunde(vorname, nachname, plz, stadt, straße, hausnummer);

            PreisEigenePizza();
            PreisPizzen();
            PreisGetränke();

            Bestellung bestellung = new Bestellung(date, preis);

            if (tbx_pizza.Text != "0")
            {
                bestellung.bestellteProdukte.Add(pizza = new Pizza("Pizza", pizzaPreis, zutatenListe));
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

            double getränkepreis = colaPreis + fantaPreis + spritePreis + wasserPreis;

            var stringList = pizza.ToString(anzahlZutaten).OfType<string>();

            // pfad auf jedem Windows PC verfügbar gemacht
            var pathWithEnv = @"%USERPROFILE%\Desktop\DateiTest.txt";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv);

            List<String> ausgabeListe = stringList.Distinct().ToList();
            List<String> kundendeteils = new List<String>();

            kundendeteils.Add(date);
            kundendeteils.Add(nachname + ", " + vorname);
            kundendeteils.Add(straße + ", " + hausnummer);
            kundendeteils.Add(plz + " " + stadt);
            kundendeteils.Add("Gesamtpreis: " + preis + "€");
            getränkeListe.Add("Getränkepreis: " + getränkepreis + "€");

            zutatenListe.Add(tbx_pizza.Text + " x Pizza mit:");

            ausgabeListe.Sort();
            var allProducts = kundendeteils.Concat(zutatenListe).Concat(getränkeListe).ToList();
            File.WriteAllLines(filePath, allProducts);

        }

        public void PreisEigenePizza()
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

        public void PreisPizzen()
        {
            if (tbx_pizza.Text != "0")
            {
                int input = int.Parse(tbx_pizza.Text);
                preis += input * 5.5;
            }
        }

        public void PreisGetränke()
        {
            if (tbx_cola.Text != "0")
            {
                int input = int.Parse(tbx_cola.Text);
                preis += input * 2.5;
                colaPreis += input * 2.5;
                getränkeListe.Add(tbx_cola.Text + " x " + "Cola");

            }
            if (tbx_fanta.Text != "0")
            {
                int input = int.Parse(tbx_fanta.Text);
                preis += input * 2.5;
                fantaPreis += input * 2.5;
                getränkeListe.Add(tbx_fanta.Text + " x " + "Fanta");
            }
            if (tbx_sprite.Text != "0")
            {
                int input = int.Parse(tbx_sprite.Text);
                preis += input * 2.5;
                spritePreis += input * 2.5;
                getränkeListe.Add(tbx_sprite.Text + " x " + "Sprite");
            }
            if (tbx_wasser.Text != "0")
            {
                int input = int.Parse(tbx_wasser.Text);
                preis += input * 1.5;
                wasserPreis += input * 2.5;
                getränkeListe.Add(tbx_wasser.Text + " x " + "Wasser");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            preis = 0;
            PreisEigenePizza();
            PreisPizzen();
            PreisGetränke();
            if (tbx_pizza.Text == "0")
            {
                lbl_textMessage.Content = "Bitte wählen Sie mindestens eine Pizza aus.";
            }
            else
            {
                lbl_textMessage.Content = "";
                preisanzeigeAktuallisieren();
            }
        }

        public void preisanzeigeAktuallisieren()
        {
            string text = preis.ToString();
            tbx_gesamtpreis.Content = text + "€";
        }

        public void AusgabeInTextdatei()
        {

        }


    }
}
