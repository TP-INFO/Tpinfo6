using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public abstract class Vivant
    {
        private TypeVivant _type;
        private string _satiete;
        private string _sante;
        private int _resistance;

        public Vivant(TypeVivant type)
        {
            _type = type;
            Random rdn = new Random();
            _resistance = rdn.Next(5, 21);                
        }
        

        public TypeVivant LeType
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
        //public abstract void CreerTroupeau(int nbreVivant);

        public abstract void AfficherTroupeau();


    }
}