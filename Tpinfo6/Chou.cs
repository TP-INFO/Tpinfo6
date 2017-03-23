using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Chou : Flora
    {
        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Génére un nombre aléatoires de chou(x)
        /// </summary>
        public void GenerateChou()
        {
            Random random = new Random();
            int chou = random.Next(1, 30);

            if (chou < 5)
            {
                Console.WriteLine("Savez-vous planter les choux ? .. Votre champ n'a produit que " + chou + " choux cette semaine..");
            }
            else if (chou > 5 && chou < 10)
            {
                Console.WriteLine("Votre technique n'est certainement pas bonne .. Le champ n'a produit que " + chou + " choux cette semaine..");
            }
            else if (chou > 10 && chou < 20)
            {
                Console.WriteLine("C'est une bonne récolte que vous avez là ! Vous allez pouvoir récolter " + chou + " choux cette semaine !\n" +
                                  "A vos fourneaux !");
            }
            else
            {
                Console.WriteLine("Quel chance !\n" +
                                  "Une récolte exceptionnel de" + chou + " choux s'offre à vous, bonne régalade !");
            }
        }
    }
}
