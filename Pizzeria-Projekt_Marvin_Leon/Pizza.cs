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

        // Überlädt die ToString-Methode, um die Pizza mit allen Zutaten auszugeben, unabhängig davon wie viele Zutaten ausgewählt werden.
        public string ToString(int zutatenAnzahl)
        {
            switch (zutatenAnzahl)
            {
                case 0:
                    return string.Format("{0}", GetBezeichnung());
                case 1:
                    return string.Format("{0} mit {1}", GetBezeichnung(), pizzaZutaten[0]);
                case 2:
                    return string.Format("{0} mit {1}, {2}", GetBezeichnung(), pizzaZutaten[0], pizzaZutaten[1]);
                case 3:
                    return string.Format("{0} mit {1}, {2}, {3}", GetBezeichnung(), pizzaZutaten[0], pizzaZutaten[1], pizzaZutaten[2]);
                case 4:
                    return string.Format("{0} mit {1}, {2}, {3}, {4}", GetBezeichnung(), pizzaZutaten[0], pizzaZutaten[1], pizzaZutaten[2], pizzaZutaten[3]);
                case 5:
                    return string.Format("{0} mit {1}, {2}, {3}, {4}, {5}", GetBezeichnung(), pizzaZutaten[0], pizzaZutaten[1], pizzaZutaten[2], pizzaZutaten[3], pizzaZutaten[4]);
                case 6:
                    return string.Format("{0} mit {1}, {2}, {3}, {4}, {5}, {6}", GetBezeichnung(), pizzaZutaten[0], pizzaZutaten[1], pizzaZutaten[2], pizzaZutaten[3],
                        pizzaZutaten[4], pizzaZutaten[5]);
                case 7:
                    return string.Format("{0} mit {1}, {2}, {3}, {4}, {5}, {6}, {7}", GetBezeichnung(), pizzaZutaten[0], pizzaZutaten[1], pizzaZutaten[2], pizzaZutaten[3],
                        pizzaZutaten[4], pizzaZutaten[5], pizzaZutaten[6]);
                default:
                    return "Keine Pizza bestellt.";
            }
        }
    }
}
