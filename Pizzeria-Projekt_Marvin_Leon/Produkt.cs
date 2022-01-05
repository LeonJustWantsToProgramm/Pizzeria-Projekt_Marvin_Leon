using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Projekt_Marvin_Leon
{
    class Produkt
    {
        private String bezeichnung;
        private double preis;

        public String Bezeichnung { get; set; }
        public double Preis { get; set; }


        public Produkt(String bezeichnung, double preis)
        {
            this.bezeichnung = bezeichnung;
            this.preis = preis;
        }
    }
}
