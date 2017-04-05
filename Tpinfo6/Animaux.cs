using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public class Animaux : Ressources
    {
        private string Type;

        public Animaux(string Type, RessourcesGenre Genre) : base (Genre)
        {
            this.Type = Type;
        }

        public string LeType
        {
            get { return Type;}
            set { Type = value;}            
        }
    }
}