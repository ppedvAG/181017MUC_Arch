using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloComposite
{
    class Program
    {
        static void Main(string[] args)
        {
            AufgabeListe schulung = new AufgabeListe();
            schulung.Beschreibung = ".NET Architektur-Kurs";
            AufgabeListe vormittag = new AufgabeListe();
            vormittag.Beschreibung = "Framework und Patterns";
            vormittag.AufgabeHinzufügen(new Einzelaufgabe { Beschreibung = ".NET Framework" });
            vormittag.AufgabeHinzufügen(new Einzelaufgabe { Beschreibung = " Singleton" });

            AufgabeListe nachmittag = new AufgabeListe();
            nachmittag.Beschreibung = "Patterns";
            nachmittag.AufgabeHinzufügen(new Einzelaufgabe { Beschreibung = "Builder" });
            nachmittag.AufgabeHinzufügen(new Einzelaufgabe { Beschreibung = "FactoryMethode" });

            schulung.AufgabeHinzufügen(vormittag);
            schulung.AufgabeHinzufügen(nachmittag);

            schulung.AufgabeAbarbeiten();


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
