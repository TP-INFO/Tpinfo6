using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public class OccupantFerme : Occupant
    {
        private string _prenom;

        public OccupantFerme(TypeVivant type, string prenom) : base(type)
        {
            _prenom = prenom;
        }

        public string LePrenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
    }
}