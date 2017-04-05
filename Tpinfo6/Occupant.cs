using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    /// <summary>
    /// On trouve le couple de fermier et l'androide.
    /// </summary>
    public class Occupant
    {
        private string Nom;
        private string Nature;

        public Occupant(string Nom, string Nature)
        {
            this.Nom = Nom;
            this.Nature = Nature;
        }

        public string LeNom
        {
            get { return LeNom;}
            set { LeNom = value;}
        }

        public string LaNature
        {
            get { return LaNature;}
            set { LaNature = value;}
        }
    }
}