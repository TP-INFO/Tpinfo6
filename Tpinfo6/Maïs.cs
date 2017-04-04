using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe publique, fille de végétal
    /// </summary>
    public class Maïs : Végétal
    {
        //Constructeur vide
        public Maïs()
        {

        }
        //OVerride de la méthode pousser de végétal
        public override void Pousser()
        {
            base.Pousser();
        }
        //Override de la méthode mourir de Etrevivant
        public override void Mourir(EtreVivant ev)
        {
            base.Mourir(ev);
        }
    }
}
