using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public abstract class Tools
    {
        private string _nom;

        public string Nom
        {
            get { return this._nom; }
            set { this._nom = value; }
        }

        public virtual void TuerAnimal()
        {

        }

    }//End of class
}
