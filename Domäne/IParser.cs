using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domäne
{
    public interface IParser
    {
        Formel Parse(string input);
    }
}
