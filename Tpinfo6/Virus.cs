using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public class Virus : Ressources
    {
        private int Incubation;
        private int Virulence;

        public Virus(RessourcesGenre Genre, int Incubation, int Virulence) : base(Genre)
        {
            this.Incubation = Incubation;
            this.Virulence = Virulence;
        }

        public int LIncubation
        {
            get { return LIncubation; }
            set { LIncubation = value;}
            
        }

        public int LaVirulence
        {
            get { return Virulence; }
            set { Virulence = value;}
        }
    }
}