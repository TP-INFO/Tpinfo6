using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Humain : NewHumanity
    {
        private string userChoice;


        public override void SeDeplacer()
        {
            Console.WriteLine("\nOù voulez-vous que " + Prenom + " se déplaçe ?\n");
            Console.WriteLine("-1- Sur son champs\n"+
                              "-2- Dans sa maison\n"+
                              "-3- Dans sa cuisine\n");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Console.WriteLine(Prenom + " se met en route ..");
                    Console.WriteLine("[...]");

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

        public override void ToDo()
        {
            Console.WriteLine("Que va faire " + Prenom + " maintenant ?\n");
            Console.WriteLine("-1- Tailler ses arbres\n" +
                              "-2- Ramasser des fruits\n" +
                              "-3- Labourer le champs\n" +
                              "-0- Rentrer chez lui");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1": /*Tailler les arbres*/
                    Console.WriteLine(Prenom + " se met en route ..\n");
                    Console.WriteLine("[...]");
                    Console.WriteLine("Que vas-t'on tailler en premier ?\n");

                    Console.WriteLine("-1- Tailler le cerisier\n" +
                                      "-2- Tailler l'abricotier\n" +
                                      "-0- Rentrer chez lui");

                    userChoice = Console.ReadLine();

                    ///<summary>
                    ///Switch-Alt pour Case 1 -Tailler-
                    /// </summary>
                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine(Prenom + " taille le cerisier");
                            ToDo();
                            break;
                        case "2":
                            Console.WriteLine(Prenom + " taille l'abricotier");
                            ToDo();
                            break;
                        case "0":
                            Console.WriteLine(Prenom + " rentre chez lui");
                            SeDeplacer();
                            break;
                        default:
                            Console.WriteLine("Une erreur est survenu ..");
                            ToDo();
                            break;
                    }
                    //TODO Add Action.
                    break;
                case "2": /*Ramasser les fruits*/
                    Console.WriteLine(Prenom + " se met en route ..\n");
                    Console.WriteLine("[...]");
                    Console.WriteLine("Que vas-t'on ramasser en premier ?\n");
                    userChoice = Console.ReadLine();

                    switch (userChoice)
                    {
                        case "1":
                            Console.WriteLine(Prenom + " va ramasser des cerises");
                            //TODO Random Fruits et légumes (+Voir instanciation)
                            break;
                        case "2":
                        default:
                            break;
                    }
                    //TODO Add Action.
                    break;
                case "3": /*Labourer le champs*/
                    //TODO Add Action.
                    break;
                case "0":
                    Console.WriteLine(Prenom + " rentre chez lui");
                    SeDeplacer();
                    break;
                default:
                    Console.WriteLine("Erreur dans la saisie ..");
                    break;
            }
        }

        public Humain()
        {

        }


        public Humain(string Nom, string Prenom) :base()
        {
            
        }
    }
}
