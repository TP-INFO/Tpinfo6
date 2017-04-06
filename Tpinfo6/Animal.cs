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

        private string _type;

        public string Type
        {
            get { return this._type; }
            set { _type = value; }
        }

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        public void SeDeplacer()
        {

        }

        /// <summary>
        /// Méthode qui fait Dormir un Animal
        /// </summary>
        /// <param name="ani"></param>
        public virtual void AnimalDormir(Animal ani)
        {
            Console.WriteLine("\n\t{0} va se coucher dans son panier..", ani.Nom);
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\t[...]");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\t{0} fais 3 tours dans son panier et s'endort paisiblement *zZz ZzzZ zzZz*", ani.Nom);
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
