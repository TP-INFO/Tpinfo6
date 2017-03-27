using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Humain : NewHumanity
    {
        //private string userChoice; Implémenter dans classe mère ..

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
                              "-0- Rentrer chez soi\n");
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
                              "-0- Rentrer chez lui");

            UserChoice = Console.ReadLine();

            switch (UserChoice)
            {
                case "1": /*Tailler les arbres*/
                    Console.WriteLine(Prenom + " se met en route ..\n");
                    Console.WriteLine("[...]");
                    Console.WriteLine("Que vas-t'on tailler en premier ?\n");

                    Console.WriteLine("-1- Tailler le cerisier\n" +
                                      "-2- Tailler l'abricotier\n" +
                                      "-0- Rentrer chez lui");

                    UserChoice = Console.ReadLine();

                    ///<summary>
                    ///Switch-Alt pour Case 1 -Tailler-
                    /// </summary>
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

                        default:
                            Console.WriteLine("Une erreur est survenu ..");
                            ToDo();
                            break;
                    }

                    break;

                case "2": /*Ramasser les fruits*/
                    Console.WriteLine(Prenom + " se met en route ..\n");
                    Console.WriteLine("[...]");
                    Console.WriteLine("Que vas-t'on ramasser en premier ?\n");

                    Console.WriteLine("-1- Ramasser des cerises\n" +
                                      "-2- Ramasser des abricots\n" +
                                      "-0- Rentrer chez soi");

                    UserChoice = Console.ReadLine();

                    ///<summary>
                    ///Switch-Alt pour Case 2 -Ramasser-
                    /// </summary>
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
                    break;

                case "0": /*Rentrer chez Soi*/
                    Console.WriteLine(Prenom + " rentre chez lui");
                    SeDeplacer();
                    break;

                default: /*Erreur*/
                    Console.WriteLine("Erreur dans la saisie ..");
                    break;
            }
        }

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
                                      "-0- Rentrer chez lui");
                    UserChoice = Console.ReadLine();
                    break;
                case "2":

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
                    Console.WriteLine("Quel sera le prénom de sa compagne ?\n");
                    Humain Femme = new Humain();
                    Femme.Prenom = Console.ReadLine();
                    Console.WriteLine("\nExcellent choix,\n" +
                                       Femme.Prenom + " est un très beau prénom !");
                    break;
                case "n":
                    Console.WriteLine("Etes-vous sûr ? (o/n)\n");
                    UserChoice = Console.ReadLine();

                    ///<summary>
                    ///Switch-Alt pour Case "n"
                    /// </summary>
                    switch (UserChoice)
                    {
                        case "o":
                            Console.WriteLine("\nJe vois que vous êtes revenu à la raison,\n" +
                                              " Quelle sera donc son prénom ?");
                            Femme = new Humain();
                            Femme.Prenom = Console.ReadLine();
                            Console.WriteLine("\nExcellent choix,\n" +
                                               Femme.Prenom + " est un très beau prénom !");
                            break;
                        case "n":
                            Console.WriteLine("Ne venez pas vous plaindre d'avoir trop de travail !");
                            break;
                        default:
                            Console.WriteLine("Erreur de saisie, veuillez recommencer ..");
                            CreateWife();
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Erreur de saisie, veuillez recommencer ..");
                    CreateWife();
                    break;
            }
        }

        /// <summary>
        /// Permet à notre héros de dormir
        /// </summary>
        public void Dormir()
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
