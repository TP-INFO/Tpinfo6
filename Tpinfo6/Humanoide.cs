using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Humanoide : NewHumanity 
    {
        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        public override void Mourrir()
        {
            base.Mourrir();
        }

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
        public Humanoide(string Nom)
        {
            this.Nom = "Pepper";
        }

        

    }
}
