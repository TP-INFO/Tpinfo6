using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe chèvre, fille de la classe Animal
    /// </summary>
    public class Chevre : Animal
    {
        /// <summary>
        /// Override des méthodes seréveiller, sendormir, sedéplacer, manger et mourir
        /// </summary>
        public override void SeRéveiller()
        {
            base.SeRéveiller();
        }

        public override void SEndormir()
        {
            base.SEndormir();
        }
        
        public override void SeDeplacer(string destination)
        {
            base.SeDeplacer(destination);
        }

        public override void Manger()
        {
            base.Manger();
        }

        public override void Mourir(EtreVivant ev)
        {
            base.Mourir(ev);
           
        }

        //Méthode indiquant que l'animal crie
        public void Beler()
        {
            Console.WriteLine("bêêêêêêê!");
        }
    }
}
