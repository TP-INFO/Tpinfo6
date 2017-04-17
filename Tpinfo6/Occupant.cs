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
        private string _nom;

        public Occupant(TypeVivant type): base(type) { }

        public string LeNom
        {
            get { return _nom; }
            set { _nom = value; }
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

        //public override void CreerTroupeau(int nbreVivant)
        //{
        //    throw new NotImplementedException();
        //}

        public override void AfficherTroupeau()
        {
            throw new NotImplementedException();
        }
    }
}