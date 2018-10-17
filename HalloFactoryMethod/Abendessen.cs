using System;

namespace HalloFactoryMethod
{
    class Abendessen : IEssen
    {
        public void Beschreibung()
        {
            Console.WriteLine("Kaiserschmarren mit Zwetschgenröster");
        }
    }

}
