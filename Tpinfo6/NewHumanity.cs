using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public abstract class NewHumanity
    {
        /*──────────────────|
        |     Attributs     |
        |──────────────────*/

        private string _nom;
        private string _prenom;
        private int _age;

        public string Nom
        {
            get { return this._nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return this._prenom; }
            set { _prenom = value; }
        }

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Méthode permettant de créer une histoire personnalisée 
        /// ....
        /// </summary>
        //public virtual void ToBegin() //ToDo Utilité ?
        //{
        //    Console.Write("╔═══════════════════════════════════════╗\n" +
        //                  "║                                       ║\n" +
        //                  "║                                       ║\n" +
        //                  "║         Welcome in Futur Farm         ║\n" +
        //                  "║                                       ║\n" +
        //                  "║                                       ║\n" +
        //                  "╚═══════════════════════════════════════╝\n");
        //}

        public virtual void SeDeplacer() //Voir si ces méthodes ne peuvent pas être coupler avec : Animal
        {
            
        }

        public virtual void Manger()
        {

        }

        public virtual void ToDo()
        {

        }


    }//End Of class
}
