using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gewinnspiel.Classes
{
    public class Teilnehmer
    {
        //Objektvariablen
        private int teilnehmerID;
        private string vorname;
        private string nachname;
        private DateTime gebDatum;
        private char geschlecht;
        private string email;
        private string passwort;
        private bool deaktiviert;
        private bool admin;
        private int anzahlSpiele;

        //Klassenvariablen
        private static int autonum = 1001;
        private static int anzahl;

        //Konstruktor
        public Teilnehmer()
        {
            //kann ich so machen vorausgesetzt ich erlaube das Löschen von Teilnehmern NICHT!!!
            //wenn löschen möglich sein soll, dann muss ich nach dem Deserialisieren die höchse ID rausfinden
            //und dann +1 in der autonum speichern
            //wir wollen keine Teilnehmer löschen, sondern diese nur inaktiv setzer
            teilnehmerID = autonum;
            autonum++;
            anzahl++;
        }

        public Teilnehmer(string vorname, string nachname, DateTime gebDatum, char geschlecht, string email, string passwort, bool deaktiviert, bool admin, int anzahlSpiele)
        {
            teilnehmerID = autonum;
            autonum++;
            this.vorname = vorname;
            this.nachname = nachname;
            this.gebDatum = gebDatum;
            this.geschlecht = geschlecht;
            this.email = email;
            this.passwort = passwort;
            this.deaktiviert = deaktiviert;
            this.admin = admin;
            this.anzahlSpiele = anzahlSpiele;
            anzahl++;
        }

        //Properties
        public int TeilnehmerID
        { get { return teilnehmerID; }
          set { teilnehmerID = value; }
        }

        public string Vorname { get; set; }

        public string Nachname { get; set; }

        public DateTime GebDatum { get; set; }

        public char Geschlecht { get; set; }

        public string Email { get; set; }

        public string Passwort { get; set; }

        public bool Deaktiviert { get; set; }

        public bool Admin { get; set; }

        public int AnzahlSpiele { get; set; }


        public static int Autonum
        {
            get { return autonum; }
            set { autonum = value; }
        }

        public static int Anzahl { get; set; }


        public override string ToString()
        {
            return teilnehmerID +" "+ vorname +" "+ nachname +" "+ gebDatum +" "+ geschlecht +" "+ email +" "+passwort +" "+ deaktiviert +" "+ admin +" "+ anzahlSpiele;
        }
    }
}
