using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Projekt_Marvin_Leon
{
    class Getraenk : Produkt
    {
        private double groeße;
        private String name;

        public double Groeße { get; set; }
        public String Name { get; set; }

        public Getraenk(String name, double groeße, String bezeichnung)
            : base(bezeichnung)
        {
            this.name = name;
            this.groeße = groeße;
        }


    }
}
