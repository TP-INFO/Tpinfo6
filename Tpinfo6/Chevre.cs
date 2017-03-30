using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
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
        public override void SeDeplacer(string destination)
        {
            base.SeDeplacer(destination);
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
