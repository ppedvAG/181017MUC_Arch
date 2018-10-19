using Domäne;
using FreeFeatures;
using Logik;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class Program
    {
        // Bootstrapping
        static void Main(string[] args)
        {
            var parser = new RegexParser();
            var rechner = new KomplexerRechner(new Addition(), new Subtraktion());
            new KonsolenUI(parser,rechner).Start();
        }
    }

    class KonsolenUI
    {
        public KonsolenUI(IParser parser, IRechner rechner)
        {
            this.parser = parser;
            this.rechner = rechner;
        }
        private readonly IParser parser;
        private readonly IRechner rechner;

        public void Start()
        {
            Console.WriteLine("Bitte geben Sie die Formel ein:"); // "2 + 2"
            string eingabe = Console.ReadLine();

            Formel f = parser.Parse(eingabe);
            int erg = rechner.Calculate(f);

            Console.WriteLine($"Das Ergebnis ist {erg}");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
