using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_22_TP6
{
    public class Chien : Animal
    {
        public override void SeRéveiller()
        {
            base.SeRéveiller();
        }

        public void Aboyer()
        {
            Console.WriteLine("woof!");
        }
    }
}
