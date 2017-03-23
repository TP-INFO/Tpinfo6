using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_22_TP6
{
    public class Soleil : Astre
    {
        
        public Soleil(DateTime dtHLever, DateTime dtHCoucher): base(dtHLever, dtHCoucher)
        {
           
        }

        public override void SeLever(DateTime dtHLever)
        {
            Console.WriteLine("Le soleil se lève, il est {0}", dtHLever); 
        }
        public override void SeCoucher(DateTime dtHCoucher)
        {
            Console.WriteLine("Le soleil se couche, il est {0}", dtHCoucher);
        }
    }
}
