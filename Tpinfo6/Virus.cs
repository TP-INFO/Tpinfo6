using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    class Virus : NewHumanity
    {

        /// <summary>
        /// Méthode causant l'infection par un virus aléatoirement, causant une mort certaines
        /// </summary>
        /// <param name="hum"></param>
        /// <param name="hom"></param>
        public void infecterMammifere(Androide and, Humain hom)
        {
            Random rnd = new Random();
            int infect = rnd.Next(0, 2);

            if (infect == 0)
            {
                Console.WriteLine("\n\tUne infection a été détécté par {0}, heureusement personne n'a été infecté !", and.Nom);
            }
            else if(infect == 1)
            {
                Console.WriteLine("\n\tUn virus provoquant une grave infection a été détécté par {0},\n" +
                                  "\tmalheureusement {1} est infecté ..", and.Nom, hom.Prenom);
                Console.WriteLine("\tSes jours sont désormais comptés ..");
            }
            else if (infect == 2)
            {
                Console.WriteLine("\n\tUn virus provoquant une grave infection a été détécté par {0}," + 
                                  "\tmalheureusement {1} est infecté ..", and.Nom, hom.Prenom);
                Console.WriteLine("\tSes jours sont désormais comptés ..");
            }
        }

        /// <summary>
        /// Méthode causant une infection sur un animal par un virus aléatoirement
        /// </summary>
        /// <param name="and"></param>
        /// <param name="ani"></param>
        public void infecterAnimal(Androide and, Animal ani)
        {
            Random rnd = new Random();
            int infect = rnd.Next(0, 2);

            if (infect == 0)
            {
                Console.WriteLine("\n\tUne infection a été détécté par {0}, heureusement personne n'a été infecté !", and.Nom);
            }
            else if (infect == 1)
            {
                Console.WriteLine("\n\tUn virus provoquant une grave infection a été détécté par {0},\n" +
                                  "\tmalheureusement {1} est infecté ..", and.Nom, ani.Nom);
                Console.WriteLine("\tSes jours sont désormais comptés ..");
            }
            else if (infect == 2)
            {
                Console.WriteLine("\n\tUn virus provoquant une grave infection a été détécté par {0},\n" +
                                  "\tmalheureusement {1} est infecté ..", and.Nom, ani.Nom);
                Console.WriteLine("\tSes jours sont désormais comptés ..");
            }
        }

    }//End of class
}
