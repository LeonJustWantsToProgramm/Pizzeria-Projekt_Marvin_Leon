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

        public Pizza(string bezeichnung, double preis, List<string> pizzaZutaten) : base(bezeichnung, preis)
        {
            foreach (string s in pizzaZutaten)
            {
                this.pizzaZutaten.Add(new Zutat(s));
            }
        }
    }
}
