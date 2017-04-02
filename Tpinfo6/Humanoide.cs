using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Humanoide : NewHumanity 
    {
        /*──────────────────|
        |     Attributs     |
        |──────────────────*/

        private string _nom;

        public new string Nom
        {
            get { return this._nom; }
            set { _nom = value; }
        }

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        public override void Mourrir()
        {
            base.Mourrir();
        }

        public override void SeDeplacer()
        {
            base.SeDeplacer();
        }


        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/

        /// <summary>
        /// Default Constructor for Humanoide Class w/ "Pepper" name
        /// </summary>
        /// <param name="Nom"></param>
        public Humanoide(string Nom)
        {
            this.Nom = "Pepper";
        }

        

    }
}
