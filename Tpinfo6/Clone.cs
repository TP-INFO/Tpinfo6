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
            throw new NotImplementedException();
        }

        /// <summary>
        /// Méthode qui permet à un Clone de RentrerChezSoi()
        /// </summary>
        public void RentrerChezSoi()
        {
            throw new NotImplementedException();
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
