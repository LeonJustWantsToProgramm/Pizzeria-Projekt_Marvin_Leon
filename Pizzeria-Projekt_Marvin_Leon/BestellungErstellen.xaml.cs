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

        // Objekt "pizza" als globale/s Variable/Objekt erstellt, um Werte in jeder Methode entnehmen zu können
        Pizza pizza;

        int anzahlZutaten;

        List<string> pizzenListe = new List<string>();
        List<string> zutatenListe = new List<string>();
        List<string> getränkeListe = new List<string>();

        // Code für den Butten Bestätigen
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            preis = 0;
            colaPreis = 0;
            fantaPreis = 0;
            spritePreis = 0;
            wasserPreis = 0;

            anzahlZutaten = 0;

            // Die Zutatenliste und Getränkeliste wird geleert um In der Textdatei später immer neue Werte zu haben
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

            // wenn der Inhalt der entsprechenden Textbox nicht 0 ist, wird das entsprechende Produkt zur Bestellung hinzugefügt
            if (tbx_pizza.Text != "0")
            {
                bestellung.bestellteProdukte.Add(pizza = new Pizza("Pizzen", pizzaPreis, zutatenListe));
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

            // Preis aller Getränke wird addiert und in eine Variable geschrieben
            double getränkePreis = colaPreis + fantaPreis + spritePreis + wasserPreis;

            // pfad auf jedem Windows PC verfügbar gemacht
            var pathWithEnv = @"%USERPROFILE%\Desktop\Bestellung.txt";
            var filePath = Environment.ExpandEnvironmentVariables(pathWithEnv); // Umgebungsvariablen können nur durch diese Zeile angesprochen werden

            // Liste Kundendetails und Gesamtliste für Ausgabe in Textdatei erstellt und Werte hinzugefügt
            List<string> kundendetails = new List<string>();
            List<string> gesamtListe = new List<string>();

            kundendetails.Add("\n\n" + date);
            kundendetails.Add(kunde.Nachname + ", " + kunde.Vorname);
            kundendetails.Add(kunde.Straße + " " + kunde.Hausnummer);
            kundendetails.Add(kunde.PLZ + " " + kunde.Stadt + "\n");

            // Die Pizza mit den verschiedenen Zutaten wird mit dem Preis der Pizzen (gerundet auf 2 Nachkommastellen) in die Pizzenliste eingefügt
            pizzenListe.Add(tbx_pizza.Text + " " + pizza.ToString(anzahlZutaten) + "\nPizzenpreis: " + Math.Round(pizzaPreis, 2) + "€\n");

            getränkeListe.Add("Getränkepreis: " + getränkePreis + "€\n");

            gesamtListe.Add("Gesamtpreis: " + preis + "€");

            // verbindet alle Listen zu einer Variable und gibt schreibt alles in die Datei Bestellung
            var allProducts = kundendetails.Concat(pizzenListe).Concat(getränkeListe).Concat(gesamtListe).ToList();
            File.AppendAllLines(filePath, allProducts);
        }

        // Preis wird durch das Checken jeder Zutat erhöht, jede gecheckte Zutat zur Zutatenliste hinzugefügt 
        // und die variable Anzahlzutaten für die ToString-Methode in der Klasse Pizza erhöht
        public void PreisEigenePizza()
        {
            if (cb_ananas.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Ananas");
                anzahlZutaten++;
            }
            if (cb_käse.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Käse");
                anzahlZutaten++;
            }
            if (cb_paprika.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Paprika");
                anzahlZutaten++;
            }
            if (cb_peperoni.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Peperoni");
                anzahlZutaten += 1;
            }
            if (cb_salami.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Salami");
                anzahlZutaten += 1;
            }
            if (cb_schinken.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Schinken");
                anzahlZutaten += 1;
            }
            if (cb_thunfisch.IsChecked == true)
            {
                preis += 1.2;
                pizzaPreis += 1.2;
                zutatenListe.Add("Thunfisch");
                anzahlZutaten += 1;
            }
        }

        // Erhöht den Preis jeder Pizza nach dem eingetragenen Wert
        public void PreisPizzen()
        {
            if (tbx_pizza.Text != "0")
            {
                int input = int.Parse(tbx_pizza.Text);
                preis += input * 5.5;
            }
        }

        // Preis der Getränke und der einzelnen Getränkesorte wird mit der Zahl in der Textbox multipliziert
        // Außerdem wird in die Getränkeliste die Anzahl der Getränke mit der Bezeichnung hinzugefügt
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

        // Code für den Butten "Aktualisieren"
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
    }
}
