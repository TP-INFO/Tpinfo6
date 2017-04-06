using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    /// <summary>
    /// Classe publique permettant d'implémenter des méthodes nécessaires au humains
    /// </summary>
    public class Humain : NewHumanity, IMammifere
    {
        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Permet de rentrer après une dure journée avec un Random rendant les fin de journée plus vivantes..
        /// </summary>
        public override void RentrerChezSoi()
        {
            Random rnd = new Random();
            int msgAlea = rnd.Next(0, 2);

            if (msgAlea == 0)
            {
                Console.WriteLine(Nom + " rentre à la maison après une belle journée de travail..");
            }
            else if (msgAlea == 1)
            {
                Console.WriteLine(Nom + " rentre à la maison, crevé..");
            }
            else
            {
                Console.WriteLine(Nom + " rentre à la maison, quelle journée de m****e ! ..");
            }

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("[...]");
            System.Threading.Thread.Sleep(1000);
            ToDoInHouse();
        }

        /// <summary>
        /// Permet a un Humain de se déplaçer
        /// </summary>
        public override void SeDeplacer()
        {
            Console.WriteLine("\nOù voulez-vous que " + Nom + " se déplaçe ?\n");
            Console.WriteLine("-1- Sur son champs\n" +
                              "-2- Dans sa maison\n" +
                              "-5- Quitter le jeu");
            UserChoice = Console.ReadLine();

        
            ///<summary>
            ///Switch permettant de choisir la destination de votre héros
            /// </summary>
            switch (UserChoice)
            {
                case "1": /*Champs*/

                    Console.WriteLine("\n\t" + Nom + " se met en route ..");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\t[...]");
                    System.Threading.Thread.Sleep(1000);
                    ToDo();
                    break;

                case "2": /*Maison*/

                    Console.WriteLine("\n\t" + Nom + " se met en route ..");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\t[...]");
                    System.Threading.Thread.Sleep(1000);
                    ToDoInHouse();

                    break;

                case "5": //Quitter

                    Console.Clear();
                    Console.WriteLine("A bientôt !");
                    Environment.Exit(0);

                    break;

                default:

                    Console.WriteLine("Erreur dans la saisie ..");
                    SeDeplacer();

                    break;
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Permet a un Humain d'effectuer des actions
        /// </summary>
        public override void ToDo()
        {
            Console.WriteLine("\nQue va faire " + Nom + " maintenant ?\n");
            Console.WriteLine("-1- Tailler ses arbres\n" +
                              "-2- Ramasser des fruits & légumes\n" +
                              "-3- Récolter du maïs\n" +
                              "-0- Rentrer chez lui\n" +
                              "-5- Quitter le jeu");

            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1": /*Tailler les arbres*/

                    Console.WriteLine("\n\t" + Nom + " se met en route vers le verger..\n");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\t[...]");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("Que vas-t'on tailler en premier ?\n");

                    Console.WriteLine("-1- Tailler le cerisier\n" +
                                      "-2- Tailler l'abricotier\n" +
                                      "-0- Rentrer chez lui\n" +
                                      "-5- Quitter le jeu");

                    UserChoice = Console.ReadLine();

                    #region Switch-Alt (Case1 -Tailler)
                    switch (UserChoice)
                    {
                        case "1": /*Taille Cerisier*/ 

                            Console.WriteLine(Nom + " taille le cerisier");

                            Cerisier cer = new Cerisier();
                            cer.Variete = "le cerisier";
                            TaillerArbre(cer);

                            ToDo();
                            break;

                        case "2": /*Taille Abricotier*/

                            Console.WriteLine(Nom + " taille l'abricotier");

                            Abricotier abr = new Abricotier();
                            abr.Variete = "l'abricotier";

                            ToDo();
                            break;

                        case "0": /*Rentrer chez Soi*/

                            Console.WriteLine(Nom + " rentre chez lui");

                            RentrerChezSoi();
                            break;

                        case "5": /*Quitter*/

                            Console.Clear();
                            Console.WriteLine("A bientôt !");
                            Environment.Exit(0);
                            break;

                        default:

                            Console.WriteLine("Une erreur est survenu ..");

                            ToDo();
                            break;
                    }
                    #endregion
                    break;

                case "2": /*Ramasser les fruits*/

                    Console.WriteLine("\n\t" + Nom + " se met en route vers le champ..");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\t[...]");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\nQue vas-t'on ramasser en premier ?\n");

                    Console.WriteLine("-1- Ramasser des cerises\n" +
                                      "-2- Ramasser des abricots\n" +
                                      "-3- Ramasser des choux\n" +
                                      "-5- Quitter\n" +
                                      "-0- Rentrer chez soi");

                    UserChoice = Console.ReadLine();

                    #region Switch-Alt (Case2 -Ramasser)
                    switch (UserChoice)
                    {
                        case "1": /*Ramasser Cerises*/

                            Console.WriteLine("\n\t" + Nom + " va ramasser des cerises");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\t[...]\n");

                            Cerisier Cer = new Cerisier();
                            Console.WriteLine("");
                            Cer.GenerateCerise();
                            ToDo();
                            break;

                        case "2": /*Ramasser Abricots*/

                            Console.WriteLine("\n\t" + Nom + " va ramasser des abricots");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\t[...]\n");

                            Abricotier Abr = new Abricotier();
                            Abr.GenerateAbricot();
                            Console.WriteLine("");
                            ToDo();
                            break;

                        case "3": /*Ramasser des choux*/

                            Console.WriteLine("\n\t" + Nom + " va ramasser des choux");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\t[...]\n");

                            Chou cho = new Chou();
                            cho.GenerateChou();
                            Console.WriteLine("");
                            ToDo();
                            break;

                        case "0": /*Rentrer chez Soi*/

                            RentrerChezSoi();
                            break;

                        case "5": /*Quitter*/

                            Console.Clear();
                            Console.WriteLine("A bientôt !");
                            Environment.Exit(0);
                            break;

                        default: /*Erreur*/

                            Console.WriteLine("Une erreur est survenu ..");
                            ToDo();
                            break;
                    }
                    #endregion
                    break;

                case "3": /*Récolter du Maïs*/

                    Console.WriteLine("\n\t" + Nom + " va récolter du Maïs ..");
                    System.Threading.Thread.Sleep(1000);
                    Console.WriteLine("\t[...]\n");
                    System.Threading.Thread.Sleep(1000);

                    Mais mai = new Mais();
                    mai.GenerateMais();
                    Console.WriteLine("");

                    ToDo();
                    break;

                case "0": /*Rentrer chez Soi*/

                    RentrerChezSoi();
                    break;

                case "5": /*Quitter*/

                    Console.Clear();
                    Console.WriteLine("A bientôt !");
                    Environment.Exit(0);
                    break;

                default: /*Erreur*/
                    Console.WriteLine("Erreur dans la saisie ..");
                    ToDo();
                    break;
            }
        }

        /// <summary>
        /// Méthode permettant d'éffectuer des tâches à la maison
        /// </summary>
        public override void ToDoInHouse()
        {
            Console.WriteLine("Que va faire " + Nom + " maintenant ?\n");
            Console.WriteLine("-1- Manger\n" +
                              "-2- Regarder par la fenêtre ..\n" +
                              "-3- Dormir\n" +
                              "-5- Quitter");

            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1": /*Manger*/
                    Console.WriteLine("Que vas-t'on faire à manger ?");
                    Console.WriteLine("-1- De la dinde\n" +
                                      "-2- Une bonne salade de maïs\n" +
                                      "-3- Une bonne soupe aux choux\n" +
                                      "-5- Quitter");
                    UserChoice = Console.ReadLine();

                    #region Switch-Alt (Manger)
                    switch (UserChoice)
                    {
                        case "1": /*Dinde*/

                            Couteau cou = new Couteau();
                            Dindon din = new Dindon();
                            din.Type = "Dinde";
                            din.Glouglouter();
                            cou.TuerAnimal(din);
                            System.Threading.Thread.Sleep(1000);
                            
                            Console.WriteLine("\n\t{0} met les morceaux dans la marmitte et commence à faire cuire..", Nom);
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\t[...]");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\n\t{0} se régale d'un bon ragoût de {1} !", Nom, din.Type);
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\t[...]");

                            ToDoInHouse();
                            break;

                        case "2": /*Salade Maïs*/

                            Mais mai = new Mais();
                            mai.Variete = "maïs";

                            Console.WriteLine("\n\t{0} se prépare une bonne salade de {1}..", Nom, mai.Variete);
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\t[...]");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\n\tQuel régalade, cette salade !");

                            ToDoInHouse();
                            break;

                        case "3": /*Soupe de Chou*/

                            Chou cho = new Chou();
                            cho.Variete = "choux";

                            Console.WriteLine("\n\t{0} met les choux dans la marmitte et commence à faire cuire..", Nom);
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\t[...]");
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\n\t{0} se régale d'une bonne soupe de {1} !", Nom, cho.Variete);
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("\t[...]");


                            ToDoInHouse();
                            break;

                        case "5": /*Quitter*/

                            Console.Clear();
                            Console.WriteLine("A bientôt !");
                            Environment.Exit(0);
                            break;

                        default: /*Erreur*/

                            Console.WriteLine("Erreur de saisie, veuillez recommencer ..");
                            ToDoInHouse();
                            break;
                    }
                    #endregion
                    break;

                case "2": /*Regarder Fenêtre*/

                    Console.WriteLine("\n\t{0} regarde par la fenêtre..", Nom);
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("\t[...]\n");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("\t[...]\n");

                    ToDoInHouse();
                    break;

                case "3": /*Dormir*/

                    Dormir();
                    break;

                case "5": /*Quitter*/

                    Console.Clear();
                    Console.WriteLine("A bientôt !");
                    Environment.Exit(0);
                    break;

                default: /*Erreur*/

                    Console.WriteLine("Erreur de saisie, veuillez recommencer ..");
                    ToDoInHouse();
                    break;
            }
        }

        /// <summary>
        /// Permet à un Homme de créer sa Femme (..ou pas!)
        /// </summary>
        public void CreateWife()
        {
            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "o":
                    Console.WriteLine("Quel sera le prénom de sa compagne ?");
                    Humain Femme = new Humain();
                    Femme.Nom = Console.ReadLine();
                    Console.WriteLine("\nExcellent choix,\n" +
                                       Femme.Nom + " est un très beau prénom !");
                    break;
                case "n":
                    Console.Write("Etes-vous sûr ? (o/n) : ");
                    UserChoice = Console.ReadLine();

                    #region Switch-Alt Rep = "n"
                    switch (UserChoice)
                    {
                        case "o":
                            Console.WriteLine("\n\tNe venez pas vous plaindre d'avoir trop de travail !");
                            break;

                        case "n":
                            Console.WriteLine("\n\tJe vois que vous êtes revenu à la raison,\n" +
                                              "\tQuelle sera donc son prénom ?");
                            Femme = new Humain();
                            Femme.Nom = Console.ReadLine();
                            Console.WriteLine("\n\tExcellent choix,\n" +
                                              "\t" + Femme.Nom + " est un très beau prénom !");
                            break;

                        default:
                            Console.WriteLine("Erreur de saisie, veuillez recommencer ..");
                            Console.Clear();
                            CreateWife();
                            break;
                    }
                    #endregion
                    break;
                default:
                    Console.WriteLine("Erreur de saisie, veuillez recommencer ..");
                    CreateWife();
                    Console.Clear();
                    break;
            }
        }

        /// <summary>
        /// Permet à notre héros de manger
        /// </summary>
        public override void Manger()
        {
           
        }

        /// <summary>
        /// Permet à un Humain de Mourrir()
        /// </summary>
        public override void Mourrir()
        {
            Console.WriteLine("Oh non ! {0} est mort !", Nom);

            Console.Clear();
            Console.WriteLine("La partie est terminé. GAME OVER");
            Environment.Exit(0);
        }

        /// <summary>
        /// Méthode permettant d'avoir un nombre de branches selon la taille de l'arbre
        /// Avec une méthode qui fait mourrir l'arbre si il a été trop taillé
        /// </summary>
        public void TaillerArbre(Flora flo)
        {
            Random rnd = new Random();
            int NbreBranches = rnd.Next(3, 20);

            if (NbreBranches < 5)
            {
                Console.WriteLine("\tUn peu de nerfs, {0} ne va pas se tailler tout seul !", flo.Variete);
                Console.WriteLine("\t{0} ramassent les {1} branches et les met en tas..", Nom, NbreBranches);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\t[...]");
                System.Threading.Thread.Sleep(1000);
            }
            else if (NbreBranches > 5 && NbreBranches < 12)
            {
                Console.WriteLine("\tEn voilà un beau {0} bien taillé !", flo.Variete);
                Console.WriteLine("\t{0} ramassent les {1} branches et les met en tas..", Nom, NbreBranches);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\t[...]");
                System.Threading.Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("\tOh non, vous avez trop tailler {0} !", flo.Variete);
                Console.WriteLine("\t{0} brûle l'arbre, il n'est plus utilisable..", Nom);
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("\t[...]");
                System.Threading.Thread.Sleep(1000);
            }
        }

        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/

        /// <summary>
        /// Default Constructor Human Class
        /// </summary>
        public Humain()
        {

        }

        /// <summary>
        /// Constructeur avec un Nom en paramètre
        /// </summary>
        /// <param name="Nom"></param>
        public Humain(string Nom) : base()
        {

        }
    }//End of Class
}
