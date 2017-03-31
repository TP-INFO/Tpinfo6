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
    public class Soleil : Astre
    {
        //Constructeur vide
        public Soleil()
        {
           
        }

        /// <summary>
        /// Override des méthodes de Astre
        /// </summary>
        public override void SeLever()
        {
            Console.WriteLine("Le soleil se lève"); 
        }
        public override void SeCoucher()
        {
            Console.WriteLine("Le soleil se couche");
        }
    }
}
