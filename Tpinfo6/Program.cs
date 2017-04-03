using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    class Program
    {
        const double VERSION = 0.66; 

        static void Main(string[] args)
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

            Soleil Sun = new Soleil();
            Sun.SeLever();

            Console.Write("Quel est le prénom de votre héros ? ");
            Humain Homme = new Humain();
            Homme.Prenom = Console.ReadLine();

            Console.Write("\n" + Homme.Prenom + " est-il accompagné dans la vie ? (o/n) : ");
            Homme.CreateWife();

            Console.Write("\nVous possédez un chien, comment s'appelle-t-il ? ");
            Chien Dog = new Chien();
            Dog.Nom = Console.ReadLine();
            Dog.RemuerLaQueue();

            Androide Pepper = new Androide("Pepper");
            Console.WriteLine("\n\tVotre humanoïde s'appelle " + Pepper.Nom + "\n" +
                              "\tIl effectuera les tâches les plus ingrates pour vous, c'est un alliés précieux.");

            System.Threading.Thread.Sleep(1000);

            #region Histoire

            int jour = (int)Jours.Lundi;

            while (jour != 8)
            {
                switch (jour)
                {
                    case 1: /*Lundi*/
                        /*
                        Soleil brille, 
                        Arbres et plantes poussent, 

                        Lune se lève,
                        
                        */
                        break;

                    case 2: /*Mardi*/

                        break;

                    case 3: /*Mercredi*/

                        break;

                    case 4: /*Jeudi*/

                        break;

                    case 5: /*Vendredi*/

                        break;

                    case 6: /*Samedi*/

                        break;

                    case 7: /*Dimanche*/

                        break;

                    default:

                        break;
                }
                jour++;
            }

            #endregion

            #region Structure de Tests

            Virus h5n1 = new Virus();
            h5n1.infecterMammifere(Pepper, Homme);


            #endregion

            #region ToDo :

            /*        
                      Général :
                      Mettre header "Welcome in" persistant
                      Afficher résumé des précedentes saisies (Homme, Femme, Chien) avant démarrage de l'histoire
                      Présenter le Contexte et mettre en place la semaine

                      Actions :
                      Régler la question du couteau pour Tuer()
                      Définir des méthodes d'actions pour les Clones, Androides, Humanoides
                      Implémenter les méthodes pour la class Clone
                      -DONE- Définir les méthodes d'actions pour les animaux 
                      -DONE- Mettre en place une struct pour Clone

                      Flora :
                      Définir pour chaques jour des changements d'états dans les arbres et plantes
                      Empêcher récolte selon les jours
                      -DONE- Méthode aléatoire pour faire mourrir ou non les arbres/plantes

                      Humain :
                      Mettre en place fonction Flemme() == Permet de sauter des jours de la semaine
                      Mettre en place fonction ActionMax() == Terminé la journée "J'en ai marre" + RentrerChezSoi()
                      Terminer Manger() et Mourrir() pour Humains, Humanoïdes, Androïdes

            */
            #endregion

        }//End of Main
    }
}
