using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public class Abricotier : Vivant
    {
        private int _resistanceAbricotier { get; set; }
        private int resistance { get; set;}
              


        public Abricotier(TypeVivant type, int resistanceAbricotier):base(type)
        {
            this._resistanceAbricotier = resistanceAbricotier;
            Random rdn = new Random();
            resistance = rdn.Next(5, resistanceAbricotier);
            
        }


        public Abricotier(TypeVivant type, bool affame, bool malade) :base(type, affame, malade)
        {
            
        }
    }
}