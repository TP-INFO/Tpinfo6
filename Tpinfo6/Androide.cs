using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Androide : NewHumanity 
    {
        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/


        public override void SeDeplacer()
        {
            base.SeDeplacer();
        }


        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/

        /// <summary>
        /// Default Constructor for Humanoide Class w/ "Pepper" name
        /// </summary>
        /// <param name="Nom"></param>
        public Androide(string Nom)
        {
            this.Nom = "Pepper";
        }

        

    }
}
