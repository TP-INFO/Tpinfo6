using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public class Virus : Vivant
    {
        private int Incubation { get; set; }
        private int Virulence { get; set; }

        public Virus(TypeVivant Type, bool Affame, bool Malade, int Resistance, int Incubation, int Virulence) :base(Type, Affame, Malade, Resistance)
        {

        }
        
    }
}