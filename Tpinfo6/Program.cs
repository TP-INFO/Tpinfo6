using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    class Program
    {
            enum Jours
        {
            Lundi = 1,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        enum Moment
        {
            Jour,
            Nuit
        }

        static void Main(string[] args)
        {

            //ToDo : Demander User de composer son histoire en choisissant Jour, (via switch)

            Soleil Sun = new Soleil();
            Sun.SeLever();

            Console.Write("╔═════════════════════════════════╗\n" +
                          "║                                 ║\n" +
                          "║                                 ║\n" +
                          "║                                 ║\n" +
                          "║                                 ║\n" +
                          "║                                 ║\n" +
                          "╚═════════════════════════════════╝\n");


            Console.WriteLine("Quel est le prénom de votre héros ?\n");
            Humain Homme = new Humain();
            Homme.Prenom = Console.ReadLine();
            //Console.WriteLine("Quel sera le prénom de sa compagne ?\n");
            //Humain Femme = new Humain();
            //Femme.Prenom = Console.ReadLine();
            Homme.SeDeplacer();
            //Homme.ToDo();

        }
    }
}
