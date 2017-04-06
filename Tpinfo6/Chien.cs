using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    /// <summary>
    /// Classe publique permettant de créer un Chien et de lui attribuer des méthodes
    /// </summary>
    public class Chien : Animal
    {
        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Permet au Chien d'aboyer !
        /// </summary>
        public void Aboyer()
        {
            Console.WriteLine("\n\tWouaf ! Woof !");
        }

        /// <summary>
        /// Permet au Chien de remuer la queue !
        /// </summary>
        public void RemuerLaQueue()
        {
            Console.WriteLine("\n\t" + Nom + " semble être heureux d'être avec vous !\n" +
                             "\t" + Nom + " remue la queue ..");
            System.Threading.Thread.Sleep(1000);
        }

        /// <summary>
        /// Permet à un chien de se lancer à la poursuite d'un autre animal !
        /// </summary>
        public void Poursuivre(Chien chien, Animal animal)
        {
            chien.Aboyer();
            Console.WriteLine("\n\t{0} court après {1}, attention aux dégats !", chien.Nom, animal.Nom);
        }

        /// <summary>
        /// Permet à un animal de se coucher après une belle journée !
        /// </summary>
        /// <param name="ani"></param>
        public override void AnimalDormir(Animal ani)
        {
            Console.WriteLine("\n\t{0} va se coucher dans son panier..", ani.Nom);
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\t[...]");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\t{0} fais 3 tours dans son panier et s'endort paisiblement *zZz ZzzZ zzZz*", ani.Nom);
        }

        /// <summary>
        /// Méthode faisant mourrir un chien ..
        /// </summary>
        public override void Mourrir()
        {
            Console.WriteLine("\n\tVotre chien, {0} est mort !!", Nom);
            Nom = null;
        }

        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/

        /// <summary>
        /// Default Constructor of Class Chien
        /// </summary>
        public Chien()
        {

        }


    }//End of Class
}
