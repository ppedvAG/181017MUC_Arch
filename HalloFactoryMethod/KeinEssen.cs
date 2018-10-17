using System;

namespace HalloFactoryMethod
{
    class KeinEssen : IEssen
    {
        public void Beschreibung()
        {
            Console.WriteLine("*grummel....*");
        }
    }

}
