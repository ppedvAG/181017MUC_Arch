using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logger.Instance.Log("Hallo Welt");
            //Logger.Instance.Log("Ich hab hunger ...");
            //Logger.Instance.Log("Das Wasser ist endlich da :)");

            Parallel.For(0, 10000, i => Logger.Instance.Log($"Test {i}"));

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
