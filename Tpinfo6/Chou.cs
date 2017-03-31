using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe chou, fille de Végétal, avec constructeur et méthodes
    /// </summary>
    public class Chou : Végétal
    {
        //Constructeur vide
        public Chou()
        {

        }

        //Override des méthodes Pousser, de végétal, et Mourir, de etrevivant
        public override void Pousser()
        {
            base.Pousser();
        }

        public override void Mourir()
        {
            base.Mourir();
        }
    }
}
