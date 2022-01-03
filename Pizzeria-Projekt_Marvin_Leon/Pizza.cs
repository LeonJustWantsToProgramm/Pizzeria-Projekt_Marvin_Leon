using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Projekt_Marvin_Leon
{
    class Pizza : Produkt
    {
        private String form;
        public List<Zutat> pizzaZutaten;

        public String Form { get; set; }

        public Pizza (double groeße, String bezeichnung, String form) : base (bezeichnung)
        {

        }
    }
}
