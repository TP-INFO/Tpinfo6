using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_22_TP6
{
    class Chevre : Animal
    {
        public override void SeRéveiller()
        {
            base.SeRéveiller();
        }
        public override void SEndormir()
        {
            base.SEndormir();
        }
        public override void Marcher()
        {
            base.Marcher();
        }
        public override void Manger()
        {
            base.Manger();
        }
        public void Beler()
        {
            Console.WriteLine("bêêêêêêê!");
        }
    }
}
