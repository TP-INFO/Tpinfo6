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
                              "-3- Dans sa cuisine\n");
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
                case "3":
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
            //Console.WriteLine(Prenom + " va au travail ..");
        }

        /// <summary>
        /// Permet a un Humain d'effectuer des actions
        /// </summary>
        public override void ToDo()
        {
            Console.WriteLine("Que va faire " + Prenom + " maintenant ?\n");
            Console.WriteLine("-1- Tailler ses arbres\n" +
                              "-2- Ramasser des fruits\n" +
                              "-3- Labourer le champs\n" +
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
                        case "1":
                            Console.WriteLine(Prenom + " taille le cerisier"); //Ajouter un Random de résultats après taille
                            ToDo();
                            break;
                        case "2":
                            Console.WriteLine(Prenom + " taille l'abricotier");
                            ToDo();
                            break;
                        case "0":
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
                    UserChoice = Console.ReadLine();

                    switch (UserChoice)
                    {
                        case "1":
                            Console.WriteLine(Prenom + " va ramasser des cerises");
                            //TODO Random Fruits et légumes (+Voir instanciation)
                            break;
                        case "2":
                            Console.WriteLine(Prenom + " va ramasser des abricots");
                            break;
                        //ToDO == Ajouter le Random Abricot
                        default:
                            Console.WriteLine("Une erreur est survenu ..");
                            ToDo();
                            break;
                    }

                    break;
                case "3": /*Labourer le champs*/
                    //TODO Add Action.
                    break;
                case "0": /*Rentrer chez Soi*/
                    Console.WriteLine(Prenom + " rentre chez lui");
                    SeDeplacer();
                    break;
                default:
                    Console.WriteLine("Erreur dans la saisie ..");
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
