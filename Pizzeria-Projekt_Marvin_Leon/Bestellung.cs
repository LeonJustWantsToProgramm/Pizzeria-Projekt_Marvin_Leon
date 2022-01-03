using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Projekt_Marvin_Leon
{
    class Bestellung
    {
        private static int bestellID;
        private String bestellDatum;
        private double preis;
        public List<Produkt> bestellteProdukte;

        public String BestellDatum { get; set; }
        public double Preis { get; set; }

        public Bestellung(String bestellDatum, double preis)
        {
            this.bestellDatum = bestellDatum;
            this.preis = preis;
        }
    }
}
