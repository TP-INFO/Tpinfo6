using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe publique, fille de Astre
    /// </summary>
    public class Lune : Astre
    {
        //Constructeur vide
        public Lune()
        {
            
        }

        /// <summary>
        /// Override des méthodes de Astre
        /// </summary>
        public override void SeLever()
        {
            Console.WriteLine("La lune se lève");
        }
        public override void SeCoucher()
        {
            Console.WriteLine("La lune se couche");
        }

    }
}
