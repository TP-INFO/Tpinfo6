﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    public class Lune : Astre
    {
        public Lune()
        {
            
        }

        public override void SeLever()
        {
            Console.WriteLine("La lune se lève");
        }
        public override void SeCoucher()
        {
            Console.WriteLine("La lune se couche");
        }

    }
}
