using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloDekorator
{
    class Program
    {
        static void Main(string[] args)
        {

            var lecker = new Käse(new Schinken(new Schinken(new Pizza())));

            Console.WriteLine(lecker.Text);
            Console.WriteLine(lecker.Preis);

            var mitExtraScharf = new Knoblauch(lecker);

            Console.WriteLine(mitExtraScharf.Text);
            Console.WriteLine(mitExtraScharf.Preis);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
