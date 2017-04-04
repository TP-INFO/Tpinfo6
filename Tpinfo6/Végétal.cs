using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe mère et fille, publique et abstraite
    /// </summary>
    public abstract class Végétal : EtreVivant
    {
        //Déclaration en protected du type de végétal
        protected string _typeVeg;

        //Accesseur du type
        public string TypeVeg
        {
            get
            {
                return this._typeVeg;
            }
            set
            {
                this._typeVeg = value;
            }
        }
        //Méthode indiquant que le végétal pousse
        public virtual void Pousser()
        {
            Console.WriteLine("{0} profite de la lumière du soleil pour pousser...", TypeVeg);
        }
        //Override de la méthode mourir
        public override void Mourir(EtreVivant ev)
        {
            base.Mourir(ev);
            Console.WriteLine($"Le {TypeVeg} est mort");
        }
    }
}
