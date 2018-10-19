using MEF_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

namespace MeineMEF_Lib
{
    [Export(typeof(IGrafik))]
    public class Kreis : IGrafik
    {
        public int X { get; set; }
        public int Y { get; set; }

        [Export("ZeichnenMethode")]
        public void Zeichnen()
        {
            Console.WriteLine("Ein Kreis wird gezeichnet ...");
        }
    }
}
