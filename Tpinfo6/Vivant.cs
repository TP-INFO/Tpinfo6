using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public abstract class Vivant
    {
        private TypeRessources _type;
        private string _satiete;
        private string _sante;
        private int _resistance;
        private static readonly Random rdn = new Random();



        public Vivant(TypeRessources type)
        {
            _type = type;
            _resistance = rdn.Next(5, 21);
        }



        public TypeRessources LeType
        {
            get { return _type; }
            set { _type = value; }
        }
        
        public string LaSatiete
        {
            get { return _satiete; }
            set { _satiete = value; }
                
        }
        public string LaSante
        {
            get { return _sante; }
            set { _sante = value; }
        }
        public int LaResistance
        {
            get { return _resistance; }
            set { _resistance = value; }
        }
        




    }
}