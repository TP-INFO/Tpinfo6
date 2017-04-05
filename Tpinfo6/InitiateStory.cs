using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    /// <summary>
    /// Classe statique permettant de libérer le MainProgram 
    /// </summary>
    static class InitiateStory
    {
       
        /// <summary>
        /// Méthode permettant d'afficher le Header du programme
        /// </summary>
        public static void Start()
        {
            Console.Write("\t╔═══════════════════════════════════════╗\n" +
                          "\t║                                       ║\n" +
                          "\t║                                       ║\n" +
                          "\t║         Welcome in Futur Farm         ║\n" +
                          "\t║                                       ║\n" +
                          "\t║                                       ║\n" +
                          "\t╚═══════════════════════════════════════╝\n");
            Console.WriteLine("Nous sommes en 2110, et vous allez devoir vous occuper d'une ferme ..\n" +
                              "Avant de commencer nous allons personnaliser votre expérience : \n");
        }

        /// <summary>
        /// Méthode static permettant de personnaliser l'histoire
        /// </summary>
        public static void ConfigStory()
        {
            Soleil Sun = new Soleil();
            Sun.SeLever();

            Console.Write("Quel est le prénom de votre héros ? ");
            Humain Homme = new Humain();
            Homme.Nom = Console.ReadLine();

            Console.Write("\n" + Homme.Nom + " est-il accompagné dans la vie ? (o/n) : ");
            Homme.CreateWife();

            Console.Write("\nVous possédez un chien, comment s'appelle-t-il ? ");
            Chien Dog = new Chien();
            Dog.Nom = Console.ReadLine();
            Dog.RemuerLaQueue();

            Androide Pepper = new Androide("Pepper");
            Console.WriteLine("\n\tVotre androïde s'appelle " + Pepper.Nom + "\n" +
                              "\tIl effectuera les tâches les plus ingrates pour vous, c'est un alliés précieux.");

            System.Threading.Thread.Sleep(1000);

            Homme.SeDeplacer();
        }

        /// <summary>
        /// Méthode qui lance le déroulé de l'histoire
        /// </summary>
        public static void StartStory()
        {
            //int jour = (int)Jours.Lundi;

            //while (jour != 8)
            //{
            //    switch (jour)
            //    {
            //        case 1: /*Lundi*/
            //            /*
            //            Sun.SeLever();
            //            Soleil brille, 
            //            Arbres poussent, 
            //            Taille plantes
            //            Manger
            //            Dormir
            //            Lune se lève,

            //            */
            //            break;

            //        case 2: /*Mardi*/
            //            /*
            //            Soleil,
            //            Arbres Floraison,
            //            Plantes poussent,
            //            Manger
            //            Dormir
            //            Lune
            //            */
            //            break;

            //        case 3: /*Mercredi*/
            //            /*
            //            Soleil
            //            Plantes Floraison
            //            Virus
            //            Manger
            //            Lune
            //            */
            //            break;

            //        case 4: /*Jeudi*/
            //            /*
            //            Soleil
            //            Arbres Recolte
            //            Manger
            //            Tuer Animal (Dindon)
            //            Manger
            //            Lune
            //            */

            //            break;

            //        case 5: /*Vendredi*/
            //            /*
            //            Soleil
            //            Taille Arbres
            //            Virus ?
            //            Plantes Recolte

            //            Lune
            //            */
            //            break;

            //        case 6: /*Samedi*/
            //            /*
            //            Soleil
            //            Arbres Mourrir
            //            Tuer animal (Chèvre)

            //            Lune
            //            */
            //            break;

            //        case 7: /*Dimanche*/
            //            /*
            //            Soleil
            //            Virus Animaux
            //            Plantes Mourrir

            //            Catastrophe --
            //            Fin
            //            */
            //            break;

            //        default:

            //            break;
            //    }
            //    jour++;
            //}
        }

    } //End of Class
}
