using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe chien, fille de animal
    /// </summary>
    public class Chien : Animal
    {
        /// <summary>
        /// Override des méthodes seréveiller, sendormir, manger, mourir
        /// </summary>
        public override void SeRéveiller()
        {
            base.SeRéveiller();
        }
        public override void SEndormir()
        {
            base.SEndormir();
        }
        public override void Manger()
        {
            base.Manger();
        }
         public override void Mourir()
        {
            base.Mourir();
        }

        //Méthode qui renvoie le cri du chien
        public void Aboyer()
        {
            Console.WriteLine("woof!");
        }

        //Méthode qui indique que le chien court après un autre animal, appel de la méthode aboyer
        public void CourirApres(Chien chien, Animal animal)
        {
            Console.WriteLine("{0} court après {1}", chien.Nom, animal.Nom);
            chien.Aboyer();
            
        }
    }
}
