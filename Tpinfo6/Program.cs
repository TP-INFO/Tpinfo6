﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    class Program
    {
        const double Version = 0.4; 

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

            //Console.Write("Quel est le prénom de votre héros ? ");
            //Humain Homme = new Humain();
            //Homme.Prenom = Console.ReadLine();

            //Console.Write("\n" + Homme.Prenom + " est-il accompagné dans la vie ? (o/n) : ");
            //Homme.CreateWife();

            //Humanoide Pepper = new Humanoide("Pepper");
            //Console.WriteLine("\n\tVotre humanoïde s'appelle " + Pepper.Nom + "\n" +
            //                  "\tIl effectuera les tâches les plus ingrates pour vous, c'est un alliés précieux.");

            //System.Threading.Thread.Sleep(2000);

            /*Structure de Tests*/

            Chevre Che = new Chevre();
            Che.Nom = "Biquette";
            Che.Beler();

            Console.Write("\nVous possédez un chien, comment s'appelle-t-il ? ");
            Chien Dog = new Chien();
            Dog.Nom = Console.ReadLine();
            Dog.RemuerLaQueue();

            Dog.Poursuivre(Dog, Che);
            Dog.Mourrir();

            Cerisier Cer = new Cerisier();
            Cer.Pousser();
            Cer.Fleurir();
            Cer.Recolter();
            Cer.Mourrir();

            //Abricotier Abr = new Abricotier();
            //Abr.Pousser();
            //Abr.Fleurir();
            //Abr.Recolter();
            //Abr.Mourrir();

            //Homme.SeDeplacer();




            /*ToDo == Général :
                      Mettre header "Welcome in" persistant
                      Afficher résumé des précedentes saisies (Homme, Femme, Chien) avant démarrage de l'histoire
                      Présenter le Contexte et mettre en place la semaine

                      Actions :
                      Définir des méthodes d'actions pour les Clones, Androides, Humanoides
                      Définir les méthodes d'actions pour les animaux
                      Mettre en place une struct pour Clone -*- 

                      Flora :
                      Définir pour chaques jour des changements d'états dans les arbres et plantes
                      Empêcher récolte selon les jours
                      Méthode aléatoire pour faire mourrir ou non les arbres/plantes

                      Humain :
                      Mettre en place fonction Flemme() == Permet de sauter des jours de la semaine
                      Mettre en place fonction ActionMax() == Terminé la journée "J'en ai marre" + RentrerChezSoi()

            */


        }//End of Main
    }
}
