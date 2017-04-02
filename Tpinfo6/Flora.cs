using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public abstract class Flora
    {
        private string _variete;
        private string type;

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Méthode qui fait pousser les fruits et légumes !
        /// </summary>
        public void Pousser()
        {
            Console.WriteLine("\n\tHey ! La pousse reprend à peine !" +
                              "\n\tEncore un peu de patience .. " +
                              "\t[...]");
        }

        /// <summary>
        /// Méthode qui fait fleurir les fruits et légumes !
        /// </summary>
        public virtual void Fleurir()
        {
            Console.WriteLine("\n\tC'est le moment de la floraison ..    [...]\n" +
                              "\tBientôt la récolte");
        }

        /// <summary>
        /// Méthode indiquant l'arrivé à maturité des fruits et légumes, Miam !
        /// </summary>
        public virtual void Recolter()
        {
            Console.WriteLine("\n\tC'est le jour de la récolte ! ");
        }

        /// <summary>
        /// Méthode qui fait mourrir les arbres et plantes ..
        /// </summary>
        public virtual void Mourrir()
        {


        }




    }//End of class
}
