using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    /// <summary>
    /// Définit les taches quotidiennes de la ferme durant le jour et la nuit.
    /// </summary>
    public interface IQuotidien
    {
        /// <summary>
        /// Nourrir et arroser.
        /// </summary>
        void Nourrir();

        /// <summary>
        /// Traiter les infections virales.
        /// </summary>
        void Soigner();

        /// <summary>
        /// Récolter les fruits légumes et le lait des chèvres.
        /// </summary>
        void Recolter();
    }
}