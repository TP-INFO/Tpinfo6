using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe abstraite animal, fille de EtreVivant et implémentant la méthode de ISeDeplacer
    /// </summary>
    /// 
    public abstract class Animal : EtreVivant, ISeDeplacer
    {
        /// <summary>
        /// Nom de l'animal, variable protected
        /// </summary>
        protected string _nom;

        /// <summary>
        /// Accesseur du nom de l'animal
        /// </summary>
        public string Nom
        {
            get
            {
                return _nom;
            }
            set
            {
                _nom = value;
            }
        }

        /// <summary>
        /// Implémentation des méthodes propres à Animal et à ses classes filles
        /// </summary>
        
        //Méthode qui indique que l'animal se réveille
        public virtual void SeRéveiller()
        {
            Console.WriteLine("{0} se réveille!", Nom);
        }
        //Méthode qui indique que l'animal s'endort
        public virtual void SEndormir()
        {
            Console.WriteLine("{0} s'endort: zzzzz!", Nom);
        }
        //Méthode qui indique que l'animal mange
        public virtual void Manger()
        {
            Console.WriteLine("{0} mange : 'chomp, chomp'", Nom);
        }
        //Méthode qui indique que l'animal se déplace vers une destination
        public virtual void SeDeplacer(string destination)
        {
            Console.WriteLine("{0} se déplace vers {1}", Nom, destination);
        }

        /// <summary>
        /// Override de la méthode mourir de EtreVivant
        /// </summary>
        public override void Mourir(EtreVivant ev)
        {
            base.Mourir(ev);
            Console.WriteLine("{0} est mort(e)! RIP {0}!", Nom);
        }
    }
}
