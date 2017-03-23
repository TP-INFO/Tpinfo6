using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_22_TP6
{
    public abstract class Animal : EtreVivant
    {
        protected string _nom;

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

        public virtual void SeRéveiller()
        {
            Console.WriteLine("{0} se réveille!", Nom);
        }
        public virtual void SEndormir()
        {
            Console.WriteLine("{0} s'endort: zzzzz!", Nom);
        }
        public virtual void Manger()
        {
            Console.WriteLine("{0} mange : 'chomp, chomp'", Nom);
        }
        public override void Mourir()
        {
            base.Mourir();
            Console.WriteLine("{0} est mort(e)! RIP {0}!", Nom);
        }
    }
}
