using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Chevre : Animal
    {
        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Permet a la Chèvre de s'exprimer !
        /// </summary>
        public void Beler()
        {
            Console.WriteLine("Bééééé ! Bwéééé !");
        }

        /// <summary>
        /// Fais mourrir une Chèvre
        /// </summary>
        public override void Mourrir()
        {
            base.Mourrir();
        }

        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/

        /// <summary>
        /// Constructeur vide d'une Chèvre
        /// </summary>
        public Chevre()
        {

        }
    }
}
