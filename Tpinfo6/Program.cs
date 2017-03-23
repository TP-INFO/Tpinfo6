using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("╔═══════════════════════════════════════╗\n" +
                          "║                                       ║\n" +
                          "║                                       ║\n" +
                          "║         Welcome in Futur Farm         ║\n" +
                          "║                                       ║\n" +
                          "║                                       ║\n" +
                          "╚═══════════════════════════════════════╝\n");
            Console.WriteLine("Nous sommes en 2110, et vous allez devoir vous occuper d'une ferme ..\n" +
                              "Avant de commencer nous allons personnaliser votre expérience : \n");

            Soleil Sun = new Soleil();
            Sun.SeLever();

            Console.WriteLine("Quel est le prénom de votre héros ?\n");
            Humain Homme = new Humain();
            Homme.Prenom = Console.ReadLine();

            Console.WriteLine("\n" + Homme.Prenom + " est-il accompagné dans la vie ? (o/n)\n");
            Homme.CreateWife();

            Console.WriteLine("Vous possédez un chien, comment s'appelle-t-il ?\n");
            Chien Dog = new Chien();
            Dog.Nom = Console.ReadLine();
            Dog.RemuerLaQueue();

            Humanoide Pepper = new Humanoide("Pepper");
            Console.WriteLine("Votre humanoïde s'appelle " + Pepper.Nom + "\n" +
                              "Il effectuera les tâches les plus ingrates pour vous, c'est un allier précieux.");


            //Homme.SeDeplacer();


            /*ToDo == Afficher résumé des précedentes saisies (Homme, Femme, Chien) avant démarrage de l'histoire
                      Présenter le Contexte et mettre en place la semaine

                      Définir des méthodes d'actions pour les Clones, Androides, Humanoides
                      Définir les méthodes d'actions pour les animaux

                      Définir pour chaques jour des changements d'états dans les arbres et plantes
                      Mettre en place fonction Flemme() == Permet de sauter des jours de la semaine
                      Mettre en place fonction ActionMax() == Terminé la journée "J'en ai marre" + RentrerChezSoi()
            */


        }//End of Main
    }
}
