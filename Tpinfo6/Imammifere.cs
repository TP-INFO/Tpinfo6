using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    /// <summary>
    /// Interface implémentant des méthodes pour tous les êtres "vivants" de la ferme
    /// </summary>
    interface IMammifere
    {
        /// <summary>
        /// Méthode définissant un comportement == Rentrer chez soi
        /// </summary>
        void RentrerChezSoi();

        /// <summary>
        /// Méthode permettant à un être de se déplaçer
        /// </summary>
        void SeDeplacer(); 

        /// <summary>
        /// Méthode permettant à un être de manger
        /// </summary>
        void Manger();

        /// <summary>
        /// Méthode définissant un comportement == Mourir
        /// </summary>
        void Mourrir();

    }
}
