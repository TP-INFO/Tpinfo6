using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public class Vegetal : Ressources
    {
        private string Essence;

        public Vegetal(string Essence, RessourcesGenre Genre) : base (Genre)
        {
            this.Essence = Essence;
        }

        public string LEssence
        {
            get { return LEssence;}
            set { LEssence = value;}
        }
    }
}