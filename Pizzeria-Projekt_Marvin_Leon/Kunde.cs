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

        public String Vorname
        {
            get { return vorname; }
            set { vorname = value; }
        }
        public String Nachname
        {
            get { return nachname; }
            set { nachname = value; }
        }
        public int PLZ
        {
            get { return plz; }
            set { plz = value; }
        }
        public String Stadt
        {
            get { return stadt; }
            set { stadt = value; }
        }
        public String Straße
        {
            get { return straße; }
            set { straße = value; }
        }
        public String Hausnummer
        {
            get { return hausnummer; }
            set { hausnummer = value; }
        }


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
