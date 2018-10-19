using MEF_Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF_Konsole
{
    public class Program
    {


        static void Main()
        {

            var catalog = new DirectoryCatalog(".");
            var container = new CompositionContainer(catalog);

            MSPaint p = new MSPaint();
            container.ComposeParts(p);

            foreach (var item in p.alleGrafiken)
            {
                item.Zeichnen();
            }

            p.MethodeVonWoanders();

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }

    public class MSPaint
    {
        [Import("ZeichnenMethode")]
        public Action MethodeVonWoanders;

        [ImportMany(typeof(IGrafik))]
        public IGrafik[] alleGrafiken = null;
    }
}
