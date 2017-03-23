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


            string dateCoucherLuneLundi = "2112-05-05T10:10:10";
            string dateLeverLuneLundi = "2112-05-05T18:18:18";
            DateTime dll = Convert.ToDateTime(dateLeverLuneLundi);
            DateTime dcl = Convert.ToDateTime(dateCoucherLuneLundi);
            Lune lune = new Lune(dll, dcl);
            

            string dateCoucherSoleilLundi = "2112-05-05T20:20:20";
            string dateLeverSoleilLundi = "2112-05-05T06:06:06";
            DateTime dls = Convert.ToDateTime(dateLeverSoleilLundi);
            DateTime dcs = Convert.ToDateTime(dateCoucherSoleilLundi);
            Soleil soleil = new Soleil(dls, dcs);
            TimeSpan ts1 = new TimeSpan(1, 0, 3, 0);

            int jour = (int)Jours.Lundi;
            Console.WriteLine();
            while (jour!=7)
            {
                switch (jour)
                {
                    case 1:
                        Console.WriteLine(Jours.Lundi);
                        soleil.SeLever(dls);
                        dindon.SeRéveiller();
                        dindon.Glouglouter();
                        chien.SeRéveiller();
                        chien.Aboyer();
                        chevre.SeRéveiller();
                        chevre.Beler();
                        femme.SeRéveiller();
                        lune.SeCoucher(dcl);
                        mari.SeRéveiller();
                        chien.CourirApres(chien, chevre);
                        chien.Manger();
                        chien.CourirApres(chien, dindon);
                        lune.SeLever(dll);
                        soleil.SeCoucher(dcs);
                        chien.SEndormir();
                        dindon.SEndormir();
                        chevre.SEndormir();

                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine(Jours.Mardi);
                        soleil.SeLever(dls);
                        dindon.SeRéveiller();
                        dindon.Glouglouter();
                        chien.SeRéveiller();
                        chien.Aboyer();
                        chevre.SeRéveiller();
                        chevre.Beler();
                        femme.SeRéveiller();
                        lune.SeCoucher(dcl);
                        mari.SeRéveiller();
                        chien.CourirApres(chien, chevre);
                        chien.Manger();
                        chien.CourirApres(chien, dindon);
                        lune.SeLever(dll);
                        soleil.SeCoucher(dcs);
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine(Jours.Mercredi);
                        soleil.SeLever(dls);
                        dindon.SeRéveiller();
                        dindon.Glouglouter();
                        chien.SeRéveiller();
                        chien.Aboyer();
                        chevre.SeRéveiller();
                        chevre.Beler();
                        femme.SeRéveiller();
                        lune.SeCoucher(dcl);
                        mari.SeRéveiller();
                        chien.CourirApres(chien, chevre);
                        chien.Manger();
                        chien.CourirApres(chien, dindon);
                        lune.SeLever(dll);
                        soleil.SeCoucher(dcs);
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine(Jours.Jeudi);
                        soleil.SeLever(dls);
                        dindon.SeRéveiller();
                        dindon.Glouglouter();
                        chien.SeRéveiller();
                        chien.Aboyer();
                        chevre.SeRéveiller();
                        chevre.Beler();
                        femme.SeRéveiller();
                        lune.SeCoucher(dcl);
                        mari.SeRéveiller();
                        chien.CourirApres(chien, chevre);
                        chien.Manger();
                        chien.CourirApres(chien, dindon);
                        lune.SeLever(dll);
                        soleil.SeCoucher(dcs);
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine(Jours.Vendredi);
                        soleil.SeLever(dls);
                        dindon.SeRéveiller();
                        dindon.Glouglouter();
                        chien.SeRéveiller();
                        chien.Aboyer();
                        chevre.SeRéveiller();
                        chevre.Beler();
                        femme.SeRéveiller();
                        lune.SeCoucher(dcl);
                        mari.SeRéveiller();
                        chien.CourirApres(chien, chevre);
                        chien.Manger();
                        chien.CourirApres(chien, dindon);
                        lune.SeLever(dll);
                        soleil.SeCoucher(dcs);
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine(Jours.Samedi);
                        soleil.SeLever(dls);
                        dindon.SeRéveiller();
                        dindon.Glouglouter();
                        chien.SeRéveiller();
                        chien.Aboyer();
                        chevre.SeRéveiller();
                        chevre.Beler();
                        femme.SeRéveiller();
                        lune.SeCoucher(dcl);
                        mari.SeRéveiller();
                        chien.CourirApres(chien, chevre);
                        chien.Manger();
                        chien.CourirApres(chien, dindon);
                        lune.SeLever(dll);
                        soleil.SeCoucher(dcs);
                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine(Jours.Dimanche);
                        soleil.SeLever(dls);
                        dindon.SeRéveiller();
                        dindon.Glouglouter();
                        chien.SeRéveiller();
                        chien.Aboyer();
                        chevre.SeRéveiller();
                        chevre.Beler();
                        femme.SeRéveiller();
                        lune.SeCoucher(dcl);
                        mari.SeRéveiller();
                        chien.CourirApres(chien, chevre);
                        chien.Manger();
                        chien.CourirApres(chien, dindon);
                        lune.SeLever(dll);
                        soleil.SeCoucher(dcs);
                        break;
                    default:
                        break;
                }
                jour++;
            }
        }
    }
}
