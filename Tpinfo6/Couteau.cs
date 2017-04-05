using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Couteau : Tools
    {

        /// <summary>
        /// Méthode qui permet de tuer un animal
        /// Et de récolter un certains nombres de morceaux de viande
        /// </summary>
        /// <param name="animal"></param>
        public void TuerAnimal(Animal ani)
        {
            Random rnd = new Random();
            int coup = rnd.Next(1, 10);

            Console.WriteLine("\n\tVotre {0} a été tué avec le couteau en {1} coups !", ani.Nom, coup);

            Random rnd2 = new Random();
            int morceau = rnd2.Next(1, 5);

            if (morceau < 2)
            {
                Console.WriteLine("\tQuel boucher ! Vous n'avez pu récolter que {0} morceau(x) de viande", morceau);
            }
            else if (morceau > 2 && morceau < 4)
            {
                Console.WriteLine("\tVotre technique n'est pas mauvaise, vous avez pu récolter {0} morceaux de viande", morceau);
            }
            else
            {
                Console.WriteLine("\tBelle technique, vous avez pu récolter {0} morceau de viande !", morceau);
            }
        }



        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/

        /// <summary>
        /// Constructeur par défaut d'un couteau avec un argument :
        /// <param name="nom">nom</param>
        /// </summary>
        public Couteau(string nom)
        {
            this.Nom = nom;
        }

        /// <summary>
        /// Constructeur vide pour un Couteau
        /// </summary>
        public Couteau()
        {

        }


    }//End of class
}
