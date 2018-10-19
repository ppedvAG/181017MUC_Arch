using Domäne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeFeatures
{
    public class Addition : IRechenart
    {
        public char Operator => '+';

        public int Berechne(int z1, int z2)
        {
            return z1 + z2;
        }
    }
}
