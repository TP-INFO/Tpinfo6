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

            //ToDo : Demander User de composer son histoire en choisissant Jour, (via switch)

            Console.Write("╔═══════════════════════════════════════╗\n" +
                          "║                                       ║\n" +
                          "║                                       ║\n" +
                          "║         Welcome in Futur Farm         ║\n" +
                          "║                                       ║\n" +
                          "║                                       ║\n" +
                          "╚═══════════════════════════════════════╝\n");
            Console.WriteLine("Nous sommes en 2110, et vous allez devoir vous occuper d'une ferme ..\n");

            Console.WriteLine("Avant de commencer nous allons personnaliser votre expérience : \n");

            Soleil Sun = new Soleil();
            Sun.SeLever();

            Console.WriteLine("Quel est le prénom de votre héros ?\n");
            Humain Homme = new Humain();
            Homme.Prenom = Console.ReadLine();

            //Console.WriteLine("Quel sera le prénom de sa compagne ?\n");
            //Humain Femme = new Humain();
            //Femme.Prenom = Console.ReadLine();

            Console.WriteLine("\nVous possédez un chien, comment s'appelle-t-il ?\n");
            Chien Dog = new Chien();
            Dog.Nom = Console.ReadLine();
            Dog.RemuerLaQueue();

            Homme.SeDeplacer();






        }//End of Main
    }
}
