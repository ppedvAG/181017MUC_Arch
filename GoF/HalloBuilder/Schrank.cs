using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloBuilder
{

    enum Oberflächenart { Unbehandelt, Gewachst, Lackiert }

    class Schrank
    {
        private Schrank() { }

        public int AnzahlTüren { get; set; }
        public Oberflächenart Oberfläche { get; set; }
        public string Farbe { get; set; }
        public bool Metallschienen { get; set; }
        public bool Kleiderstange { get; set; }
        public int AnzahlBöden { get; set; }

        // prop + TAB + TAB
        // propfull + TAB + TAB

        public static SchrankBauer BauEinenSchrank()
        {
            return new SchrankBauer();
        }

        public class SchrankBauer
        {
            private Schrank neuerSchrank = new Schrank(); // <--- 

            public SchrankBauer MitBöden(int anzahl)
            {
                if (anzahl < 0 || anzahl > 6)
                    throw new ArgumentException("Der Schrank darf nur zwischen 0 und 6 Böden haben");

                neuerSchrank.AnzahlBöden = anzahl;
                return this; // Schrankbauer zurückgeben für die nächste Methode
            }

            public SchrankBauer MitTüren(int anzahl)
            {
                if (anzahl < 2 || anzahl > 7)
                    throw new ArgumentException("Der Schrank darf nur zwischen 2 und 7 Türen haben");

                neuerSchrank.AnzahlTüren = anzahl;
                return this; // Schrankbauer zurückgeben für die nächste Methode
            }

            public SchrankBauer MitKleiderstange(bool vorhanden)
            {
                neuerSchrank.Kleiderstange = vorhanden;
                return this;
            }
            public SchrankBauer MitMetallschienen(bool vorhanden)
            {
                neuerSchrank.Metallschienen = vorhanden;
                return this;
            }

            public SchrankBauer MitOberfläche(Oberflächenart oberfläche)
            {
                neuerSchrank.Oberfläche = oberfläche;
                return this;
            }

            public SchrankBauer MitFarbe(string farbe)
            {
                if (neuerSchrank.Oberfläche != Oberflächenart.Lackiert)
                    throw new ArgumentException("Die Farbe darf nur bei einem lackierten Schrank gesetzt werden!");

                neuerSchrank.Farbe = farbe;
                return this;
            }

            public Schrank Konstruieren()
            {
                return neuerSchrank;
            }
        }
    }
}
