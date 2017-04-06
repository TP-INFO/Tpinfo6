using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    class DerouleJournee
    {


        public static void ActionsJournee()
        {
            //Instanciation des éléments indispensables à la vie de la ferme
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
            Clone clone2 = clone;
            clone2.Nom = "esclave";
            Cerisier cerisier = new Cerisier();
            cerisier.TypeVeg = "cerisier";
            cerisier.NNbreFruits = 1;
            int cerises = (int)cerisier.NNbreFruits;
            Abricotier abricotier = new Abricotier();
            abricotier.TypeVeg = "abricotier";
            abricotier.NNbreFruits = 6;
            int abricots = (int)abricotier.NNbreFruits;
            Maïs maïs = new Maïs();
            maïs.TypeVeg = "maïs";
            Chou chou = new Chou();
            chou.TypeVeg = "chou";

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
            abricotier.PousseNouveauxFruits(1.7);
            cerisier.PousseNouveauxFruits(1.6);
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
