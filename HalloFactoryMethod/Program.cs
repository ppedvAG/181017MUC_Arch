using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant schnellUndGut = new Restaurant();

            IEssen lecker = schnellUndGut.GibEssen();
            IEssen ichHabImmerNochHunger = schnellUndGut.GibEssen(new DateTime(1848, 3, 20, 20, 45, 53));

            lecker.Beschreibung();
            ichHabImmerNochHunger.Beschreibung();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }

}
