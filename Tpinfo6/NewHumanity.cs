using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public abstract class NewHumanity : IMammifere
    {
        /*──────────────────|
        |     Attributs     |
        |──────────────────*/
        private string _userChoice;
        private string _nom;
        private string _prenom;

        public string UserChoice
        {
            get { return this._userChoice; }
            set { _userChoice = value; }
        }

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

        public virtual void RentrerChezSoi()
        {

        }

        public virtual void SeDeplacer()
        {

        }

        public virtual void Manger()
        {

        }

        public virtual void ToDo()
        {

        }

        public virtual void ToDoInHouse()
        {

        }

        public virtual void Mourrir()
        {

        }


    }//End Of class
}
