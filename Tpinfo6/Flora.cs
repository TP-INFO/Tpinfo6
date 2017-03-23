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
            Console.WriteLine("Encore un peu de patience .." +
                              "[...]");
        }

        /// <summary>
        /// Méthode qui fait fleurir les fruits et légumes !
        /// </summary>
        public void Fleurir()
        {
            Console.WriteLine("C'est le moment de la floraison .." +
                              "[...]" +
                              "Bientôt la récolte");

        }

        /// <summary>
        /// Méthode indiquant l'arrivé à maturité des fruits et légumes, Miam !
        /// </summary>
        public void Recolter()
        {
            Console.WriteLine("Les "/*Fruits et Legumes*/ + " sont prêt a être récoltés ! "); //Permettre la personnalisation selon fruit et légumes ..
        }

        /// <summary>
        /// Méthode qui fait mourrir les arbres et plantes ..
        /// </summary>
        public void Mourrir()
        {


        }




    }//End of class
}
