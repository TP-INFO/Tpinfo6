using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    /// <summary>
    /// Classe abstraite définissant la nouvelle humanité au 22e siècle
    /// </summary>
    public abstract class NewHumanity : IMammifere
    {
        /*──────────────────|
        |     Attributs     |
        |──────────────────*/
        private string _userChoice;
        private string _nom;

        //Variable permettant à un utilisateur de pouvoir effectuer des choix durant l'éxécution du programme
        public string UserChoice
        {
            get { return this._userChoice; }
            set { _userChoice = value; }
        }

        //Accesseurs de l'attribut _nom de la classe mère NewHumanity
        public string Nom
        {
            get { return this._nom; }
            set { _nom = value; }
        }

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Méthode général permettant de rentrer à la maison
        /// </summary>
        public virtual void RentrerChezSoi()
        {

        }

        /// <summary>
        /// Méthode général permattant de se déplaçer dans la ferme
        /// </summary>
        public virtual void SeDeplacer()
        {

        }

        /// <summary>
        /// Méthode général permettant de manger à sa faim
        /// </summary>
        public virtual void Manger()
        {

        }

        /// <summary>
        /// Méthode général permattant d'éffectuer des actions
        /// </summary>
        public virtual void ToDo()
        {

        }

        /// <summary>
        /// Méthode général permettant d'éffectuer des actions dans la maison
        /// </summary>
        public virtual void ToDoInHouse()
        {

        }

        /// <summary>
        /// Méthode général permettant à un Objet instancié de mourrir
        /// </summary>
        public virtual void Mourrir()
        {
            Console.WriteLine("\n\tOh non ! {0} est mort ! Comment allez vous faire ?", Nom);
        }

        /// <summary>
        /// Méthode permettant à un humain de s'endormir !
        /// </summary>
        public virtual void Dormir()
        {
            Console.WriteLine("\n\t{0} va se coucher.", Nom);
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\t[...]");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\t{0} s'endort paisiblement *zZz ZzzZ zzZz*", Nom);
        }


    }//End Of class
}
