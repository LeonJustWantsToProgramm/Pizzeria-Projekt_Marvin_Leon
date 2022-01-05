using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Projekt_Marvin_Leon
{
    class Zutat
    {
        private string bezeichnung;

        public string GetBezeichnung()
        {
            return this.bezeichnung;
        }

        public void SetBezeichnung(string bezeichnung)
        {
            this.bezeichnung = bezeichnung
        }

        public Zutat(string bezeichnung)
        {
            this.bezeichnung = bezeichnung;
        }
    }
}
