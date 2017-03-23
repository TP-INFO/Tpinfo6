using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_22_TP6
{

    enum Jours
    {
        Lundi,
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
            Chien mirza = new Chien();
            Chevre biquette = new Chevre();

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

            Jours jour = Jours.Lundi;

            switch (jour)
            {
                case Jours.Lundi:
                    soleil.SeLever(dls);
                    mirza.SeRéveiller();
                    mirza.Aboyer();
                    lune.SeCoucher(dcl);

                    lune.SeLever(dll);
                    soleil.SeCoucher(dcs);
                    jour = Jours.Mardi;
                    break;
                case Jours.Mardi:

                    break;
                case Jours.Mercredi:
                    break;
                case Jours.Jeudi:
                    break;
                case Jours.Vendredi:
                    break;
                case Jours.Samedi:
                    break;
                case Jours.Dimanche:
                    break;
                default:
                    break;
            }
        }
    }
}
