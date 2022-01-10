using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Projekt_Marvin_Leon
{
    class Bestellung
    {
        private static int bestellungsID = 1000;
        private string bestellDatum;
        private double preis;
        public List<Produkt> bestellteProdukte;

        public string BestellDatum { get; set; }
        public double Preis { get; set; }

        public Bestellung(string bestellDatum, double preis)
        {
            bestellungsID++;
            this.bestellDatum = bestellDatum;
            this.preis = preis;
            bestellteProdukte = new List<Produkt>();
        }
    }
}
