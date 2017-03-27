using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Abricotier : Flora
    {
        //ToDo == Personnaliser les quantités et messages

        /// <summary>
        /// Génére un nombre aléatoires de cerises sur l'arbre
        /// </summary>
        public void GenerateAbricot()
        {
            Random random = new Random();
            int abricot = random.Next(1, 100);

            if (abricot < 10)
            {
                Console.WriteLine("La récolte de l'abricotier est mauvaise .. Il n'a produit que " + abricot + " abricots cette semaine");
            }
            else if (abricot > 10 && abricot < 50)
            {
                Console.WriteLine("La récolte de l'abricotier est moyenne .. Il n'a produit que " + abricot + " abricots cette semaine..");
            }
            else if (abricot > 50 && abricot < 80)
            {
                Console.WriteLine("C'est une bonne récolte ! Vous allez pouvoir récolter " + abricot + " abricots cette semaine !\n" +
                                  "A vos fourneaux !");
            }
            else
            {
                Console.WriteLine("Quel chance !\n" +
                                  "Une récolte exceptionnel de " + abricot + " abricots s'offre à vous, bonne régalade !");
            }
        }





    }//End of Class
}
