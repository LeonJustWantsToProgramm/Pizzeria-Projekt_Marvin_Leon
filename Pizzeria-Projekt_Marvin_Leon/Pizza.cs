using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Projekt_Marvin_Leon
{
    class Pizza : Produkt
    {
        public List<Zutat> pizzaZutaten;

        public Pizza(String bezeichnung, double preis) : base(bezeichnung, preis)
        {
            pizzaZutaten = new List<Zutat>();
        }
    }
}
