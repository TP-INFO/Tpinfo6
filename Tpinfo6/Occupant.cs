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
        private string _nom { get; set; }

        public Occupant(TypeVivant type, string nom, bool affame, bool malade) :base(type, affame, malade)
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