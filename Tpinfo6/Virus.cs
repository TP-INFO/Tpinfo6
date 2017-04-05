using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public class Virus : Ressources
    {
        private int Incubation;

        public Virus(int Incubation, RessourcesGenre Genre) : base(Genre)
        {
            this.Incubation = Incubation;
        }

        public int LIncubation
        {
            get { return LIncubation; }
            set { LIncubation = value;}
            
        }
    }
}