using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Schrank ikeaSchrank = Schrank.BauEinenSchrank()
                                         .MitBöden(2)
                                         .MitTüren(4)
                                         .MitOberfläche(Oberflächenart.Lackiert)
                                         .MitFarbe("Blau")
                                         .Konstruieren();

            Schrank xxxLutzSchrank = Schrank.BauEinenSchrank()
                                         .MitBöden(4)
                                         .MitTüren(2)
                                         .MitMetallschienen(true)
                                         //.MitFarbe("Gelb")
                                         .Konstruieren();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
