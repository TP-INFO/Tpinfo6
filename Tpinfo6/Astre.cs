using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe-mère abstraite Astre
    /// </summary>
    
    public abstract class Astre
    {
        //Constructeur vide
        public Astre()
        {

        }

        //Méthode abstraite pour indiquer que l'astre se lève
        abstract public void SeLever();

        //Méthode abstraite pour indiquer que l'astre se couche
        abstract public void SeCoucher();

    }
}
