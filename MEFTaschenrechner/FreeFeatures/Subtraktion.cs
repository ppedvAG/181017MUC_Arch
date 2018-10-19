using Domäne;

namespace FreeFeatures
{
    public class Subtraktion : IRechenart
    {
        public char Operator => '-';
        // Kurzschreibweise für
        //public char Operator
        //{
        //    get
        //    {
        //        return '-';
        //    }
        //}

        public int Berechne(int z1, int z2)
        {
            return z1 - z2;
        }
    }
}
