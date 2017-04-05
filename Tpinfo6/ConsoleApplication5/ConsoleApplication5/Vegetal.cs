using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public abstract class Vegetal
    {

      
        /// <summary>
        /// Méthode abstraite pour faire pousser fruits/légumes
        /// </summary>
        /// <returns>Renvoie une quantité aléatoire de fruits/légumes</returns>
        public abstract int Pousser();
        /// <summary>
        /// Redéfinition de ToString pour occulter le namespace.
        /// </summary>
        /// <returns>
        /// string avec le nom de la classe.
        /// </returns>
        public override string ToString()
        {
            string cs = "ConsoleApplication5.";
            
            return base.ToString().Remove(0,20);
        }
        /// <summary>
        /// Redéfinition de equals : même objet si même type.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>true if same type</returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType()==base.GetType())
            {
                return true;
            }
            return false;
        }

    }

}
