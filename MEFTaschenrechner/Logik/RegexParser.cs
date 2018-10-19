using Domäne;
using System;
using System.Text.RegularExpressions;

namespace Logik
{
    public class RegexParser : IParser
    {
        public Formel Parse(string input)
        {
            Regex r = new Regex(@"(\d+)\s*(\D)\s*(\d+)");
            var result = r.Match(input);

            if (!result.Success)
                throw new FormatException("Falsches Formelformat");

            Formel f = new Formel();
            // Info: Groups[0] == Alles
            f.Operand1 = Convert.ToInt32(result.Groups[1].Value);
            f.Operator = Convert.ToChar(result.Groups[2].Value);
            f.Operand2 = Convert.ToInt32(result.Groups[3].Value);

            return f;
        }
    }
}
