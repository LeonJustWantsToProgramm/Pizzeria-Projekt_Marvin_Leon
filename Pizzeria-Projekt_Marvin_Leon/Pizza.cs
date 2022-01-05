using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Projekt_Marvin_Leon
{
    class Pizza : Produkt
    {
        public List<Zutat> pizzaZutaten = new List<Zutat>();

        public Pizza(String bezeichnung, double preis, List<String> pizzaZutaten) : base(bezeichnung, preis)
        {
            foreach (String s in pizzaZutaten)
            {
                this.pizzaZutaten.Add(new Zutat(s));
            }
        }
    }
}
