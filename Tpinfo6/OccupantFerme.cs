using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public class OccupantFerme : Occupant
    {
        private int _prenom { get; set; }

        public OccupantFerme(TypeVivant type, string prenom, string nom, bool affame, bool malade, int resistance) :base(type, nom, affame, malade)
        {

        }
    }
}