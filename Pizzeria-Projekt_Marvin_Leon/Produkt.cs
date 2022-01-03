using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Projekt_Marvin_Leon
{
    class Produkt
    {
        //private double groeße;
        private String bezeichnung;

        //public double Groeße { get; set; }
        public String Bezeichnung { get; set; }

        public Produkt (String bezeichnung)
        {
            //this.groeße = groeße;
            this.bezeichnung = bezeichnung;
        }
    }
}
