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

        public void Manger()
        {

        }

        public virtual void Mourrir()
        {

        }

        public void RentrerChezSoi()
        {

        }
    }//End of Class
}
