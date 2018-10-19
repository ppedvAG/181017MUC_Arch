using Domäne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logik
{
    public class StringSplitParser : IParser
    {
        public Formel Parse(string input)
        {
            Formel f = new Formel();

            string[] formel = input.Split(); // nach leerzeichen trennen
            f.Operand1 = Convert.ToInt32(formel[0]);
            f.Operand2 = Convert.ToInt32(formel[2]);
            f.Operator = Convert.ToChar(formel[1]);

            return f;
        }
    }
}
