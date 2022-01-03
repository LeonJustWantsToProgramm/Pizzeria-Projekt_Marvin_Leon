using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Projekt_Marvin_Leon
{
    class Kunde
    {
        private String vorname;
        private String nachname;
        private int plz;
        private String stadt;
        private String straße;
        private String hausnummer;


        public String Vorname { get; set; }
        public String Nachname { get; set; }
        public int PLZ { get; set; }
        public String Stadt { get; set; }
        public String Straße { get; set; }
        public String Hausnummer { get; set; }

        public Kunde(string vorname, string nachname, int plz, string stadt, string straße, string hausnummer)
        {
            this.vorname = vorname;
            this.nachname = nachname;
            this.plz = plz;
            this.stadt = stadt;
            this.straße = straße;
            this.hausnummer = hausnummer;       
        }
    }
}
