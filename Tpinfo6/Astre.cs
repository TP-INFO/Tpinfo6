using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    /// <summary>
    /// Classe abstraite représentant les Astres pour rendre la ferme plus réaliste
    /// </summary>
    public abstract class Astre
    {
        /*──────────────────|
        |     Attributs     |
        |──────────────────*/

        public bool nuit = true;


        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Méthode général permettant à un Astre de se lever
        /// </summary>
        public virtual void SeLever()
        {

        }

        /// <summary>
        /// Méthode général permettant à un Astre de se coucher
        /// </summary>
        public virtual void SeCoucher()
        {
        }





    }//End of Class
}
