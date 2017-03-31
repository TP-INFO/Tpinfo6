using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe abricotier fille de Végétal
    /// </summary>
    
    public class Abricotier : Végétal
    {
        //Constructeur vide
        public Abricotier()
        {

        }

        /// <summary>
        /// Override des méthodes Pousser et Mourir de Végétal et Etre vivant
        /// </summary>
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
