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
    public class Occupant : IQuotidien
    {
        private string Nom;
        private NatureOccupant Nature;

        public Occupant(string Nom, NatureOccupant Nature)
        {
            this.Nom = Nom;
            this.Nature = Nature;
        }

        public string LeNom
        {
            get { return Nom;}
            set { Nom = value;}
        }

        public NatureOccupant LaNature
        {
            get { return Nature;}
            set { Nature = value;}
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