using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Projekt_Marvin_Leon
{
    class Produkt
    {
        private string bezeichnung;
        private double preis;

        public string GetBezeichnung()
        {
            return this.bezeichnung;
        }

        public string SetBezeichnung(string bezeichnung)
        {
            this.bezeichnung = bezeichnung;
        }

        public double GetPreis()
        {
            return this.preis;
        }

        public void SetPreis(double preis)
        {
            this.preis = preis;
        }


        public Produkt(string bezeichnung, double preis)
        {
            this.bezeichnung = bezeichnung;
            this.preis = preis;
        }
    }
}
