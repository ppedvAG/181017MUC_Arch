using System;

namespace HalloFactoryMethod
{
    class Mittagessen : IEssen
    {
        public void Beschreibung()
        {
            Console.WriteLine("Wiener Schnitzel mit Erdäpfelsalat");
        }
    }

}
