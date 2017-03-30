using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{

    class Program
    {
        public static void Main(string[] args)
        {
            Chien chien = new Chien();
            chien.Nom = "mirza";
            Chevre chevre = new Chevre();
            chevre.Nom = "biquette";
            Dindon dindon = new Dindon();
            dindon.Nom = "dindidounette";
            Couteau couteau = new Couteau();
            couteau.Type = "opinelle";
            Humain femme = new Humain();
            femme.Nom = "Gertrude";
            Humain mari = new Humain();
            mari.Nom = "Gustave";
            Lune lune = new Lune();
            Soleil soleil = new Soleil();
            Clone clone = new Clone("bobonne");


            int jour = (int)Jours.Lundi;
            Console.WriteLine();
            while (jour!=8)
            {
                switch (jour)
                {
                    case 1:
                        Console.WriteLine(Jours.Lundi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine(Jours.Mardi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine(Jours.Mercredi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine(Jours.Jeudi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine(Jours.Vendredi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine(Jours.Samedi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari);
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine(Jours.Dimanche);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari);
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
                jour++;
            }
        }


        public static void ActionsQuotidiennes
            (Soleil soleil, Lune lune, Clone clone, Chien chien, Chevre chevre, Dindon dindon, Humain femme, Humain mari)
        {
            soleil.SeLever();
            dindon.SeRéveiller();
            dindon.Glouglouter();
            chien.SeRéveiller();
            chien.Aboyer();
            chevre.SeRéveiller();
            chevre.Beler();
            femme.SeRéveiller();
            lune.SeCoucher();
            mari.SeRéveiller();
            chien.CourirApres(chien, chevre);
            chien.SeDeplacer("gamelle");
            chien.Manger();
            chien.CourirApres(chien, dindon);
            lune.SeLever();
            soleil.SeCoucher();
            chien.SEndormir();
            dindon.SEndormir();
            chevre.SEndormir();
            mari.SEndormir();
            femme.SEndormir();
            Console.WriteLine();
        }
    }
}
