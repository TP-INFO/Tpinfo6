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
    public class Cerisier : Végétal
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
        public override void Mourir()
        {
            base.Mourir();
        }
    }
}
