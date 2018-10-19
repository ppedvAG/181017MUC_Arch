using System;

namespace HalloFactoryMethod
{
    class Frühstück : IEssen
    {
        public void Beschreibung()
        {
            Console.WriteLine("Wiener Kipferl mit Marillenmarmelade");
        }
    }

}
