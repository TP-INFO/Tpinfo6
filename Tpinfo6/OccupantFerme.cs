using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public class OccupantFerme : Occupant
    {
        private int _Prenom { get; set; }

        public OccupantFerme(TypeVivant Type, string Prenom, string Nom, bool Affame, bool Malade, int Resistance) :base(Type, Nom, Affame, Malade, Resistance)
        {

        }
    }
}