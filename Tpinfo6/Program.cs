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
            //Instanciation des objets nécessaires à la vie de la ferme
        
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
            Cerisier cerisier = new Cerisier();
            cerisier.TypeVeg = "cerisier";
            Abricotier abricotier = new Abricotier();
            abricotier.TypeVeg = "abricotier";
            Maïs maïs = new Maïs();
            maïs.TypeVeg = "maïs";
            Chou chou = new Chou();
            chou.TypeVeg = "chou";

            //Déclaration de la variable de type int: jour, initialisée à la valeur de Jours.Lundi
            int jour = (int)Jours.Lundi;
            Console.WriteLine();
            while (jour!=8)
            {
                //Switch permettant d'indiquer les activité se déroulant sur la ferme, jour par jour
                switch (jour)
                {
                    case 1:
                        Console.WriteLine(Jours.Lundi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari, chou, maïs, abricotier, cerisier);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine(Jours.Mardi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari, chou, maïs, abricotier, cerisier);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine(Jours.Mercredi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari, chou, maïs, abricotier, cerisier);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine(Jours.Jeudi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari, chou, maïs, abricotier, cerisier);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine(Jours.Vendredi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari, chou, maïs, abricotier, cerisier);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine(Jours.Samedi);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari, chou, maïs, abricotier, cerisier);
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine(Jours.Dimanche);
                        ActionsQuotidiennes(soleil, lune, clone, chien, chevre, dindon, femme, mari, chou, maïs, abricotier, cerisier);
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
                //Incrémentation de jour, pour dérouler la semaine, jusqu'au dimanche
                jour++;
            }
        }

        //Méthode statique indiquant le déroulement d'une journée type
        public static void ActionsQuotidiennes
            (Soleil soleil, Lune lune, Clone clone, Chien chien, 
            Chevre chevre, Dindon dindon, Humain femme, Humain mari,
            Chou chou, Maïs maïs, Abricotier abricotier, Cerisier cerisier)
        {
            soleil.SeLever();
            cerisier.Pousser();
            abricotier.Pousser();
            maïs.Pousser();
            chou.Pousser();
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
            clone.SeDeplacer("cerisier");
            clone.SeDeplacer("abricotier");
            clone.SeDeplacer("maïs");
            clone.SeDeplacer("chou");
            Console.WriteLine();
        }
    }
}
