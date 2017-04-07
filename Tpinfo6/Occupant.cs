using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    /// <summary>
    /// On trouve le couple de fermier et l'androide.
    /// La nature correspond entre humain et artificiel.
    /// </summary>
    public class Occupant : Vivant, IQuotidien
    {
        private string _Nom { get; set; }

        public Occupant(TypeVivant Type, string Nom, bool Affame, bool Malade, int Resistance) :base(Type, Affame, Malade, Resistance)
        {

        }

        public void Nourrir()
        {
            throw new NotImplementedException();
        }

        public void Soigner()
        {
            throw new NotImplementedException();
        }

        public void Recolter()
        {
            throw new NotImplementedException();
        }  

       
    }
}