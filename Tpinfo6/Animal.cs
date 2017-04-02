using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public abstract class Animal : IMammifere
    {
        private string _nom;

        public string Nom
        {
            get { return this._nom; }
            set { _nom = value; }
        }

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        public void SeDeplacer()
        {

        }

        /// <summary>
        /// Fais manger un Animal
        /// </summary>
        public void Manger()
        {
            Console.WriteLine("\n\tVotre {0} se régale : Chomp, Chomp !", Nom);
        }

        /// <summary>
        /// Méthode faisant mourrir un animal
        /// </summary>
        /// <param>Nom</param>
        public virtual void Mourrir()
        {
            Console.WriteLine("\n\tVotre {0} est mort, paix à son âme !", Nom);
        }

        public void RentrerChezSoi()
        {

        }
    }//End of Class
}
