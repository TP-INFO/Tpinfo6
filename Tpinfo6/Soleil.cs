using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    /// <summary>
    /// Classe publique représentant le Soleil
    /// </summary>
    public class Soleil : Astre
    {

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Permet au Soleil de SeLever()
        /// </summary>
        public override void SeLever()
        {
            Console.WriteLine("Le jour se lève ..\n" +
                   "Et le soleil illumine la ferme.\n");
            nuit = false;
        }

        /// <summary>
        /// Permet au Soleil de SeCoucher()
        /// </summary>
        public override void SeCoucher() 
        {
            Console.WriteLine("Le jour se couche ..\n");
            nuit = true;
        }

        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/

        /// <summary>
        /// Constructeur d'un soleil
        /// </summary>
        public Soleil()
        {

        }

    }//End of Class
}
