using Domäne;
using System;

namespace Logik
{
    public class EinfacherRechner : IRechner
    {
        public int Calculate(Formel f)
        {
            if (f.Operator == '+')
                return f.Operand1 + f.Operand2;
            else if (f.Operator == '-')
                return f.Operand1 - f.Operand2;
            else
                throw new Exception("Operator unbekannt");
        }
    }

    public class KomplexerRechner : IRechner
    {
        public KomplexerRechner(params IRechenart[] rechenarten)
        {
            this.rechenarten = rechenarten;
        }
        private IRechenart[] rechenarten;
        public int Calculate(Formel f)
        {
            foreach (var rart in rechenarten)
            {
                if (rart.Operator == f.Operator)
                    return rart.Berechne(f.Operand1, f.Operand2);
            }
            throw new ArgumentException("Operator unbekannt");
        }
    }
}
