using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Humain : NewHumanity, IMammifere
    {
        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Permet de rentrer après une dure journée ..
        /// </summary>
        public override void RentrerChezSoi()
        {
            //base.RentrerChezSoi();
            Console.WriteLine(Prenom + " se met en route ..");
            Console.WriteLine("[...]");

            //Implémenter retour à la maison
        }

        /// <summary>
        /// Permet a un Humain de se déplaçer
        /// </summary>
        public override void SeDeplacer()
        {
            Console.WriteLine("\nOù voulez-vous que " + Prenom + " se déplaçe ?\n");
            Console.WriteLine("-1- Sur son champs\n" +
                              "-2- Dans sa maison\n" +
                              "-0- Dormir\n" +
                              "-5- Quitter le jeu");
            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1":
                    Console.WriteLine(Prenom + " se met en route ..");
                    Console.WriteLine("[...]");
                    ToDo();
                    //TODO Add Implementation with Clone & Android + Dog.
                    break;
                case "2":
                    Console.WriteLine(Prenom + " se met en route ..");
                    Console.WriteLine("[...]");

                    //TODO Add Action.
                    break;
                case "0":
                    Console.WriteLine(Prenom + " se met en route ..");
                    Console.WriteLine("[...]");

                    //TODO Add Action.
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


            Console.WriteLine("");
        }

        /// <summary>
        /// Permet a un Humain d'effectuer des actions
        /// </summary>
        public override void ToDo()
        {
            Console.WriteLine("Que va faire " + Prenom + " maintenant ?\n");
            Console.WriteLine("-1- Tailler ses arbres\n" +
                              "-2- Ramasser des fruits\n" +
                              "-0- Rentrer chez lui\n" +
                              "-5- Quitter le jeu");

            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1": /*Tailler les arbres*/
                    Console.WriteLine(Prenom + " se met en route ..\n");
                    Console.WriteLine("[...]");
                    Console.WriteLine("Que vas-t'on tailler en premier ?\n");

                    Console.WriteLine("-1- Tailler le cerisier\n" +
                                      "-2- Tailler l'abricotier\n" +
                                      "-0- Rentrer chez lui\n" +
                                      "-5- Quitter le jeu");

                    UserChoice = Console.ReadLine();

                    #region Switch-Alt (Case1 -Tailler)
                    switch (UserChoice)
                    {
                        case "1": /*Taille Cerisier*/ //ToDo == Ajouter Pepper qui ramasse un nombre de branches
                            Console.WriteLine(Prenom + " taille le cerisier"); //Ajouter un Random de résultats après taille
                            
                            ToDo();
                            break;

                        case "2": /*Taille Abricotier*/
                            Console.WriteLine(Prenom + " taille l'abricotier");
                            ToDo();
                            break;

                        case "0": /*Rentrer chez Soi*/
                            Console.WriteLine(Prenom + " rentre chez lui");
                            SeDeplacer(); //Remplaçer par RentrerChezSoi()
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
                    Console.WriteLine(Prenom + " se met en route ..\n");
                    Console.WriteLine("[...]");
                    Console.WriteLine("Que vas-t'on ramasser en premier ?\n");

                    Console.WriteLine("-1- Ramasser des cerises\n" +
                                      "-2- Ramasser des abricots\n" +
                                      "-0- Rentrer chez soi");

                    UserChoice = Console.ReadLine();

                    #region Switch-Alt (Case2 -Ramasser)
                    switch (UserChoice)
                    {
                        case "1": /*Ramasser Cerises*/

                            Console.WriteLine(Prenom + " va ramasser des cerises");
                            Console.WriteLine("[...]\n");
                            Cerisier Cer = new Cerisier();
                            Console.WriteLine("");
                            Cer.GenerateCerise();
                            ToDo();
                            break;

                        case "2": /*Ramasser Abricots*/

                            Console.WriteLine(Prenom + " va ramasser des abricots");
                            Console.WriteLine("[...]\n");
                            Abricotier Abr = new Abricotier();
                            Abr.GenerateAbricot();
                            Console.WriteLine("");
                            ToDo();
                            break;

                        default: /*Erreur*/
                            Console.WriteLine("Une erreur est survenu ..");
                            ToDo();
                            break;
                    }
                    #endregion
                    break;

                case "0": /*Rentrer chez Soi*/
                    Console.WriteLine(Prenom + " rentre chez lui");
                    SeDeplacer();
                    break;

                case "5": /*Quitter*/
                    Console.Clear();
                    Console.WriteLine("A bientôt !");
                    Environment.Exit(0);
                    break;

                default: /*Erreur*/
                    Console.WriteLine("Erreur dans la saisie ..");
                    break;
            }
        }

        /// <summary>
        /// Méthode permettant d'éffectuer des tâches à la maison
        /// </summary>
        public override void ToDoInHouse()
        {
            Console.WriteLine("Que va faire " + Prenom + " maintenant ?\n");
            Console.WriteLine("-1- Préparer à manger\n" +
                              "-2- Mettre en charge Pepper\n" +
                              "-0- Rentrer chez lui");

            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1":
                    Console.WriteLine("Que vas-t'on faire à manger ?");
                    Console.WriteLine("-1- De la dinde\n" +
                                      "-2- Une bonne salade de maïs\n" +
                                      "-5- Quitter");
                    UserChoice = Console.ReadLine();
                    break;

                case "2":

                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("A bientôt !");
                    Environment.Exit(0);
                    break;

                default:
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
                    Femme.Prenom = Console.ReadLine();
                    Console.WriteLine("\nExcellent choix,\n" +
                                       Femme.Prenom + " est un très beau prénom !");
                    break;
                case "n":
                    Console.Write("Etes-vous sûr ? (o/n) ");
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
                            Femme.Prenom = Console.ReadLine();
                            Console.WriteLine("\n\tExcellent choix,\n" +
                                              "\t" + Femme.Prenom + " est un très beau prénom !");
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
        /// Permet à notre héros de dormir
        /// </summary>
        public void Dormir()
        {

        }

        public override void Manger()
        {

        }

        public override void Mourrir()
        {

        }

        //ToDo == Créer méthode Flemme() 


        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/

        /// <summary>
        /// Default Constructor Human Class
        /// </summary>
        public Humain()
        {

        }
        

        public Humain(string Nom, string Prenom) : base()
        {

        }
    }//End of Class
}
