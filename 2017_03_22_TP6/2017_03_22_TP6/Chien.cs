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
        public override void SEndormir()
        {
            base.SEndormir();
        }
        public override void Manger()
        {
            base.Manger();
        }
        public override void Marcher()
        {
            base.Marcher();
        }
        public override void Vivre()
        {
            base.Vivre();
        }
        public override void Mourir()
        {
            base.Mourir();
        }
        public void Aboyer()
        {
            Console.WriteLine("woof!");
        }

        public void CourirApres(Chien chien, Animal animal)
        {
            Console.WriteLine("{0} court après {1}", chien.Nom, animal.Nom);
            chien.Aboyer();
            
        }
    }
}
