﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    public class Androïde : NonVivant, ISeDeplacer
    {
        public void SeDeplacer(string destination)
        {
            Console.WriteLine("L'androïde se déplace vers {0}!", destination);
        }
    }
}
