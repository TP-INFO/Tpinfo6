using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe publique dindon, héritant de Animal
    /// </summary>
    public class Dindon : Animal
    {
        //Override de la méthode seréveiller
        public override void SeRéveiller()
        {
            base.SeRéveiller();
        }
        public override void SEndormir()
        {
            base.SEndormir();
        }
        public override void Manger()
        {
            base.Manger();
        }
        public override void Mourir(EtreVivant ev)
        {
            base.Mourir(ev);
        }
        //Méthode écrivant le cri du dindon
        public void Glouglouter()
        {
            Console.WriteLine("glouglou!");
        }
    }
}
