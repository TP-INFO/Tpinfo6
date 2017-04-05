using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    static class Soleil
    {
        /// <summary>
        /// Détermine si il fait jour ou non d'après l'heure actuelle.
        /// </summary>
        /// <param name="date"></param>
        /// <returns>
        /// Si heure il est entre 6 et 18h il fait jour, sinon nuit
        /// </returns>
        public static bool Cycle(DateTime date)
        {
            if (date.Hour > 6 && date.Hour < 18)return true;  
            else return false;
        }
    }
}
