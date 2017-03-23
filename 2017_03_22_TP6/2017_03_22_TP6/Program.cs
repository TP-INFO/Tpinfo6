using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_22_TP6
{
    
    enum Jours
    {
        Lundi=1,
        Mardi,
        Mercredi,
        Jeudi,
        Vendredi,
        Samedi,
        Dimanche
    }
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
            

            string dateDernierCoucherSoleil = "2112-05-11T20:20:20";
            string datePremierLeverSoleil = "2112-05-05T06:06:06";
            DateTime dpls = Convert.ToDateTime(datePremierLeverSoleil);
            DateTime ddcs = Convert.ToDateTime(dateDernierCoucherSoleil);
            Soleil soleil = new Soleil();

            int jour = (int)Jours.Lundi;
            Console.WriteLine();
            while (jour!=7)
            {
                switch (jour)
                {
                    case 1:
                        Console.WriteLine(Jours.Lundi);
                        soleil.PremierLever(dpls);
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
                        break;
                    case 2:
                        Console.WriteLine(Jours.Mardi);
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
                        break;
                    case 3:
                        Console.WriteLine(Jours.Mercredi);
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
                        break;
                    case 4:
                        Console.WriteLine(Jours.Jeudi);
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
                        break;
                    case 5:
                        Console.WriteLine(Jours.Vendredi);
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
                        break;
                    case 6:
                        Console.WriteLine(Jours.Samedi);
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
                        break;
                    case 7:
                        Console.WriteLine(Jours.Dimanche);
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
                        chien.Manger();
                        chien.CourirApres(chien, dindon);
                        lune.SeLever();
                        soleil.DernierCoucher(ddcs);
                        chien.SEndormir();
                        dindon.SEndormir();
                        chevre.SEndormir();
                        mari.SEndormir();
                        femme.SEndormir();
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
                jour++;
            }
        }
    }
}
