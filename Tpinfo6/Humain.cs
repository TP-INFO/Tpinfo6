using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// CLasse publique, fille de animal
    /// </summary>
    public class Humain : Animal
    {
        /// <summary>
        /// Override des méthodes de etrevivant et animal : seréveiller, sendormir, manger et mourir
        /// </summary>
        public override void SeRéveiller()
        {
            base.SeRéveiller();
        }
        public override void SEndormir()
        {
            base.SEndormir();
        }
        public override void Manger()
        {
            base.Manger();
        }
        public override void Mourir()
        {
            base.Mourir();
        }
    }
}
