using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public struct Clone : IMammifere
    {
        /// <summary>
        /// Accesseur du Nom pour la Class Clone
        /// </summary>
        public string Nom { get; set; }

       /*──────────────────|
       |      Méthodes     |
       |──────────────────*/

        /// <summary>
        /// Méthode qui permet à un Clone de Manger()
        /// </summary>
        public void Manger()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode qui permet à un Clone de Mourrir()
        /// </summary>
        public void Mourrir()
        {
            Console.WriteLine("Votre Clone {0} est mort dans d'atroce souffrance !", Nom);
        }

        /// <summary>
        /// Méthode qui permet à un Clone de RentrerChezSoi()
        /// </summary>
        public void RentrerChezSoi()
        {
            Console.WriteLine("{0} rentre chez lui", Nom);
        }

        /// <summary>
        /// Méthode qui permet à un Clone de SeDéplaçer()
        /// </summary>
        public void SeDeplacer()
        {
            throw new NotImplementedException();
        }

        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/

        /// <summary>
        /// Constrcuteur Clone avec un nom comme argument
        /// </summary>
        /// <param name="nom"></param>
        public Clone(string nom)
        {
            Nom = nom;
        }

    }
}
