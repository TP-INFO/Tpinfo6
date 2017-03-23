using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Chien : Animal
    {
        /*──────────────────|
        |     Attributs     |
        |──────────────────*/

        private string _nom;

        public string Nom
        {
            get { return this._nom; }
            set { _nom = value; }
        }

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Permet au Chien d'aboyer !
        /// </summary>
        public void Aboyer()
        {
            Console.WriteLine("Wouaf ! Woof !");
        }

        /// <summary>
        /// Permet au Chien de remuer la queue !
        /// </summary>
        public void RemuerLaQueue()
        {
            Console.WriteLine(Nom + " semble être heureux d'être avec vous !\n");
            Console.WriteLine(Nom + " remue la queue ..");
        }

        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/

        /// <summary>
        /// Default Constructor of Class Chien
        /// </summary>
        public Chien()
        {

        }
    }
}
