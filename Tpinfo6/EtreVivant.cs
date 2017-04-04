using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe mère publique et abstraite 
    /// </summary>
    public abstract class EtreVivant
    {
        //Constructeur vide
        public EtreVivant()
        {

        }
        //Méthode virtuelle mourir
        public virtual void Mourir(EtreVivant ev)
        {
            ev = null;
        }
    }
}
