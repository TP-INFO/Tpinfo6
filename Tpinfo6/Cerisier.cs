using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Cerisier : Flora
    {

       /*──────────────────|
       |      Méthodes     |
       |──────────────────*/

        /// <summary>
        /// Génére un nombre aléatoires de cerises sur l'arbre
        /// </summary>
        public void GenerateCerise()
        {
            Random random = new Random();
            int cerise = random.Next(1, 100);

            if (cerise < 10)
            {
                Console.WriteLine("La récolte du cerisier est mauvaise .. Il n'a produit que " + cerise + " cerises cette semaine");
            }
            else if (cerise > 10 && cerise < 50)
            {
                Console.WriteLine("La récolte du cerisier est moyenne .. Il n'a produit que " + cerise + " cerises cette semaine..");
            }
            else if (cerise > 50 && cerise < 80)
            {
                Console.WriteLine("C'est une bonne récolte ! Vous allez pouvoir récolter " + cerise + " cerises cette semaine !\n" +
                                  "A vos fourneaux !");
            }
            else
            {
                Console.WriteLine("Quel chance !\n"+
                                  "Une récolte exceptionnel de " + cerise+ " cerises s'offre à vous, bonne régalade !");
            }
        }

    }
}
