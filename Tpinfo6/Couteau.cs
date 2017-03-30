using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_22_TP6
{
    class Couteau : NonVivant
    {
        public Couteau()
        {

        }

        public void TuerAnimal(Animal a)
        {
            a.Mourir();
            Console.WriteLine("{0} a été tué avec le couteau !", a.Nom);
        }
        public void CouperPlante()
        {
            Console.WriteLine("La plante a été coupée!");
        }
    }
}
