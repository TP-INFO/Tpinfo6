using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    /// <summary>
    /// Classe abstraite regroupant attributs et méthodes des outils d'ont a besoin un fermier
    /// </summary>
    public abstract class Tools
    {
        private string _nom;

        /// <summary>
        /// Accesseur du nom d'un outil
        /// </summary>
        public string Nom
        {
            get { return this._nom; }
            set { this._nom = value; }
        }

        /// <summary>
        /// Méthode général permettant de tuer un animal à l'aide d'un outils
        /// </summary>
        public virtual void TuerAnimal()
        {

        }

    }//End of class
}
