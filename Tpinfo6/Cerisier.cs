using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe cerisier, fille de végétal
    /// </summary>
    public class Cerisier : ArbreFruitier
    {
        //Constructeur vide
        public Cerisier()
        {

        }

        //Override de la méthode pousser
        public override void Pousser()
        {
            base.Pousser();
        }

        //Override de la méthode mourir
        public override void Mourir(EtreVivant ev)
        {
            base.Mourir(ev);
        }

        public override void PousseNouveauxFruits(int tauxCroissance)
        {
            base.PousseNouveauxFruits(tauxCroissance);
            Console.WriteLine("Chouette, plein de nouvelles cerises");
        }
    }
}
