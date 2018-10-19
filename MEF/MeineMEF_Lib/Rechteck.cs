using MEF_Interfaces;
using System;
using System.ComponentModel.Composition;

namespace MeineMEF_Lib
{
    [Export(typeof(IGrafik))]
    public class Rechteck : IGrafik
    {
        public int X { get; set; }
        public int Y { get; set; }

        public void Zeichnen()
        {
            Console.WriteLine("Ein Rechteck wird gezeichnet ...");
        }
    }
}
