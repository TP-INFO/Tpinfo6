using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public class Cerisier : Vivant
    {
        private List<Cerisier> cerisier;

        

        public Cerisier(TypeVivant type) : base(type)
        {            
        }
        
        
        public List<Cerisier> Lecerisier
        {
            get { return cerisier; }
            set { cerisier = value; }
        }

        public override void AfficherTroupeau()
        {

        }

        //public override void CreerTroupeau(int nbreVivant)
        //{
        //    int j = 1;
        //    List<Cerisier> cerisier = new List<Cerisier>();
        //    for (int i = 0; i < nbreVivant; i++)
        //    {
        //        cerisier.Add(new Cerisier(TypeVivant.Vegetal, LaResistance));
        //        foreach (Cerisier item in cerisier)
        //        {
        //            Console.WriteLine(item.LeType + " " + j + ".  Résistance de " + item.LaResistance);
        //            j++;
        //        }
        //    }
            
        //}
    }


}