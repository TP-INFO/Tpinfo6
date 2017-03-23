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
            string dateCoucherLuneLundi = "2112-05-05T07:07:07";
            string dateLeverLuneLundi = "2112-05-05T18:18:18";
            DateTime dll = Convert.ToDateTime(dateLeverLuneLundi);
            DateTime dcl = Convert.ToDateTime(dateCoucherLuneLundi);
            Lune lune = new Lune(dll, dcl);


            string dateCoucherSoleilLundi = "2112-05-05T20:20:20";
            string dateLeverSoleilLundi = "2112-05-05T06:06:06";
            DateTime dls = Convert.ToDateTime(dateLeverSoleilLundi);
            DateTime dcs = Convert.ToDateTime(dateCoucherSoleilLundi);
            Soleil soleil = new Soleil(dls, dcs);

            int jour = (int)Jours.Lundi;
            Console.WriteLine();
            switch (jour)
            {
                case 1:
                    soleil.SeLever(dls);
                    dindon.SeRéveiller();
                    dindon.Glouglouter();
                    chien.SeRéveiller();
                    chien.Aboyer();
                    chevre.SeRéveiller();
                    chevre.Beler();
                    lune.SeCoucher(dcl);
                    couteau.TuerAnimal(chevre);
                    lune.SeLever(dll);
                    soleil.SeCoucher(dcs);
                    jour++;

                    break;
                case 2:
                    soleil.SeLever(dls);
                    chien.SeRéveiller();
                    chien.Aboyer();
                    chevre.SeRéveiller();
                    lune.SeCoucher(dcl);

                    lune.SeLever(dll);
                    soleil.SeCoucher(dcs);
                    jour++;
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                default:
                    break;
            }
        }
    }
}
