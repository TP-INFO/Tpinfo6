using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe couteau, fille de Nonvivant
    /// </summary>
    public class Couteau : NonVivant
    {
        //Constructeur vide
        public Couteau()
        {

        }

        //Méthode indiquant que le couteau a permis de tuer un animal passé en argument
        public void TuerAnimal(Animal a)
        {
            a.Mourir(a);
            Console.WriteLine("{0} a été tué avec le couteau !", a.Nom);
        }

        //Méthode indiquant que le couteau a permis de couper une plante
        public void CouperPlante()
        {
            Console.WriteLine("La plante a été coupée!");
        }
    }
}
