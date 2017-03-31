using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Classe mère, publique et abstraite
    /// </summary>
    public abstract class NonVivant
    {
        //Déclaration du type de l'objet nonvivant, en protected
        protected string _type;

        //Accesseur du type
        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

    }
}
