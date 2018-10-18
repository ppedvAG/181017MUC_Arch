using ppedv.GoldCricket.Data.EF;
using ppedv.GoldCricket.Domain;
using ppedv.GoldCricket.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppedv.GoldCricket.UI.Konsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1) Core erstellen
            // 2) Demodaten generieren wenn die DB leer ist
            // 3) Alle Personen ausgeben 

            Core core = new Core(new EFRepository());

            if (core.Repository.GetAll<Person>().Count() == 0) // es gibt keine Personen
                core.CreateDemoData();

            foreach (Person p in core.Repository.GetAll<Person>())
            {
                Console.WriteLine($"{p.Vorname} {p.Nachname} - Alter:{p.Alter}, Kontostand: {p.Kontostand}€");
            }

            Console.WriteLine("Person mit ältester App:");
            var per = core.FindPersonWithOldestRunningApplication();
            Console.WriteLine($"{per.Vorname} {per.Nachname}");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
