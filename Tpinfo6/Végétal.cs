using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    public abstract class Végétal : EtreVivant
    {
        protected string _type;

        public string Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }

        public virtual void Pousser()
        {
            Console.WriteLine("{0} profite de la lumière du soleil pour pousser...", Type);
        }

        public override void Mourir()
        {
            base.Mourir();
            Console.WriteLine($"Le {Type} est mort");
            Type = null;
        }
    }
}
