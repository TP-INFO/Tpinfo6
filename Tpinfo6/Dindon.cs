using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Dindon : Animal
    {
       

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Permet au Dindon de s'exprimer !
        /// </summary>
        public void Glouglouter()
        {
            Console.WriteLine("\n\tGlouglou ! GlouuuuGlou !");
        }

        /// <summary>
        /// Fais mourrir un Dindon ..
        /// </summary>
        public override void Mourrir()
        {
            base.Mourrir();
        }

        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/

        /// <summary>
        /// Constrcuteur vide d'un Dindon
        /// </summary>
        public Dindon()
        {

        }
    }
}
