﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEF_Interfaces
{
    public interface IGrafik
    {
        int X { get; set; }
        int Y { get; set; }
        void Zeichnen();
    }
}
