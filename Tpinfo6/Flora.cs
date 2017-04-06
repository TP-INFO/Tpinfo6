using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    /// <summary>
    /// Classe abstraite définissant l'ensemble de la Flore dans notre ferme
    /// </summary>
    public abstract class Flora
    {
        private string _variete;
        private string type;

        /// <summary>
        /// Accesseur du type de variété pour un végétal
        /// </summary>
        public string Variete
        {
            get { return this._variete; }
            set { this._variete = value; }
        }

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Méthode qui fait pousser les fruits et légumes !
        /// </summary>
        public virtual void Pousser()
        {
            Console.WriteLine("\n\tHey ! La pousse reprend à peine pour le {0} !", Variete +
                              "\n\tEncore un peu de patience .. " +
                              "\t[...]");
        }

        /// <summary>
        /// Méthode qui fait fleurir les fruits et légumes !
        /// </summary>
        /// <param>Variete</param>
        public virtual void Fleurir()
        {
            Console.WriteLine("\n\tC'est le moment de la floraison ..    [...]\n" +
                              "\tBientôt la récolte des {0}", Variete);
        }

        /// <summary>
        /// Méthode indiquant l'arrivé à maturité des fruits et légumes, Miam !
        /// </summary>
        /// <param>Variete</param>
        public virtual void Recolter()
        {
            Console.WriteLine("\n\tC'est le jour de la récolte des {0} ! ", Variete);
        }

        /// <summary>
        /// Méthode général qui fait mourrir les arbres et plantes ..
        /// </summary>
        public virtual void Mourrir()
        {


        }


    }//End of class
}
