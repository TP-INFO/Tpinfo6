using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Soleil : Astre
    {

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        public override void SeLever()
        {
            Console.WriteLine("Le jour se lève ..\n" +
                   "Et le soleil illumine la ferme.\n");
            nuit = false;
        }

        public override void SeCoucher() 
        {
            Console.WriteLine("Le jour se couche ..\n");
            nuit = true;
        }

        public Soleil()
        {

        }

    }//End of Class
}
