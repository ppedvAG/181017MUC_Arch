using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloComposite
{
    abstract class Aufgabe
    {
        public string Beschreibung { get; set; }
        public bool IstErledigt { get; set; }
        public abstract void AufgabeAbarbeiten();
    }

    class Einzelaufgabe : Aufgabe
    {
        public override void AufgabeAbarbeiten()
        {
            Console.WriteLine($"{Beschreibung} --- Einzelaufgabe wird abgearbeitet ...");
        }
    }

    class AufgabeListe : Aufgabe
    {
        public List<Aufgabe> Aufgabenliste { get; set; } = new List<Aufgabe>();
        public void AufgabeHinzufügen(Aufgabe aufgabe)
        {
            // Nach validierung -> hinzufügen
            Aufgabenliste.Add(aufgabe);
        }

        public override void AufgabeAbarbeiten()
        {
            Console.WriteLine($"AufgabenListe {Beschreibung} startet das Abarbeiten");
            foreach (var item in Aufgabenliste)
            {
                item.AufgabeAbarbeiten();
            }
            Console.WriteLine($"AufgabenListe {Beschreibung} beendet das Abarbeiten");
        }
    }
}
